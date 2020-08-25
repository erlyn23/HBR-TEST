using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBR_Test.Services.JSON
{
    public class JSONEjercicio15
    {
        /*15) Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro del vector.*/

        public static string Vector(int[] vector)
        {
            bool seRepite = false;
            int menor = vector[0];
            int pos = 0;
            for(int i = 0; i<vector.Count(); i++)
            {
                if (vector[i] < menor)
                {
                    menor = vector[i];
                    pos = i;
                }

            }
            for(int i = 0; i<vector.Count(); i++)
            {
                if (vector[i] == menor && i != pos)
                    seRepite = true;
            }

            if (seRepite)
                return "El número menor dentro del vector es: " + menor + " y se repite";
            else
                return "El número menor dentro del vector eso: " + menor + " y no se repite.";
        }
    }
}
