using ProyEst_ADO;
using ProyEst_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyEst_BL
{
    public class EstacionamientoBL
    {
        EstacionamientoADO objEstacionamientoADO = new EstacionamientoADO();

        public EstacionamientoBE ListarEstacionamiento()
        {
            return objEstacionamientoADO.ListarEstacionamiento();
        }

        public Boolean ActualizarEstacionamiento(decimal tarifa, DataTable puestos)
        {
            return objEstacionamientoADO.ActualizarEstacionamiento(tarifa, puestos);
        }
    }
}
