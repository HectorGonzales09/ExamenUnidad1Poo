using ExamenUnidad1.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ExamenUnidad1.Controllers
{
    [Route("api/salud")]
    [ApiController]
    public class IMCController : ControllerBase
    {
        private readonly List<IMCEntity> _imc;
        public IMCController()
        {
            _imc = new List<IMCEntity>
            {
              new IMCEntity
              {
                  Peso = "",
                  Altura = "",
                  IMC = "",
                  Clasificacion = ""
              }  
            };
        }

        [HttpPost]
        public IActionResult create()
        {
            double peso = 0;
            double altura = 0;

            while (true)
            {
                Console.WriteLine("Ingrese su peso en kg");
                if (double.TryParse(Console.ReadLine(), out peso) && peso > 0)
                    break;
                Console.WriteLine("Peso invalido por favor ingrese un valor valido");
            }

            while (true)
            {
                Console.WriteLine("Ingrese su altura en m");
                if (double.TryParse(Console.ReadLine(), out altura) && altura > 0)
                    break;
                Console.WriteLine("Altura invalida por favor ingrese un valor valido");
            }

            double imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                return Ok("Bajo peso");
            }
            else if (imc < 25)
            {
                return Ok("Peso normal");
            }
            else if (imc < 30)
            {
                return Ok("Sobrepeso");
            }
            else
            {
                return Ok("Obesidad");
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}