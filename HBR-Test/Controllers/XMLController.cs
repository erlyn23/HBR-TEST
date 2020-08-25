using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HBR_Test.Services.XML;
using HBR_Test.Models;

namespace HBR_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class XMLController : ControllerBase
    {
        [HttpGet("GET.{format}"), FormatFilter]
        [Route("Ejercicio1")]
        [Produces("application/xml")]
        public IActionResult Ejercicio1(float x, float y)
        {
            var operacion = XMLEJercicio1.DivisionYResto(x,y);
            return Ok(operacion);
        }

        [HttpGet("GET.{format}"), FormatFilter]
        [Route("Ejercicio2")]
        [Produces("application/xml")]
        public IActionResult Ejercicio2(int x, int y)
        {
            var operacion = XMLEjercicio2.Multiplo(x, y);
            if (operacion)
                return Ok(x+" es múltiplo de "+y);
            else
                return BadRequest("Error al calcular múltiplo");
        }

        [HttpGet("GET.{format}"), FormatFilter]
        [Route("Ejercicio4")]
        [Produces("application/xml")]

        public IActionResult Ejercicio4(float x, float y)
        {
            var operacion = XMLEjercicio4.Division(x, y);
            return Ok(operacion);
        }

        [HttpPost("post.{format}"), FormatFilter]
        [Route("Ejercicio5")]
        [Produces("application/xml")]
        public IActionResult Ejercicio5([FromBody] string letra)
        {
            var operacion = XMLEjercicio5.EsVocal(letra);
            if (operacion)
                return Ok("Es vocal");
            else
                return BadRequest("No es una vocal");
        }

        [HttpGet("GET.{format}"), FormatFilter]
        [Route("Ejercicio6")]
        [Produces("application/xml")]

        public IActionResult Ejercicio6(int x, int y)
        {
            var operacion = XMLEjercicio6.EsPositivo(x, y);
            return Ok(operacion);
        }

        [HttpPost("POST.{format}"), FormatFilter]
        [Route("Ejercicio7")]
        [Produces("application/xml")]

        public IActionResult Ejercicio7([FromBody] int x)
        {
            var operacion = XMLEjercicio7.ValorAbsoluto(x);
            return Ok(operacion);
        }

        [HttpGet("GET.{format}"), FormatFilter]
        [Route("Ejercicio8")]
        [Produces("application/xml")]

        public List<int> Ejercicio8()
        {
            var operacion = XMLEjercicio8.unoAldiez();
            return operacion;
        }

        [HttpGet("GET.{format}"), FormatFilter]
        [Route("Ejercicio9")]
        [Produces("application/xml")]

        public List<int> Ejercicio9()
        {
            var operacion = XMLEjercicio9.Descendiendo();
            return operacion;
        }

        [HttpGet("GET.{format}"), FormatFilter]
        [Route("Ejercicio10")]
        [Produces("application/xml")]

        public List<int> Ejercicio10()
        {
            var operacion = XMLEjercicio10.unoAldiez();
            return operacion;
        }

        [HttpGet("GET.{format}"), FormatFilter]
        [Route("Ejercicio11")]
        [Produces("application/xml")]

        public List<int> Ejercicio11()
        {
            var operacion = XMLEjercicio11.Descendiendo();
            return operacion;
        }

        [HttpGet("GET.{format}"), FormatFilter]
        [Route("Ejercicio12")]
        [Produces("application/xml")]

        public List<int> Ejercicio12()
        {
            var operacion = XMLEjercicio12.Descendiendo();
            return operacion;
        }

    }
}
