using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ENTITY
{
    public static class Validator
    {
        public static bool ValidarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Expresión regular para validar el formato del correo electrónico
            var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return regex.IsMatch(email);
        }

        public static bool ValidarEnteroPositivo(int? numero)
        {
            return numero.HasValue && numero.Value > 0;
        }

        public static bool ValidarTexto(string texto, int maxLength, int minLength = 3)
        {
            return !string.IsNullOrWhiteSpace(texto) && texto.Length <= maxLength && texto.Length>=minLength;
        }

        public static bool ValidarDecimalPositivo(double? numero)
        {
            return numero.HasValue && numero.Value > 0;
        }
    }
}
