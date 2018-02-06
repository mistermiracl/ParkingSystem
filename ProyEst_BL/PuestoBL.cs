using ProyEst_ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyEst_BL
{
    public class PuestoBL
    {
        PuestoADO objPuestoADO = new PuestoADO();

        public DataTable ListarPuestos()
        {
            return objPuestoADO.ListarPuestos();
        }

        public DataTable ListarPuestosDisponibles()
        {
            return objPuestoADO.ListarPuestosDisponibles();
        }

        public bool ActualizarPuesto(string strcod, bool estado)
        {
            return objPuestoADO.ActualizarPuesto(strcod, estado);
        }

        public bool ConsultarPuestoDisponible(string strcod)
        {
            return objPuestoADO.ConsultarPuestoDisponible(strcod);
        }
    }
}
