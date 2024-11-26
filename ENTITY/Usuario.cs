using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Usuario
    {
        public string Cedula { get; set; }
        public string Name { get; set; }
        public string UserName{ get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public Usuario() { }

        public Usuario(string cedula, string name, string userName, string email, string password, string role, string phone)
        {
            Cedula = cedula;
            Name = name;
            UserName = userName;
            Email = email;
            Password = password;
            Role = role;
            Phone = phone;
        }
    }
}
