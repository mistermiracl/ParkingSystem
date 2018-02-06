using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyEst_ADO
{
    public class ConexionADO
    {
        public string getConexion()
        {
            string strcnx = ConfigurationManager.ConnectionStrings["parking"].ConnectionString;
            if (object.ReferenceEquals(strcnx, string.Empty))
            {
                return string.Empty;
            }
            else
                return strcnx;
        }
    }
}
