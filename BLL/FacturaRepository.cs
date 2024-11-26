using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using ENTITY;
using BLL;

public class FacturaRepository
{
    private readonly OracleDbContext _context;
    private readonly VentaRepository _ventaRepository;

    public FacturaRepository(OracleDbContext context, VentaRepository ventaRepository)
    {
        _context = context;
        _ventaRepository = ventaRepository;
    }

    // Agregar una factura junto con sus ventas
    public async Task GuardarFactura(Factura factura)
    {
        using (var connection = _context.GetConnection())
        {

            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    using (var command = new OracleCommand("create_factura", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Transaction = transaction;

                        command.Parameters.Add("p_user_cedula", OracleDbType.Varchar2).Value = factura.User.Cedula;
                        command.Parameters.Add("p_cliente_cedula", OracleDbType.Varchar2).Value = factura.Cliente.Cedula;
                        command.Parameters.Add("p_total", OracleDbType.Decimal).Value = factura.Total;

                        
                        var newIdParam = new OracleParameter("p_new_id", OracleDbType.Int32)
                        {
                            Direction = System.Data.ParameterDirection.Output
                        };
                        command.Parameters.Add(newIdParam);

                        await command.ExecuteNonQueryAsync();

                        factura.Id = Convert.ToString(newIdParam.Value);
                    }

                    foreach (var venta in factura.Ventas)
                    {
                        await _ventaRepository.AddVenta(venta, factura.Id, connection, transaction);
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }


    public async Task<List<Factura>> GetFacturasByFecha(DateTime fechaInicio, DateTime fechaFin)
{
    var facturas = new List<Factura>();

    using (var connection = _context.GetConnection())
    using (var command = new OracleCommand("get_facturas_por_fecha", connection))
    {
        command.CommandType = System.Data.CommandType.StoredProcedure;

        command.Parameters.Add("p_fecha_inicio", OracleDbType.Date).Value = fechaInicio;
        command.Parameters.Add("p_fecha_fin", OracleDbType.Date).Value = fechaFin;
        command.Parameters.Add("factura_cursor", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.Output;
        
        using (var reader = await command.ExecuteReaderAsync())
        {
            while (await reader.ReadAsync())
            {
                var factura = new Factura
                {
                    Id = reader.GetString(reader.GetOrdinal("factura_id")),
                    User = new Usuario
                    {
                        Cedula = reader.GetString(reader.GetOrdinal("user_cedula")),
                        Name = reader.GetString(reader.GetOrdinal("usuario_nombre")),
                        Email = reader.GetString(reader.GetOrdinal("usuario_email"))
                    },
                    Cliente = new Cliente
                    {
                        Cedula = reader.GetString(reader.GetOrdinal("cliente_cedula")),
                        Nombre = reader.GetString(reader.GetOrdinal("cliente_nombre")),
                        Correo = reader.GetString(reader.GetOrdinal("cliente_email")),
                        Telefono = reader.GetString(reader.GetOrdinal("cliente_telefono"))
                    },
                    Total = reader.GetDouble(reader.GetOrdinal("total")),
                    FechaCreacion = reader.GetDateTime(reader.GetOrdinal("fecha_creacion"))
                };

                facturas.Add(factura);
            }
        }
    }

    return facturas;
}


    // Actualizar una factura
    public async Task UpdateFactura(Factura factura)
    {
        using (var connection = _context.GetConnection())
        using (var command = new OracleCommand("update_factura", connection))
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("p_id", OracleDbType.Int32).Value = factura.Id;
            command.Parameters.Add("p_user_cedula", OracleDbType.Varchar2).Value = factura.User.Cedula;
            command.Parameters.Add("p_cliente_cedula", OracleDbType.Varchar2).Value = factura.Cliente.Cedula;
            command.Parameters.Add("p_total", OracleDbType.Decimal).Value = factura.Total;

            await command.ExecuteNonQueryAsync();
        }
    }

    // Eliminar una factura
    public async Task DeleteFactura(int id)
    {
        using (var connection = _context.GetConnection())
        using (var command = new OracleCommand("delete_factura", connection))
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("p_id", OracleDbType.Int32).Value = id;

            await command.ExecuteNonQueryAsync();
        }
    }

}
