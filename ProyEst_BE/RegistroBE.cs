using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyEst_BE
{
    public class RegistroBE
    {
        public string id_registro { get; set; }
        public DateTime h_entrada { get; set; }
        public DateTime h_salida { get; set; }
        public decimal tarifa { get; set; }
        public string descripcion_entrada { get; set; }
        public string descripcion_salida { get; set; }
        public string id_cliente { get; set; }
        public string id_empleado { get; set; }
        public string id_vehiculo { get; set; }
        public string id_puesto { get; set; }
        public int estado { get; set; }
    }
}
