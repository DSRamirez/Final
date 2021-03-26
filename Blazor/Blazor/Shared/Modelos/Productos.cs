using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Shared.Modelos
{
    public class Productos
    {
        [Key]
        public int Id_Producto { get; set; }
        [Required]
        public string Producto { get; set; }
        [Required]
        public int Precio { get; set; }
    }
}
