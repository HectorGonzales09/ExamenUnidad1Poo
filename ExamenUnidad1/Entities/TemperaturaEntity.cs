using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenUnidad1.Entities
{
    public class TemperaturaEntity
    {
        [Required]
        public string valorOriginal { get; set; }
        public string escalaOriginal { get; set; }
        public string valorConvertido { get; set; }
        public string escalaDestino { get; set; }
    }
}