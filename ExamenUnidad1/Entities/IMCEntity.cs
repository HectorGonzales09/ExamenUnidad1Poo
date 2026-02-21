using System.ComponentModel.DataAnnotations;

namespace ExamenUnidad1.Entities
{
    public class IMCEntity
    {
        [Required]
        public string Peso { get; set; }
        [Required]
        public string Altura { get; set; }
        public string IMC { get; set; }
        public string Clasificacion { get; set; }
    }
}