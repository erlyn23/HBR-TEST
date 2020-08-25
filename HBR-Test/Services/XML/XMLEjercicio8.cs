using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBR_Test.Services.XML
{
    public class XMLEjercicio8
    {
        /*8) Crea un programa que escriba en pantalla los números del 1 al 10, usando "while".*/

        public static List<int> unoAldiez()
        {
            List<int> lista = new List<int>();
            int c = 1;
            while (c <= 10)
                lista.Add(c++);

            return lista;
        }
    }
}
