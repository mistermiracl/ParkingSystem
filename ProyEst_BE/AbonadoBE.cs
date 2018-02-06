using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyEst_BE
{
    public class AbonadoBE
    {
        public string id_abonado { get; set; }
        public Boolean estado_pago { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string dni { get; set; }
        public string id_puesto { get; set; }
        public string id_cliente { get; set; }
    }
}
