using PW3_2021_2c_Clase_1.Logica;
using System;

namespace Clase_1_2021_1c.Consola {
    class Program {
        static void Main(string[] args) {
			EjercicioIMC();
			//EjercicioBola8Magica();
			//EjercicioCalculadora();
		}

		private static void EjercicioIMC() {
			float heightNumber;
			float weightNumber;
			float bmi;

			string height = "altura";
			string weight = "peso";
			string category;			   
			string subCategory;

			BodyMassIndex.askFor(height, out heightNumber);
			BodyMassIndex.askFor(weight, out weightNumber);

			bmi = BodyMassIndex.calcBMI(heightNumber, weightNumber);
			category = BodyMassIndex.getCategoryConsidering(bmi);
			subCategory = BodyMassIndex.getSubcategoryConsidering(bmi);

			Console.WriteLine(category + " - " + subCategory);
		}

		private static void EjercicioBola8Magica() {
            string pregunta;
            Console.WriteLine("Ingrese la pregunta y el universo dará su respuesta (ingrese 0 para salir): ");
            pregunta = Console.ReadLine();

            while (pregunta != "0") {
                string respuesta = Bola8Magica.Preguntar(pregunta);
                Console.WriteLine(respuesta);
                Console.WriteLine("Ingrese la pregunta y el universo dará su respuesta (ingrese 0 para salir): ");
                pregunta = Console.ReadLine();
            }
        }

        private static void EjercicioCalculadora() {
            //comentar: ctrl + K, C
            //descomentar: ctrl + K, U
            Console.WriteLine("Ingrese un nro:");
            string strNum1 = Console.ReadLine();

            Console.WriteLine("Ingrese otro nro:");
            string strNum2 = Console.ReadLine();

            //Console.WriteLine("La suma es: " + Calculadora.Sumar(strNum1, strNum2));
            Console.WriteLine($"La suma es: {Calculadora.Sumar(strNum1, strNum2)}");
        }
    }
}