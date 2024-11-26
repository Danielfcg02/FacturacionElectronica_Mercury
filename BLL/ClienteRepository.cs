using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BLL;
using ENTITY;
using Oracle.ManagedDataAccess.Client;

public class ClienteRepository
{
    private readonly OracleDbContext _context;

    public ClienteRepository(OracleDbContext context)
    {
        _context = context;
    }

    // Obtener todos los clientes
    public async Task<List<Cliente>> GetAllClientesAsync()
    {
        var clientes = new List<Cliente>();
        using (var connection = _context.GetConnection())
        using (var command = new OracleCommand("get_all_clientes", connection))
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("cliente_cursor", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.Output;

            using (var reader = await command.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {
                    clientes.Add(new Cliente
                    {
                        Cedula = reader.GetString(0),
                        Nombre = reader.GetString(1),
                        Correo = reader.GetString(2),
                        Telefono = reader.GetString(3)
                    });
                }
            }
        }
        return clientes;
    }

    public async Task<Cliente> GetClienteByCedulaAsync(string cedula)
    {
        using (var connection = _context.GetConnection())
        using (var command = new OracleCommand("get_cliente", connection))
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;

            // Parámetro de entrada
            command.Parameters.Add("p_cedula", OracleDbType.Varchar2).Value = cedula;

            // Parámetro de salida para el cursor
            command.Parameters.Add("cliente_cursor", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.Output;


            using (var reader = await command.ExecuteReaderAsync())
            {
                if (await reader.ReadAsync())
                {
                    return new Cliente
                    {
                        Cedula = reader.GetString(reader.GetOrdinal("cedula")),
                        Nombre = reader.GetString(reader.GetOrdinal("name")),
                        Correo = reader.GetString(reader.GetOrdinal("email")),
                        Telefono = reader.GetString(reader.GetOrdinal("phone"))
                    };
                }
            }
        }
        return null;
    }


    // Agregar un cliente
    public async Task<string> AddClienteAsync(Cliente cliente)
    {
        using (var connection = _context.GetConnection())
        using (var command = new OracleCommand("create_cliente", connection))
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;

            // Parámetro de retorno
            var returnParameter = command.Parameters.Add("RETURN_VALUE", OracleDbType.Varchar2, 50);
            returnParameter.Direction = System.Data.ParameterDirection.ReturnValue;

            command.Parameters.Add("p_cedula", OracleDbType.Varchar2).Value = cliente.Cedula;
            command.Parameters.Add("p_name", OracleDbType.Varchar2).Value = cliente.Nombre;
            command.Parameters.Add("p_email", OracleDbType.Varchar2).Value = cliente.Correo;
            command.Parameters.Add("p_phone", OracleDbType.Varchar2).Value = cliente.Telefono;

            await command.ExecuteNonQueryAsync();

            // Retornar el valor de retorno de la función
            return returnParameter.Value.ToString();
        }
    }


    // Actualizar un cliente
    public async Task UpdateClienteAsync(Cliente cliente)
    {
        using (var connection = _context.GetConnection())
        using (var command = new OracleCommand("update_cliente", connection))
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("p_cedula", OracleDbType.Varchar2).Value = cliente.Cedula;
            command.Parameters.Add("p_name", OracleDbType.Varchar2).Value = cliente.Nombre;
            command.Parameters.Add("p_email", OracleDbType.Varchar2).Value = cliente.Correo;
            command.Parameters.Add("p_phone", OracleDbType.Varchar2).Value = cliente.Telefono;

            await command.ExecuteNonQueryAsync();
        }
    }

    // Eliminar un cliente
    public async Task DeleteClienteAsync(string cedula)
    {
        using (var connection = _context.GetConnection())
        using (var command = new OracleCommand("delete_cliente", connection))
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("p_cedula", OracleDbType.Varchar2).Value = cedula;

            await command.ExecuteNonQueryAsync();
        }
    }

    public async Task<List<ClienteTopDto>> GetTop10Clientes(DateTime fechaInicio, DateTime fechaFin)
    {
        var topClientes = new List<ClienteTopDto>();

        using (var connection = _context.GetConnection())
        using (var command = new OracleCommand("GetTop10Clientes", connection))
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;


            command.Parameters.Add("p_fecha_inicio", OracleDbType.Date).Value = fechaInicio;
            command.Parameters.Add("p_fecha_fin", OracleDbType.Date).Value = fechaFin;


            command.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.Output;


            using (var reader = await command.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {
                    var cliente = new ClienteTopDto
                    {
                        Cedula = reader.GetString(reader.GetOrdinal("cedula")),
                        Nombre = reader.GetString(reader.GetOrdinal("nombre")),
                        TotalFacturado = reader.GetDecimal(reader.GetOrdinal("TotalFacturado"))
                    };

                    topClientes.Add(cliente);
                }
            }
        }

        return topClientes;
    }

}
