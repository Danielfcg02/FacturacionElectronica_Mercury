using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Venta
    {
        public int Id { get; set; } 
        public Producto Producto { get; set; }
        public int Quantity { get; set; }
        public Double Subtotal { get; set; }

        public Venta(int id, Producto producto, int quantity, double subtotal)
        {
            Id = id;
            Producto = producto;
            Quantity = quantity;
            Subtotal = subtotal;
        }

        public Venta( Producto producto, int quantity, double subtotal)
        {
            Producto = producto;
            Quantity = quantity;
            Subtotal = subtotal;
        }

        public Venta()
        {
        }
    }
}
