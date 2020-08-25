using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBR_Test.Services.XML
{
    public class XMLEjercicio11
    {
        /*11) Crea un programa que escriba en pantalla los números pares del 26 al 10 (descendiendo), usando "do..while".*/

        public static List<int> Descendiendo()
        {
            List<int> lista = new List<int>();
            int c = 26;

            do
                lista.Add(c--);
            while (c >= 10);

            return lista;
        }
    }
}
