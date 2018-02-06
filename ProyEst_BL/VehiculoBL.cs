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
    public class VehiculoBL
    {
        VehiculoADO objVehiculoADO = new VehiculoADO();

        public DataTable ListarVehiculos()
        {
            return objVehiculoADO.ListarVehiculos();
        }

        public DataTable ListarVehiculosRegistro()
        {
            return objVehiculoADO.ListarVehiculosRegistro();
        }

        public DataTable ListarMarcas()
        {
            return objVehiculoADO.ListarMarcas();
        }

        public DataTable ConsultarModelos(string strcod)
        {
            return objVehiculoADO.ConsultarModelos(strcod);
        }

        public String InsertarVehiculo(VehiculoBE objVehiculoBE)
        {
            return objVehiculoADO.InsertarVehiculo(objVehiculoBE);
        }

        public VehiculoBE ConsultarVehiculo(string strcod)
        {
            return objVehiculoADO.ConsultarVehiculo(strcod);
        }

        public VehiculoBE ConsultarVehiculoPorPlaca(string placa)
        {
            return objVehiculoADO.ConsultarVehiculoPorPlaca(placa);
        }


        public DataView OrdenarVehiculosYFiltrarPorMarca(int criterio)
        {
            return objVehiculoADO.OrdenarVehiculosYFiltrarPorMarca(criterio);
        }

        public DataView OrdenarVehiculosYFiltrarPorMarca(int criterio, string marca)
        {
            return objVehiculoADO.OrdenarVehiculosYFiltrarPorMarca(criterio, marca);
        }
    }
}
