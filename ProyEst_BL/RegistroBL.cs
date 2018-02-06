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
    public class RegistroBL
    {
        RegistroADO objRegistroADO = new RegistroADO();

        public bool MarcarEntrada(RegistroBE objRegistroBE)
        {
            return objRegistroADO.MarcarEntrada(objRegistroBE);
        }

        public RegistroBE ConsultarRegistro(string strcod)
        {
            return objRegistroADO.ConsultarRegistro(strcod);
        }

        public Boolean MarcarSalida(RegistroBE objRegistroBE)
        {
            return objRegistroADO.MarcarSalida(objRegistroBE);
        }

        public DataSet ListarRegistrosDetalle()
        {
            return objRegistroADO.ListarRegistrosDetalle();
        }

        public DataTable ListarRegistrosClienteFechas(string strcod, DateTime ini, DateTime fin)
        {
            return objRegistroADO.ListarRegistrosClienteFechas(strcod, ini, fin);
        }
    }
}
