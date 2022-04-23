using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StadiumConcert.Data.Entities
{
    public class Ticket 
    {
        public int Id { get; set; }

        [Display(Name = "¿Fue Usadala boleta?")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public bool WasUsed { get; set; }

        [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener maximo {1} caractéres.")]
        public String? Document { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caractéres.")]
   
        public String? Name { get; set; }

        [JsonIgnore]
        public Entrance? Entrance { get; set; }

        public DateTime? Date { get; set; }



    }
}
