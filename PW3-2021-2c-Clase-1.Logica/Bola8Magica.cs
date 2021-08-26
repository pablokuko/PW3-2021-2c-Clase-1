using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW3_2021_2c_Clase_1.Logica
{
    public static class Bola8Magica
    {
        private static string[] _respuestasPosibles;

        static Bola8Magica()
        {
            _respuestasPosibles = new string[]
            {
                "En mi opinión, sí",
                "Es cierto",
                "Es decididamente así",
                "Probablemente",
                "Buen pronóstico",
                "Todo apunta a que sí",
                "Sin duda",
                "Sí",
                "Sí - definitivamente",
                "Debes confiar en ello",
                "Respuesta vaga, vuelve a intentarlo",
                "Pregunta en otro momento",
                "Será mejor que no te lo diga ahora",
                "No puedo predecirlo ahora",
                "Concéntrate y vuelve a preguntar",
                "No cuentes con ello",
                "Mi respuesta es no",
                "Mis fuentes me dicen que no",
                "Las perspectivas no son buenas",
                "Muy dudoso",
            };
        }

        public static string Preguntar(string mensaje)
        {
            Random rand = new Random();
            //return _respuestasPosibles.OrderBy(o => Guid.NewGuid()).FirstOrDefault();
            return _respuestasPosibles[rand.Next(0, _respuestasPosibles.Count() - 1)];
        }
    }
}
