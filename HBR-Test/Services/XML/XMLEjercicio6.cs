using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBR_Test.Services.XML
{
    public class XMLEjercicio6
    {
        /*6) Crear un programa que pida al usuario dos números enteros y diga "Uno de los números es positivo",
        "Los dos números son positivos" o bien "Ninguno de los números es positivo", según corresponda. */

        public static string EsPositivo(int x, int y)
        {
            if (x > 0 && y > 0)
                return "Los dos números son positivos";
            else if ((x > 0 && y < 0) || (x < 0 && y > 0))
                return "Uno de los dos números es positivo";
            else
                return "Ninguno de los números es positivo";
        }
    }
}
