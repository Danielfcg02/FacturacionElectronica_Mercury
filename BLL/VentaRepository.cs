using System.Collections.Generic;
using System.Threading.Tasks;
using BLL;
using ENTITY;
using Oracle.ManagedDataAccess.Client;

public class VentaRepository
{
    private readonly OracleDbContext _context;

    public VentaRepository(OracleDbContext context)
    {
        _context = context;
    }

    // Obtener todas las ventas por factura
    public async Task<List<Venta>> GetVentasByFacturaId(string facturaId)
    {
        var ventas = new List<Venta>();

        using (var connection = _context.GetConnection())
        using (var command = new OracleCommand("get_ventas_by_factura", connection))
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("p_factura_id", OracleDbType.Int32).Value = facturaId;
            command.Parameters.Add("venta_cursor", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.Output;


            using (var reader = await command.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {
                    ventas.Add(new Venta
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("venta_id")),
                        Producto = new Producto
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("producto_id")),
                            Nombre = reader.GetString(reader.GetOrdinal("producto_nombre")),
                            Descripcion = reader.IsDBNull(reader.GetOrdinal("producto_descripcion"))
                            ? null
                            : reader.GetString(reader.GetOrdinal("producto_descripcion")),
                            Precio = reader.GetDouble(reader.GetOrdinal("producto_precio")),
                            Stock = reader.GetInt32(reader.GetOrdinal("producto_stock"))
                        },
                        Quantity = reader.GetInt32(reader.GetOrdinal("quantity")),
                        Subtotal = reader.GetDouble(reader.GetOrdinal("subtotal"))
                    });
                }
            }
        }

        return ventas;
    }


    // Obtener una venta específica por factura y producto
    public async Task<Venta> GetVenta(int facturaId, int productoId)
    {
        using (var connection = _context.GetConnection())
        using (var command = new OracleCommand("get_venta", connection))
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("p_factura_id", OracleDbType.Int32).Value = facturaId;
            command.Parameters.Add("p_producto_id", OracleDbType.Int32).Value = productoId;
            command.Parameters.Add("venta_cursor", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.Output;

            using (var reader = await command.ExecuteReaderAsync())
            {
                if (await reader.ReadAsync())
                {
                    //return new Venta
                    //{
                    //    FacturaId = reader.GetInt32(0),
                    //    ProductoId = reader.GetInt32(1),
                    //    Quantity = reader.GetInt32(2),
                    //    Subtotal = reader.GetDecimal(3)
                    //};
                }
            }
        }
        return null;
    }

    // Agregar una venta
    public async Task AddVenta(Venta venta, string facturaId, OracleConnection connection, OracleTransaction transaction)
    {
        try
        {
            using (var command = new OracleCommand("create_venta", connection))
            {
                command.Transaction = transaction;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("p_factura_id", OracleDbType.Int32).Value = facturaId;
                command.Parameters.Add("p_producto_id", OracleDbType.Int32).Value = venta.Producto.Id;
                command.Parameters.Add("p_quantity", OracleDbType.Int32).Value = venta.Quantity;
                command.Parameters.Add("p_subtotal", OracleDbType.Decimal).Value = venta.Subtotal;

                await command.ExecuteNonQueryAsync();
            }
        }
        catch
        {
            throw;
        }
    }

    public async Task AddVenta(Venta venta, string facturaId)
    {
        using (var connection =  _context.GetConnection())
        {
            using (var command = new OracleCommand("create_venta", connection))
            {

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("p_factura_id", OracleDbType.Int32).Value = facturaId;
                command.Parameters.Add("p_producto_id", OracleDbType.Int32).Value = venta.Producto.Id;
                command.Parameters.Add("p_quantity", OracleDbType.Int32).Value = venta.Quantity;
                command.Parameters.Add("p_subtotal", OracleDbType.Decimal).Value = venta.Subtotal;

                await command.ExecuteNonQueryAsync();

            }
        }
    }


    // Actualizar una venta
    public async Task UpdateVenta(Venta venta)
    {
        using (var connection = _context.GetConnection())
        using (var command = new OracleCommand("update_venta", connection))
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add("p_venta_id", OracleDbType.Int32).Value = venta.Id;
            command.Parameters.Add("p_quantity", OracleDbType.Int32).Value = venta.Quantity;
            command.Parameters.Add("p_subtotal", OracleDbType.Decimal).Value = venta.Subtotal;

            await command.ExecuteNonQueryAsync();
        }
    }


    // Eliminar una venta
    public async Task DeleteVenta(int facturaId, int productoId)
    {
        using (var connection = _context.GetConnection())
        using (var command = new OracleCommand("delete_venta", connection))
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("p_factura_id", OracleDbType.Int32).Value = facturaId;
            command.Parameters.Add("p_producto_id", OracleDbType.Int32).Value = productoId;

            await command.ExecuteNonQueryAsync();
        }
    }
}
