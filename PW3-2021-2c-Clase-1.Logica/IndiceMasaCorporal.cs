using System;

namespace PW3_2021_2c_Clase_1.Logica
{
    public class IndiceMasaCorporal
    {

        public static double calcularIMC(string pesoString, string alturaString)
        {

            if (!double.TryParse(pesoString, out double peso))
            {

                throw new ArgumentException("El valor ingresado no es un nro valido.");

            }

            if (!double.TryParse(alturaString, out double altura))
            {

                throw new ArgumentException("El valor ingresado no es un nro valido.");

            }

            double imc = Math.Round(peso / Math.Pow(altura, 2), 2);

            return imc;

        }

        public static string calcularMasaCorporal(double masa)
        {


            if (masa < 18.50)
            {

                return "Usted tiene bajo peso.";

            }
            else
            {

                if (masa >= 18.50 && masa < 25)
                {

                    return "Usted pesa normal.";
                }
                else
                {
                    if (masa >= 25 && masa < 30)
                    {
                        return "Usted tiene sobrepeso.";
                    }
                    else
                    {
                        if (masa >= 30);
                        return "Usted tiene obesidad";

                    }

                }

            }

        }

    }
}
