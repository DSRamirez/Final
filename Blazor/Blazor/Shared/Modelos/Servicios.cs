using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Shared.Modelos
{
    public class Servicios
    {
        [Key]
        public int Id_Servicio { get; set; }
        [Required]
        public string Servicio { get; set; }
        [Required]
        public int Precio { get; set; }
        [Required]
        public string Productos { get; set; }
        [Required]
        public DateTime Tiempo { get; set; }
    }
}
