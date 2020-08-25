using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBR_Test.Services.JSON
{
    public class JSONEjercicio16
    {
        /*16) Se debe crear un vector donde almacenar 5 sueldos. Ordenar el vector sueldos de menor a mayor.*/

        public static float[] Sueldos(float[] sueldos)
        {
            
            if (sueldos.Count() == 5)
            {
                Array.Sort(sueldos);
                return sueldos;
            }
            return null;
        }
    }
}
