using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW3_2021_2c_Clase_1.Logica
{
    public class IndiceMasaCorporal
    {

        public static void Indice(string valor1, string valor2)
        {

            if (!int.TryParse(valor1, out int peso))
            {
                throw new ArgumentException("El valor ingresado no es un nro entero valido.");
            }

            if (!int.TryParse(valor2, out int altura))
            {
                throw new ArgumentException("El valor ingresado no es un nro entero valido.");
            }

            double altura2, imc;
            altura2 = altura*0.01;
            imc = peso / (altura2 * altura2);

           
            if (imc < 18.50)
            {
                if(imc < 16)
                
                    Console.WriteLine("Bajo peso - Delgadez Severa " + imc.ToString("N2"));

                else if (imc >= 16 && imc <= 16.99)
                
                    Console.WriteLine("Bajo peso - Delgadez Moderada " + imc);

                else if (imc >= 17 && imc <= 18.49)

                    Console.WriteLine("Bajo peso - Delgadez Leve " + imc);

            }else if (imc >=18.50 && imc <= 24.99)

                Console.WriteLine("Peso Normal "  + imc);

            else if (imc>=25 && imc<=29.99)

                Console.WriteLine("Sobrepeso - Preobesidad " + imc);

            else if (imc >=30)

            {
                if (imc <= 34.99)

                    Console.WriteLine("Obesidad Leve " + imc);

                else if (imc <= 39.99)

                    Console.WriteLine("Obesidad Media " + imc);

                else if (imc > 40)

                    Console.WriteLine("Obesidad Mórbida " + imc);


            }


        }



    }
}
