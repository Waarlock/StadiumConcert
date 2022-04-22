using System.ComponentModel.DataAnnotations;

namespace StadiumConcert.Data.Entities
{
    public class Entrance
    {
        
        public int Id { get; set; }
        [Display(Name = "Descripcion")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public String Description { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
