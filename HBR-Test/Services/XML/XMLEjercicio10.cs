using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBR_Test.Services.XML
{
    public class XMLEjercicio10
    {
        /*10) Crea un programa que escriba en pantalla los números del 1 al 10, usando "do..while".*/

        public static List<int> unoAldiez()
        {
            List<int> lista = new List<int>();
            int c = 1;

            do
                lista.Add(c++);
            while (c <= 10);
            
            return lista;
        }
    }
}
