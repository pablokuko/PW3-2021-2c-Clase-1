using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW3_2021_2c_Clase_1.Logica
{
    public class IndiceMasaCorporal
    {

        public static double Indice(string valor1, string valor2)
        {

            if (!int.TryParse(valor1, out int peso))
            {
                throw new ArgumentException("El valor ingresado no es un nro entero valido.");
            }

            if (!int.TryParse(valor2, out int altura))
            {
                throw new ArgumentException("El valor ingresado no es un nro entero valido.");
            }

            int altura2;
            altura2 = altura * 100;
            return peso/(altura2*altura2);

        }
    }
}
