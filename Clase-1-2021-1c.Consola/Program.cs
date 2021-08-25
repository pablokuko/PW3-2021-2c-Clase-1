using System;

namespace Clase_1_2021_1c.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //comentar: ctrl + K, C
            //descomentar: ctrl + K, U
            Console.WriteLine("Ingrese un nro:");
            string strNum1 = Console.ReadLine();

            Console.WriteLine("Ingrese otro nro:");
            string strNum2 = Console.ReadLine();

            int num1 = int.Parse(strNum1);
            int num2 = int.Parse(strNum2);

            Console.WriteLine("La suma es: " + (num1 + num2));
        }
    }
}
