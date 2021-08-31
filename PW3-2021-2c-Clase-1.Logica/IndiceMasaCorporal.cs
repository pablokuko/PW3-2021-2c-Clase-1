using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW3_2021_2c_Clase_1.Logica
{
    class IndiceMasaCorporal
    {

        public static double Indice(string peso, string altura)
        {

            if (!int.TryParse(peso, out int num1))
            {
                throw new ArgumentException("El valor ingresado no es un nro entero valido.");
            }

            if (!int.TryParse(altura, out int num2))
            {
                throw new ArgumentException("El valor ingresado no es un nro entero valido.");
            }

            return num1 / Math.Pow(num2, 2);

        }
    }
}
