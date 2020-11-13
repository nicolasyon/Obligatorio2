using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Inversor : Usuario
    {
        public DateTime FechaNacimiento { get; set; }
        public decimal MontoMaximo{get; set;}
        public string Presentacion { get; set; }

    }
}
