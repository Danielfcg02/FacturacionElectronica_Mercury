using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Cliente
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public Cliente() { }

        public Cliente(string cedula, string nombre, string correo, string telefono)
        {
            Cedula = cedula;
            Nombre = nombre;
            Correo = correo;
            Telefono = telefono;
        }
    }
}
