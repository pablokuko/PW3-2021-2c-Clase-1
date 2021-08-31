using System;

namespace PW3_2021_2c_Clase_1.Logica
{
    public class Calculadora
    {
        public static int Sumar(string val1, string val2)
        {
            //int num1 = int.Parse(val1);
            //int num2 = int.Parse(val2);
            //Convert.ToInt32();
            if (!int.TryParse(val1, out int num1))
            {
                throw new ArgumentException("El valor ingresado no es un nro entero valido.");
            }

            if (!int.TryParse(val2, out int num2))
            {
                throw new ArgumentException("El valor ingresado no es un nro entero valido.");
            }

            return num1 + num2;
        }
    }
}
