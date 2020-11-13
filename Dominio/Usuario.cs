using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        //public int? IdUsuario { get; set;} // LO VAMOS A USAR? 
        [Key]
        public string Cedula { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Celular { get; set; }
    }
}
