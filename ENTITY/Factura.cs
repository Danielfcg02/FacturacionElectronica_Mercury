using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Factura
    {
        public string Id { get; set; }
        public Usuario User { get; set; }
        public Cliente Cliente { get; set; }
        public double Total { get; set; }
        public List<Venta> Ventas { get; set; } = new List<Venta>();
        public DateTime FechaCreacion { get; set; }

        public Factura() { }

        public Factura(Usuario user, Cliente cliente, List<Venta> ventas)
        {
            User= user;
            Cliente = cliente;
            Ventas = ventas;
            FechaCreacion = DateTime.Now;
        }
    }

}
