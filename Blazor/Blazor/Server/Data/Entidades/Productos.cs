using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Server.Models
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
