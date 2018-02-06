using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyEst_BE
{
    public class EmpleadoBE
    {
        public string id_empleado { get; set; }
        public string nombre { get; set; }
        public string apellido_p { get; set; }
        public string apellido_m { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public int turno { get; set; }
        public int nivel { get; set; }
        public string dni { get; set; }
        public bool estado { get; set; }
    }
}
