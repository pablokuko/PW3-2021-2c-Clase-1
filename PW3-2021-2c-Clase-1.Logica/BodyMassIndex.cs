using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW3_2021_2c_Clase_1.Logica {
    public static class BodyMassIndex {
		public static void askFor(string heightOrWeightString, out float heightOrWeight) {
			string heightOrWeightInput;
			string example = heightOrWeightString == "altura" ? "1,85" : "80,7";

			do {
				Console.WriteLine($"Ingrese su { heightOrWeightString } en m (puede usar coma). Ejemplo: { example }");
				heightOrWeightInput = Console.ReadLine();

				if (!float.TryParse(heightOrWeightInput, out heightOrWeight)) {
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
				category = "Bajo peso";
			} else if (bmi >= 18.50 && bmi <= 24.99) {
				category = "Peso normal";
			} else {
				category = "Sobrepeso";
			}

			return category;
		}

		public static string getSubcategoryConsidering(float bmi) {
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