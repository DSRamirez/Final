using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Shared.Modelos
{
    public class Turnos
    {
        [Key]
        public int Id_Turno { get; set; }
        [Required]
        public int Nº_Turno { get; set; }
        [Required (ErrorMessage = "El campo {0} es requerido")]
        public string Nick { get; set; }
        [Required]
        public string Peluquero { get; set; }
        [Required]
        public string Servicio { get; set; }
        [Required]
        public DateTime Dia_Y_Hora { get; set; }
    }
}
