using System;

namespace PW3_2021_2c_Clase_1.Logica
{
    public class IMC
    {
        //IMC=peso(kg)/(altura(cm)/100)**2
        public enum EstadoNutricional
        {
            DESCONOCIDO,
            DELGADEZ_SEVERA,
            DELGADEZ_MODERADA,
            DELGADEZ_LEVE,
            NORMAL,
            PREOBESIDAD,
            OBESIDAD_LEVE,
            OBESIDAD_MEDIA,
            OBESIDAD_MORBIDA
        }


        public static EstadoNutricional CalcularIndice(double altura, double peso)
        {
            EstadoNutricional estado = EstadoNutricional.DESCONOCIDO;
            double imc = peso / Math.Pow((altura / 100), 2);
            if (imc < 16)
            {
                estado = EstadoNutricional.DELGADEZ_SEVERA;
            }
            else if (imc >= 16 && imc <= 16.99)
            {
                estado = EstadoNutricional.DELGADEZ_MODERADA;
            }
            else if (imc >= 17 && imc <= 18.49)
            {
                estado = EstadoNutricional.DELGADEZ_LEVE;
            }
            else if (imc >= 18.5 && imc <= 24.99)
            {
                estado = EstadoNutricional.NORMAL;
            }
            else if (imc >= 25 && imc <= 29.99)
            {
                estado = EstadoNutricional.PREOBESIDAD;
            }
            else if (imc >= 30 && imc <= 34.99)
            {
                estado = EstadoNutricional.OBESIDAD_LEVE;
            }
            else if (imc >= 35 && imc <= 39.99)
            {
                estado = EstadoNutricional.OBESIDAD_MEDIA;
            }
            else if (imc >= 40)
            {
                estado = EstadoNutricional.OBESIDAD_MORBIDA;
            }
            return estado;

        }

    }

}