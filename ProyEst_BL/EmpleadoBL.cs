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
    public class EmpleadoBL
    {
        EmpleadoADO objEmpleadoADO = new EmpleadoADO();

        public DataTable ListarEmpleados()
        {
            return objEmpleadoADO.ListarEmpleados();
        }

        public bool InsertarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            return objEmpleadoADO.InsertarEmpleado(objEmpleadoBE);
        }
        
        public EmpleadoBE ConsultarEmpleado(string strcod)
        {
            return objEmpleadoADO.ConsultarEmpleado(strcod);
        }

        public bool ActualizarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            return objEmpleadoADO.ActualizarEmpleado(objEmpleadoBE);
        }

        public bool EliminarEmpleado(string strcod)
        {
            return objEmpleadoADO.EliminarEmpleado(strcod);
        }
    }
}
