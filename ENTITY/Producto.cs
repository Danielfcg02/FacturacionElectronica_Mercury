using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public string Descripcion { get; set; }

        public string Talla { get; set; }

        public Producto() { }

        public Producto(string name, string description, double price, int stock, string talla)
        {
            Nombre = name;
            Precio = price;
            Stock = stock;
            Talla = talla;
            Descripcion = description;
        }

        public Producto(int id, string name, string description, double price, int stock)
        {
            Id = id;
            Nombre = name;
            Descripcion = description;
            Precio = price;
            Stock = stock;
        }
    }
}
