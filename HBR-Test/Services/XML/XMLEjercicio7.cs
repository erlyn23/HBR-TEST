using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBR_Test.Services.XML
{
    public class XMLEjercicio7
    {
        /*7) Crear un programa que use el operador condicional para mostrar un el valor absoluto de un número de la siguiente forma: 
         si el número es positivo, se mostrará tal cual; si es negativo, se mostrará cambiado de signo. */

        public static float ValorAbsoluto(int x)
        {
            if (x > 0)
                return x;
            else
                return Math.Abs(x);
        }
    }
}
