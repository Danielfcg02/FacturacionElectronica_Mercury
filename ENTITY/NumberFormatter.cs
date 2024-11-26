using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public static class NumberFormatter
    {
        public static string FormatWithSuffix(double number)
        {
            if (number >= 1000)
            {
                return (number / 1000).ToString("0.0") + "k";
            }
            return number.ToString("0.00");
        }

        public static double ParseFromSuffix(string formattedNumber)
        {
            
            if (formattedNumber.EndsWith("k", StringComparison.OrdinalIgnoreCase))
            {
                string numberPart = formattedNumber.TrimEnd('k');
                if (double.TryParse(numberPart, out double result))
                {
                    return result * 1000;
                }
            }

            // Intenta convertirlo directamente a double si no tiene el sufijo 'k'
            if (double.TryParse(formattedNumber, out double directResult))
            {
                return directResult;
            }

            throw new FormatException("El formato de número proporcionado no es válido.");
        }
    }
}
