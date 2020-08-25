using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HBR_Test.Services.JSON;

namespace HBR_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JSONController : ControllerBase
    {
        [HttpGet("GET.{format}"), FormatFilter]
        [Route("Ejercicio13")]

        public List<int> GetPares()
        {
            var pares = JSONEjercicio13.OchoPares();
            return pares;
        }

        [HttpGet("GET.{format}"), FormatFilter]
        [Route("Ejercicio14")]

        public List<int> GetMultiplos()
        {
            var multiplos = JSONEjercicio14.Multiplos();
            return multiplos;
        }

        [HttpPost("GET.{format}"), FormatFilter]
        [Route("Ejercicio15")]

        public IActionResult GetMenor(int[] v)
        {
            var menor = JSONEjercicio15.Vector(v);
            return Ok(menor);
        }

        [HttpGet("GET.{format}"), FormatFilter]
        [Route("Ejercicio16")]

        public List<float> GetSueldos(float[] sueldos)
        {
            var s = JSONEjercicio16.Sueldos(sueldos);
            if (s == null)
                return null;

            return s.ToList();
        }

        [HttpGet("GET.{format}"), FormatFilter]
        [Route("Ejercicio17")]

        public List<string> GetPaises(string[] paises)
        {
            var p = JSONEjercicio17.Paises(paises);
            if (p == null)
                return null;

            return p.ToList();
        }
    }
}
