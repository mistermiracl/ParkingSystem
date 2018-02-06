using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyEst_ADO;
using ProyEst_BE;
using System.Data;

namespace ProyEst_BL
{
    public class ClienteBL
    {
        ClienteADO objClienteADO = new ClienteADO();

        public DataTable ListarClientes()
        {
            return objClienteADO.ListarClientes();

        }

        public DataTable ListarClientesAbonado()
        {
            return objClienteADO.ListarClientesAbonado();
        }

        public Boolean InsertarCliente(ClienteBE objClienteBE)
        {
            return objClienteADO.InsertarCliente(objClienteBE);
        }
        public ClienteBE ConsultarCliente(string strcod)
        {
            return objClienteADO.ConsultarCliente(strcod);
        }

        public bool ActualizarCliente(ClienteBE objClienteBE)
        {
            return objClienteADO.ActualizarCliente(objClienteBE);
        }

        public bool EliminarCliente(string strcod)
        {
            return objClienteADO.EliminarCliente(strcod);
        }

        public DataTable ListarClientesNombreDNI()
        {
            return objClienteADO.ListarClientesNombreDNI();
        }

        public DataView FiltrarClientesDNI(string filtro)
        {
            return objClienteADO.FiltrarClientesDNI(filtro);
        }
    }
}
