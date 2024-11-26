using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductoService
    {
        private readonly ProductoRepository _productoRepository;

        public ProductoService()
        {
            _productoRepository = new ProductoRepository(new BLL.OracleDbContext());
        }

        // Obtener todos los productos
        
        public async Task<List<Producto>> GetAllProductos(bool disponibles=true)
        {
            List<Producto> productos = await _productoRepository.GetAllProductos();
            if (!disponibles)
            {
                productos.RemoveAll(producto => producto.Stock == 0);
            }
            return productos;

        }

        // Obtener un producto por ID
        public async Task<Producto> GetProductoByIdAsync(int id)
        {
            if (id <= 0) throw new ArgumentException("El ID debe ser mayor que cero.");
            return await _productoRepository.GetProductoById(id);
        }

        // Agregar un producto
        public async Task CreateProducto(string name, string description, double price, int stock , string talla)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("El nombre no puede estar vacío.");

            var producto = new Producto { Nombre = name, Descripcion = description, Precio = price, Stock = stock, Talla = talla };
            await _productoRepository.CreateProducto(producto);
        }

        // Actualizar un producto
        public async Task UpdateProducto(Producto producto)
        {
            await _productoRepository.UpdateProducto(producto);
        }

        // Eliminar un producto
        public async Task DeleteProductoAsync(int id)
        {
            await _productoRepository.DeleteProducto(id);
        }
    }

}
