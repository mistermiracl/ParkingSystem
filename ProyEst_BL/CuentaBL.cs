using ProyEst_ADO;
using ProyEst_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyEst_BL
{
    public class CuentaBL
    {
        CuentaADO objCuentaADO = new CuentaADO();

        public CuentaBE consultarCuenta(string usuario, string contraseña)
        {
            return objCuentaADO.consultarCuenta(usuario, contraseña);
        }
    }
}
