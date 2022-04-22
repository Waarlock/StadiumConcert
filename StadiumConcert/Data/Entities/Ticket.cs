using System.ComponentModel.DataAnnotations;

namespace StadiumConcert.Data.Entities
{
    public class Ticket 
    {
        public int Id { get; set; }

        public Boolean WasUsed { get; set; }

        [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener maximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public String Document { get; set; }
        [Display(Name = "Documento")]
        [MaxLength(50)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public String Name { get; set; }

        public Entrance Entrance { get; set; }

        public DateTime Date { get; set; }


    }
}
