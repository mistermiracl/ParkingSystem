using ProyEst_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyEst_ADO
{
    public class CuentaADO
    {
        ConexionADO conexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public CuentaBE consultarCuenta(string usuario, string contraseña)
        {
            CuentaBE objCuentaBE = new CuentaBE();
            cnx.ConnectionString = conexion.getConexion();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarCuenta";
            try
            {
                cmd.Parameters.Add(new SqlParameter("@cusu", SqlDbType.VarChar, 50));
                cmd.Parameters.Add(new SqlParameter("@ccon", SqlDbType.VarChar, 50));
                cmd.Parameters["@cusu"].Value = usuario;
                cmd.Parameters["@ccon"].Value = contraseña;
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objCuentaBE.id_cuenta = dtr.GetString(dtr.GetOrdinal("ID_CUENTA")); //IT WILL THROWN AN EXCEPTION WITH THE COLUMN NAME AND NO MESSAGE SINCE THIS COLUMN DOES NOT EXIST IN THE CURRENT QUERY
                    objCuentaBE.usuario = dtr.GetValue(dtr.GetOrdinal("USUARIO")).ToString();//UPDATE: I MADE IT SO THAT IT EXISTS SO NO MORE EXCPETIONS (WE NEED THE ID)
                    objCuentaBE.contraseña = dtr.GetValue(dtr.GetOrdinal("CONTRASEÑA")).ToString();
                    objCuentaBE.id_empleado = dtr.GetString(dtr.GetOrdinal("ID_EMPLEADO")); //SAME update : NOT ANYMORE

                    dtr.Close();
                }
                else
                    throw new Exception("No se encontro registro alguno");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception x)
            {
                throw;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
                cmd.Parameters.Clear();
            }
            return objCuentaBE;
        }
    }
}
