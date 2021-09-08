using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW3_2021_2c_Clase_1.Logica {
	public static class BMIcategories {
		public const string
			BajoPeso = "Bajo peso",
			Normal = "Peso normal",
			Sobrepeso = "Sobrepeso";
	}

	public static class BMIsubCategories {
		public const string
			DelgadezSevera = "Delgadez severa (< 18.50)",
			DelgadezModerada = "Delgadez moderada (16.00 - 17.00)",
			DelgadezLeve = "Delgadez leve (17.00 - 18.50)",
			Normal = "(18.50 - 25.00)",
			Preobesidad = "Preobesidad (25.00 - 30.00)",
			ObesidadLeve = "Obesidad leve (30.00 - 35.00)",
			ObesidadMedia = "Obesidad media (35.00 - 40.00)",
			ObesidadMorbida = "Obesidad mórbida (> 40.00)";
	}

	public static class BodyMassIndex {
		public static void askFor(string heightOrWeightString, out float heightOrWeight) {
			string heightOrWeightInput;
			string example = heightOrWeightString == "altura" ? "1,85" : "80,7";

			do {
				Console.WriteLine($"Ingrese su { heightOrWeightString } en m (puede usar coma). Ejemplo: { example }");
				heightOrWeightInput = Console.ReadLine();

				if (!float.TryParse(heightOrWeightInput, out heightOrWeight) || heightOrWeight <= 0) {
					Console.WriteLine($"El valor ingresado de { heightOrWeightString } no es válido.");
				}
			} while (heightOrWeight <= 0);
		}

		public static float calcBMI(float height, float weight) {
            return (float) (weight / Math.Pow(height, 2));
        }

		public static string getCategoryConsidering(float bmi) {
			string category = "";

			if (bmi < 18.50) {
				category = BMIcategories.BajoPeso;
			} else if (bmi >= 18.50 && bmi <= 24.99) {
				category = BMIcategories.Normal;
			} else {
				category = BMIcategories.Sobrepeso;
			}

			return category;
		}

		public static string getSubcategoryConsidering(float bmi) {
			string subCategory = "";
			
			if (bmi < 18.50) {
				subCategory = BMIsubCategories.DelgadezSevera;
			} else if (bmi >= 16.00 && bmi <= 16.99) {
				subCategory = BMIsubCategories.DelgadezModerada;
			} else if (bmi >= 17.00 && bmi <= 18.49) {
				subCategory = BMIsubCategories.DelgadezLeve;
			} else if (bmi >= 18.50 && bmi <= 24.99) {
				subCategory = BMIsubCategories.Normal;
			} else if (bmi >= 25.00 && bmi <= 29.99) {
				subCategory = BMIsubCategories.Preobesidad;
			} else if (bmi >= 30.00 && bmi <= 34.99) {
				subCategory = BMIsubCategories.ObesidadLeve;
			} else if (bmi >= 35.00 && bmi <= 39.99) {
				subCategory = BMIsubCategories.ObesidadMedia;
			} else if (bmi >= 40.00) {
				subCategory = BMIsubCategories.ObesidadMorbida;
			}

			return subCategory;
		}
	}
}