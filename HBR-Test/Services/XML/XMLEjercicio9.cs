using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBR_Test.Services.XML
{
    public class XMLEjercicio9
    {
        /*9) Crea un programa que escriba en pantalla los números pares del 26 al 10 (descendiendo), usando "while".*/

        public static List<int> Descendiendo()
        {
            List<int> lista = new List<int>();
            int c = 26;
            while (c >= 10)
                lista.Add(c--);

            return lista;
        }
    }
}
