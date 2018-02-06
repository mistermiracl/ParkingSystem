using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyEst_BE
{
    public class EstacionamientoBE
    {
        public string id_estacionamiento { get; set; }
        public int puestos { get; set; }
        public decimal tarifa_diaria { get; set; }
        //public double  tarifa_diaria { get; set; }
    }
}
