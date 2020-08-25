using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBR_Test.Services.XML
{
    public class XMLEjercicio4
    {
        /*4) Crear un programa que pida al usuario dos números reales. Si el segundo no es cero, mostrará el resultado de dividir 
        entre el primero y el segundo. Por el contrario, si el segundo número es cero, escribirá “Error: No se puede dividir entre
        cero”. */

        public static string Division(float x, float y)
        {
            if(y != 0)
            {
                var result = x / y;
                return result.ToString();
            }
            else if(y == 0)
                return "Error: No se puede dividir entre cero.";
            return "";
        }
    }
}
