using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW3_2021_2c_Clase_1.Logica {
    public static class BodyMassIndex {
		public static double askForHeight() {
			string heightInput;
			double height = -1;

			Console.WriteLine("Ingrese su altura en m (puede usar coma). Ejemplo: 1,85");
			heightInput = Console.ReadLine();

			try {
				 height = double.Parse(heightInput);
			} catch (Exception) {
				Console.WriteLine("El valor ingresado de altura no es válido.");
			}

			return height;
		}

		public static double askForWeight() {
			string weightInput;
			double weight = -1;

			Console.WriteLine("Ingrese su peso en kg (puede usar coma). Ejemplo: 80,7");
			weightInput = Console.ReadLine();

			try {
				weight = double.Parse(weightInput);
			} catch (Exception) {
				Console.WriteLine("El valor ingresado de peso no es válido.");
			}

			return weight;
		}

		public static double calcBMI(double height, double weight) {
            return weight / Math.Pow(height, 2);
        }

		public static string getCategoryConsidering(double bmi) {
			string category = "";

			if (bmi < 18.50) {
				category = "Bajo peso";
			} else if (bmi >= 18.50 && bmi <= 24.99) {
				category = "Peso normal";
			} else {
				category = "Sobrepeso";
			}

			return category;
		}

		public static string getSubcategoryConsidering(double bmi) {
			string subCategory = "";
			
			if (bmi < 18.50) {
				subCategory = "Delgadez severa (< 18.50)";
			} else if (bmi >= 16.00 && bmi <= 16.99) {
				subCategory = "Delgadez moderada (16.00 - 17.00)";
			} else if (bmi >= 17.00 && bmi <= 18.49) {
				subCategory = "Delgadez leve (17.00 - 18.50)";
			} else if (bmi >= 18.50 && bmi <= 24.99) {
				subCategory = "(18.50 - 25.00)";
			} else if (bmi >= 25.00 && bmi <= 29.99) {
				subCategory = "Preobesidad (25.00 - 30.00)";
			} else if (bmi >= 30.00 && bmi <= 34.99) {
				subCategory = "Obesidad leve (30.00 - 35.00)";
			} else if (bmi >= 35.00 && bmi <= 39.99) {
				subCategory = "Obesidad media (35.00 - 40.00)";
			} else if (bmi >= 40.00) {
				subCategory = "Obesidad mórbida (> 40.00)";
			}

			return subCategory;
		}
	}
}