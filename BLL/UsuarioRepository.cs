using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BLL;
using ENTITY;
using Oracle.ManagedDataAccess.Client;

public class UsuarioRepository
{
    private readonly OracleDbContext _context;

    public UsuarioRepository(OracleDbContext context)
    {
        _context = context;
    }

    public async Task<List<Usuario>> GetAllUsuarios()
    {
        var usuarios = new List<Usuario>();
        using (var connection = _context.GetConnection())
        using (var command = new OracleCommand("get_all_usuarios", connection))
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("usuario_cursor", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.Output;

            using (var reader = await command.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {
                    usuarios.Add(new Usuario
                    {
                        Cedula = reader.GetString(0),
                        Name = reader.GetString(1),
                        UserName = reader.GetString(2),
                        Password = reader.GetString(3),
                        Email = reader.GetString(4),
                        Role = reader.GetString(5),
                        Phone = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                    });
                }
            }
        }
        return usuarios;
    }

    // Obtener un usuario por userName
    public async Task<Usuario> GetUsuarioByUserName(string userName)
    {
        using (var connection = _context.GetConnection())
        using (var command = new OracleCommand("get_usuario_by_username", connection))
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;

            // Parámetro de entrada
            command.Parameters.Add("p_username", OracleDbType.Varchar2).Value = userName;

            // Parámetro de salida para el cursor
            var resultParam = new OracleParameter("usuario_cursor", OracleDbType.RefCursor)
            {
                Direction = System.Data.ParameterDirection.Output
            };
            command.Parameters.Add(resultParam);

            using (var reader = await command.ExecuteReaderAsync())
            {
                if (await reader.ReadAsync())
                {
                    return new Usuario
                    {
                        Cedula = reader.GetString(0),
                        Name = reader.GetString(1),
                        Email = reader.GetString(2),
                        Password = reader.GetString(3),
                        Role = reader.GetString(4),
                        UserName = reader.GetString(5),
                    };
                }
            }
        }
        return null;
    }

    public async Task<Usuario> GetUsuarioByCedula(string cedula)
    {
        using (var connection = _context.GetConnection())
        using (var command = new OracleCommand("get_usuario", connection))
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("p_cedula", OracleDbType.Varchar2).Value = cedula;
            command.Parameters.Add("usuario_cursor", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.Output;

            using (var reader = await command.ExecuteReaderAsync())
            {
                if (await reader.ReadAsync())
                {
                    return new Usuario
                    {
                        Cedula = reader.GetString(0),
                        Name = reader.GetString(1),
                        Email = reader.GetString(2),
                        Password = reader.GetString(3),
                        Role = reader.GetString(4)
                    };
                }
            }
        }
        return null;
    }

    // Agregar un usuario
    public async Task AddUsuario(Usuario usuario)
    {
        using (var connection = _context.GetConnection())
        using (var command = new OracleCommand("create_usuario", connection))
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("p_cedula", OracleDbType.Varchar2).Value = usuario.Cedula;
            command.Parameters.Add("p_name", OracleDbType.Varchar2).Value = usuario.Name;
            command.Parameters.Add("p_user_name", OracleDbType.Varchar2).Value = usuario.UserName;
            command.Parameters.Add("p_email", OracleDbType.Varchar2).Value = usuario.Email;
            command.Parameters.Add("p_password", OracleDbType.Varchar2).Value = usuario.Password;
            command.Parameters.Add("p_role", OracleDbType.Varchar2).Value = usuario.Role;
            command.Parameters.Add("p_phone", OracleDbType.Varchar2).Value = usuario.Phone;

            await command.ExecuteNonQueryAsync();
        }
    }


    // Actualizar un usuario
    public async Task UpdateUsuario(Usuario usuario)
    {
        using (var connection = _context.GetConnection())
        using (var command = new OracleCommand("update_usuario", connection))
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add("p_cedula", OracleDbType.Varchar2).Value = usuario.Cedula;
            command.Parameters.Add("p_name", OracleDbType.Varchar2).Value = usuario.Name;
            command.Parameters.Add("p_user_name", OracleDbType.Varchar2).Value = usuario.UserName; 
            command.Parameters.Add("p_email", OracleDbType.Varchar2).Value = usuario.Email;
            command.Parameters.Add("p_password", OracleDbType.Varchar2).Value = usuario.Password;
            command.Parameters.Add("p_role", OracleDbType.Varchar2).Value = usuario.Role;
            command.Parameters.Add("p_phone", OracleDbType.Varchar2).Value = usuario.Phone; 

            await command.ExecuteNonQueryAsync();
        }
    }


    // Eliminar un usuario
    public async Task DeleteUsuario(string cedula)
    {
        using (var connection = _context.GetConnection())
        using (var command = new OracleCommand("delete_usuario", connection))
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("p_cedula", OracleDbType.Varchar2).Value = cedula;

            await command.ExecuteNonQueryAsync();
        }
    }
    public async Task<List<VendedorDto>> GetTop10Vendedores(DateTime fechaInicio, DateTime fechaFin)
    {
        var vendedores = new List<VendedorDto>();

        using (var connection = _context.GetConnection())
        using (var command = new OracleCommand("GetTop10Vendedores", connection))
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add("p_fecha_inicio", OracleDbType.Date).Value = fechaInicio;
            command.Parameters.Add("p_fecha_fin", OracleDbType.Date).Value = fechaFin;

            var cursorParam = new OracleParameter("p_cursor", OracleDbType.RefCursor)
            {
                Direction = System.Data.ParameterDirection.Output
            };
            command.Parameters.Add(cursorParam);

            using (var reader = await command.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {
                    var vendedor = new VendedorDto
                    {
                        Cedula = reader.GetString(reader.GetOrdinal("cedula")),
                        Nombre = reader.GetString(reader.GetOrdinal("nombre")),
                        TotalFacturado = reader.GetDouble(reader.GetOrdinal("TotalFacturado"))
                    };

                    vendedores.Add(vendedor);
                }
            }
        }

        return vendedores;
    }
}
