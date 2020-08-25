using System;
using System.Collections.Generic;
using System.Linq;
using HBR_Test.Models;
using System.Threading.Tasks;

namespace HBR_Test.Services.XML
{
    public class XMLEJercicio1
    {
        /*1) El usuario tecleará dos números (x e y), y el programa deberá calcular cual es el resultado de su división 
        y el resto de esa división.*/

        private static Ejercicio1 ejercicio1 = null;
        
        private XMLEJercicio1()
        {

        }

        public static Ejercicio1 DivisionYResto(float x, float y)
        {
            if(ejercicio1 == null)
            {
                ejercicio1 = new Ejercicio1();
                ejercicio1.Division = x / y;
                ejercicio1.Resto = x % y;
                return ejercicio1;
            }
            ejercicio1.Division = x / y;
            ejercicio1.Resto = x % y;
            return ejercicio1;
        }
    }
}
