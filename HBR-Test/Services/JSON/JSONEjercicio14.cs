using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBR_Test.Services.JSON
{
    public class JSONEjercicio14
    {
        /*14) Crear un programa que escriba en pantalla los números del 1 al 50 que sean múltiplos de 3 
        (pista: habrá que recorrer todos esos números y ver si el resto de la división entre 3 resulta 0).*/

        public static List<int> Multiplos()
        {
            List<int> lista = new List<int>();
            for(int i = 1; i<=50; i++)
            {
                if (i % 3 == 0)
                {
                    lista.Add(i);
                }
            }
            return lista;
        }
    }
}
