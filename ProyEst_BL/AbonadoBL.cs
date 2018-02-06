using ProyEst_ADO;
using ProyEst_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyEst_BL
{
    public class AbonadoBL
    {
        AbonadoADO objAbonadoADO = new AbonadoADO();

        public bool InsertarAbonado(AbonadoBE objAbonadoBE)
        {
            return objAbonadoADO.InsertarAbonado(objAbonadoBE);
        }

        public bool InsertarClienteAbonado(ClienteBE objClienteBE, AbonadoBE objAbonadoBE)
        {
            return objAbonadoADO.InsertarClienteAbonado(objClienteBE, objAbonadoBE);
        }

        public AbonadoBE ConsultarAbonado(string strcod)
        {
            return objAbonadoADO.ConsultarAbonado(strcod);
        }

        public bool ActualizarAbonado (AbonadoBE objAbonadoBE)
        {
            return objAbonadoADO.ActualizarAbonado(objAbonadoBE);
        }

        public bool EliminarAbonado(string strcod)
        {
            return objAbonadoADO.EliminarAbonado(strcod);
        }
    }
}
