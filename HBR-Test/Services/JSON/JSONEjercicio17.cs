using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBR_Test.Services.JSON
{
    public class JSONEjercicio17
    {
        /*17) Definir un vector donde almacenar los nombres de 5 países. Confeccionar el algoritmo de ordenamiento alfabético.*/

        public static string[] Paises(string[] countries)
        {
            if(countries.Count() == 5)
            {
                Array.Sort(countries);
                return countries;
            }
            return null;
        }
    }
}
