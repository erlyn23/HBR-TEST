using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBR_Test.Services.XML
{
    public class XMLEjercicio2
    {

        /*2) Crear un programa que pida al usuario dos números enteros y diga si el primero es múltiplo del segundo 
        (pista: igual que antes, habrá que ver si el resto de la división es cero: a % b == 0).*/

        public static bool Multiplo(int x, int y)
        {
            if (x == 0 || y == 0)
             return false;
            else if (x % y == 0)
             return true;
            
            return false;
        }

    }
}
