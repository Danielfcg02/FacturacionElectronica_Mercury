using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using BLL;
using ENTITY;
using Oracle.ManagedDataAccess.Client;

public class ProductoRepository
{
    private readonly OracleDbContext _context;

    public ProductoRepository(OracleDbContext context)
    {
        _context = context;
    }

    public async Task<List<Producto>> GetAllProductos()
    {
        List<Producto> productos = new List<Producto>();

        using (var connection = _context.GetConnection())
        using (var command = new OracleCommand("get_all_productos", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
           
            command.Parameters.Add("producto_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.ReturnValue;

            using (var reader = await command.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {
                    productos.Add(new Producto
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Descripcion = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Precio = reader.GetDouble(3),
                        Stock = reader.GetInt32(4),
                        Talla = reader.IsDBNull(5) ? string.Empty : reader.GetString(5)
                    });
                }
            }
        }

        return productos;
    }

    public async Task<Producto> GetProductoById(int id)
    {
        using (var connection = _context.GetConnection())
        using (var command = new OracleCommand("get_producto", connection))
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("p_id", OracleDbType.Int32).Value = id;
            command.Parameters.Add("producto_cursor", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.Output;

            using (var reader = await command.ExecuteReaderAsync())
            {
                if (await reader.ReadAsync())
                {
                    return new Producto
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Descripcion = reader.GetString(2),
                        Precio = reader.GetDouble(3),
                        Stock = reader.GetInt32(4)
                    };
                }
            }
        }
        return null;
    }

    public async Task CreateProducto(Producto producto)
    {
        using (var connection = _context.GetConnection())
        using (var command = new OracleCommand("BEGIN :new_id := create_producto(:p_name, :p_description, :p_price, :p_stock, :p_talla); END;", connection))
        {
            command.CommandType = System.Data.CommandType.Text;

            // Parámetro de retorno
            command.Parameters.Add("new_id", OracleDbType.Decimal).Direction = System.Data.ParameterDirection.ReturnValue;

            // Añadir los parámetros de entrada
            command.Parameters.Add("p_name", OracleDbType.Varchar2).Value = producto.Nombre;
            command.Parameters.Add("p_description", OracleDbType.Varchar2).Value = producto.Descripcion;
            command.Parameters.Add("p_price", OracleDbType.Decimal).Value = producto.Precio;
            command.Parameters.Add("p_stock", OracleDbType.Int32).Value = producto.Stock;
            command.Parameters.Add("p_talla", OracleDbType.Varchar2).Value = producto.Talla; // Nuevo parámetro para la talla

            await command.ExecuteNonQueryAsync();

            // Obtener el ID retornado por la función usando OracleDecimal
            var oracleDecimal = (Oracle.ManagedDataAccess.Types.OracleDecimal)command.Parameters["new_id"].Value;
            producto.Id = oracleDecimal.ToInt32();
        }
    }

    public async Task UpdateProducto(Producto producto)
    {
        using (var connection = _context.GetConnection())
        using (var command = new OracleCommand("update_producto", connection))
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("p_id", OracleDbType.Int32).Value = producto.Id;
            command.Parameters.Add("p_name", OracleDbType.Varchar2).Value = producto.Nombre;
            command.Parameters.Add("p_description", OracleDbType.Varchar2).Value = producto.Descripcion;
            command.Parameters.Add("p_price", OracleDbType.Decimal).Value = producto.Precio;
            command.Parameters.Add("p_stock", OracleDbType.Int32).Value = producto.Stock;
            command.Parameters.Add("p_talla", OracleDbType.Varchar2).Value = producto.Talla; // Nuevo parámetro para la talla

            await command.ExecuteNonQueryAsync();
        }
    }

    public async Task DeleteProducto(int id)
    {
        using (var connection = _context.GetConnection())
        using (var command = new OracleCommand("delete_producto", connection))
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("p_id", OracleDbType.Int32).Value = id;

            await command.ExecuteNonQueryAsync();
        }
    }
}