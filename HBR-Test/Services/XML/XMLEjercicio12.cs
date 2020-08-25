using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBR_Test.Services.XML
{
    public class XMLEjercicio12
    {
        /*12) Crear un programa que muestre los números del 15 al 5, descendiendo (pista: en cada pasada habrá que descontar 1, 
        por ejemplo, haciendo i=i-1, que se puede abreviar i--). */

        public static List<int> Descendiendo()
        {
            List<int> lista = new List<int>();
            int c = 15;
            while (c >= 5)
                lista.Add(c--);

            return lista;
        }
    }
}
