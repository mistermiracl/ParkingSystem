using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyEst_ADO
{
    public class PuestoADO
    {
        ConexionADO conexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        bool exito;

        public DataTable ListarPuestos()
        {
            DataSet dts = new DataSet();
            try
            {
                cnx.ConnectionString = conexion.getConexion();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarPuestos";
                SqlDataAdapter sqla = new SqlDataAdapter(cmd);
                sqla.Fill(dts, "Puestos");
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }
            return dts.Tables["Puestos"];
        }

        public DataTable ListarPuestosDisponibles()
        {
            DataSet dts = new DataSet();
            try
            {
                cnx.ConnectionString = conexion.getConexion();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM TB_PUESTO WHERE ESTADO_DISPONIBILIDAD = 1";//CUSTOM QUERY TO RETURN EVERY AVAILABLE SPOT

                SqlDataAdapter sqla = new SqlDataAdapter(cmd);
                sqla.Fill(dts, "Puestos");
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }
            return dts.Tables["Puestos"];
        }

        public bool ActualizarPuesto(string strcod, bool estado)
        {
            try
            {
                cnx.ConnectionString = conexion.getConexion();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarPuesto";

                cmd.Parameters.Add(new SqlParameter("@pcod", strcod));
                cmd.Parameters.Add(new SqlParameter("@pest", estado));

                cnx.Open();
                cmd.ExecuteNonQuery();

                exito = true;
            }
            catch (SqlException x)
            {
                exito = false;
            }
            catch (Exception x)
            {
                exito = false;
            }
            finally
            {
                cmd.Parameters.Clear();
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
            }
            return exito;
        }

        public bool ConsultarPuestoDisponible(string strcod)
        {
            bool estado = false;
            try
            {
                cnx.ConnectionString = conexion.getConexion();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ESTADO_DISPONIBILIDAD FROM TB_PUESTO WHERE ID_PUESTO = '" + strcod + "'";

                cnx.Open();
                estado = Convert.ToBoolean(cmd.ExecuteScalar());//THIS CAN BE DONE SINCE ONLY ONE VALUE IS BEING REUTRNED (SCALAR, READ DEF OF EXECUTE SCALAR)
            }
            catch (Exception x)
            {
                exito = false;
            }
            finally
            {
                cmd.Parameters.Clear();
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
            }
            return estado;
        }
    }
}
