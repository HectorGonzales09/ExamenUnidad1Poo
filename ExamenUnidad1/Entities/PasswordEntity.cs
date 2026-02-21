using System.ComponentModel.DataAnnotations;

namespace ExamenUnidad1.Entities
{
    public class PasswordEntity
    {
        [Required]
        [StringLength(8)]
        public string password { get; set; }
    }
}