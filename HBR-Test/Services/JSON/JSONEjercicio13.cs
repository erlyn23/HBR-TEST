using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBR_Test.Services.JSON
{
    public class JSONEjercicio13
    {
        /*13) Crear un programa que muestre los primeros ocho números pares (pista: en cada pasada habrá que aumentar de 2 en 2, 
        o bien mostrar el doble del valor que hace de contador).*/

        public static List<int> OchoPares()
        {
            List<int> lista = new List<int>();

            for(int i = 0; i<16; i += 2)
                lista.Add(i);
            
            return lista;
        }
    }
}
