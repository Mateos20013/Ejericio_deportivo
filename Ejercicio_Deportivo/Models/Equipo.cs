using System.ComponentModel.DataAnnotations;

namespace Ejercicio_Deportivo.Models
{
    public class Equipo
    {
        public int Id { get; set; }
        [MaxLength(200)]
        [Required]
        public string Nombre { get; set; }
        [MaxLength(200)]
    }
}
