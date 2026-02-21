using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamenUnidad1.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ExamenUnidad1.Controllers
{
    [Route("api/conversiones")]
    [ApiController]
    public class TemperaturaController
    {
        private readonly List<TemperaturaEntity> _temperatura;
        public TemperaturaController()
        {
            _temperatura = new List<TemperaturaEntity>
            {
              new TemperaturaEntity
              {
                  valorOriginal = "",
                  escalaOriginal = "",
                  valorConvertido = "",
                  escalaDestino = ""
              }  
            };
        }

        [HttpPost]
        private IActionResult create()
        {
            
        }
    }
}