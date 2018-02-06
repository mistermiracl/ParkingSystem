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
    public class EstacionamientoADO
    {
        ConexionADO conexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public EstacionamientoBE ListarEstacionamiento()
        {
            EstacionamientoBE objEstacionamientoBE = new EstacionamientoBE();
            try
            {
                cnx.ConnectionString = conexion.getConexion();
                cmd.Connection = cnx;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarEstacionamiento";

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows)
                {
                    dtr.Read();//DONT EVER FORGET TO READ THE ROW
                    objEstacionamientoBE.id_estacionamiento = dtr.GetString(dtr.GetOrdinal("ID_ESTACIONAMIENTO"));
                    objEstacionamientoBE.puestos = dtr.GetInt32(dtr.GetOrdinal("PUESTOS"));
                    objEstacionamientoBE.tarifa_diaria = dtr.GetDecimal(dtr.GetOrdinal("TARIFA_DIARIA"));
                    dtr.Close();
                }
            }
            catch (Exception x)
            {
                throw;
            }
            finally
            {
                if (cnx.State == System.Data.ConnectionState.Open)
                    cnx.Close();
                cmd.Parameters.Clear();
            }
            return objEstacionamientoBE;
        }

        public bool ActualizarEstacionamiento(/*EstacionamientoBE objEstacionamientoBE*/decimal tarifa_diaria, DataTable puestos)
        {
            try
            {
                cnx.ConnectionString = conexion.getConexion();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarEstacionamiento";

                cmd.Parameters.Add(new SqlParameter("@etarf", tarifa_diaria));
                cmd.Parameters.Add(new SqlParameter("@tpuestos", puestos));

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception x)
            {
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
                cmd.Parameters.Clear();
            }
        }
    }
}
