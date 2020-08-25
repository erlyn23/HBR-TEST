using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBR_Test.Services.XML
{
    public class XMLEjercicio5
    {
        /*5) Crear un programa que pida una letra al usuario y diga si se trata de una vocal. */

        public static bool EsVocal(string letra)
        {
            if(letra.ToLower().Equals("a") || letra.ToLower().Equals("e") 
               || letra.ToLower().Equals("i") || letra.ToLower().Equals("o") || letra.ToLower().Equals("u")) return true;
            return false;
        }
    }
}
