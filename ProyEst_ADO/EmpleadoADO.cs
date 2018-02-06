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
    public class EmpleadoADO
    {
        ConexionADO conexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        bool exito;

        public DataTable ListarEmpleados()
        {
            DataSet dts = new DataSet();
            SqlDataAdapter sqla;
            try
            {
                cnx.ConnectionString = conexion.getConexion();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarEmpleados";

                sqla = new SqlDataAdapter(cmd);
                sqla.Fill(dts, "Empleados");
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }
            return dts.Tables["Empleados"];
        }

        public bool InsertarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            try
            {
                cnx.ConnectionString = conexion.getConexion();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarEmpleado";

                cmd.Parameters.Add(new SqlParameter("@enom", objEmpleadoBE.nombre));
                cmd.Parameters.Add(new SqlParameter("@eapep", objEmpleadoBE.apellido_p));
                cmd.Parameters.Add(new SqlParameter("@eapem", objEmpleadoBE.apellido_m));
                cmd.Parameters.Add(new SqlParameter("@etel", objEmpleadoBE.telefono));
                cmd.Parameters.Add(new SqlParameter("@email", objEmpleadoBE.email));
                cmd.Parameters.Add(new SqlParameter("@edir", objEmpleadoBE.direccion));
                cmd.Parameters.Add(new SqlParameter("@etur", objEmpleadoBE.turno));
                cmd.Parameters.Add(new SqlParameter("@eniv", objEmpleadoBE.nivel));
                cmd.Parameters.Add(new SqlParameter("@edni", objEmpleadoBE.dni));
                //cmd.Parameters.Add(new SqlParameter("@eest", objEmpleadoBE.estado));

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
                exito = false; // ALWAYS TEST PROCEDURES BEFORE IMPLEMENTING THEM IN CODE, INVALID COLUMN MEANS A PROCEDURE PROBLEM NOT C#
            }
            finally
            {
                cmd.Parameters.Clear();
                if (cnx.State == ConnectionState.Open)
                    cnx.Close(); 
            }
            return exito;
        }

        public EmpleadoBE ConsultarEmpleado(string strcod)
        {
            EmpleadoBE objEmpleadoBE = new EmpleadoBE();
            try
            {
                cnx.ConnectionString = conexion.getConexion();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarEmpleado";

                cmd.Parameters.Add(new SqlParameter("@ecod", SqlDbType.Char, 6));
                cmd.Parameters["@ecod"].Value = strcod;

                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows)
                {
                    dtr.Read();
                    objEmpleadoBE.id_empleado = dtr.GetString(dtr.GetOrdinal("ID_EMPLEADO"));
                    objEmpleadoBE.nombre = dtr.GetString(dtr.GetOrdinal("NOMBRE"));
                    objEmpleadoBE.apellido_p = dtr.GetString(dtr.GetOrdinal("APELLIDO PATERNO"));
                    objEmpleadoBE.apellido_m = dtr.GetString(dtr.GetOrdinal("APELLIDO MATERNO"));
                    objEmpleadoBE.telefono = dtr.GetString(dtr.GetOrdinal("TELEFONO"));
                    objEmpleadoBE.email = dtr.GetString(dtr.GetOrdinal("EMAIL"));
                    objEmpleadoBE.direccion = dtr.GetString(dtr.GetOrdinal("DIRECCION"));
                    objEmpleadoBE.turno = (int)dtr.GetByte(dtr.GetOrdinal("TURNO")); //TINYINT BYTE
                    objEmpleadoBE.nivel = (int)dtr.GetInt16(dtr.GetOrdinal("NIVEL")); //SMALLINT SINGLE
                    objEmpleadoBE.dni = dtr.GetString(dtr.GetOrdinal("DNI"));
                    objEmpleadoBE.estado = dtr.GetBoolean(dtr.GetOrdinal("ESTADO"));
                    dtr.Close();
                }
            }
            catch (Exception x)
            {

                throw new Exception(x.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
            }
            return objEmpleadoBE;
        }

        public bool ActualizarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            try
            {
                cnx.ConnectionString = conexion.getConexion();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarEmpleado";

                cmd.Parameters.Add(new SqlParameter("@ecod", objEmpleadoBE.id_empleado));
                cmd.Parameters.Add(new SqlParameter("@enom", objEmpleadoBE.nombre));
                cmd.Parameters.Add(new SqlParameter("@eapep", objEmpleadoBE.apellido_p));
                cmd.Parameters.Add(new SqlParameter("@eapem", objEmpleadoBE.apellido_m));
                cmd.Parameters.Add(new SqlParameter("@etel", objEmpleadoBE.telefono));
                cmd.Parameters.Add(new SqlParameter("@email", objEmpleadoBE.email));
                cmd.Parameters.Add(new SqlParameter("@edir", objEmpleadoBE.direccion));
                cmd.Parameters.Add(new SqlParameter("@etur", objEmpleadoBE.turno));
                cmd.Parameters.Add(new SqlParameter("@eniv", objEmpleadoBE.nivel));
                cmd.Parameters.Add(new SqlParameter("@edni", objEmpleadoBE.dni));
                cmd.Parameters.Add(new SqlParameter("@eest", objEmpleadoBE.estado));

                cnx.Open();
                cmd.ExecuteNonQuery();
                exito = true;
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

        public bool EliminarEmpleado(string strcod)
        {
            try
            {
                cnx.ConnectionString = conexion.getConexion();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarEmpleado";

                cmd.Parameters.Add(new SqlParameter("@ecod", strcod));

                cnx.Open();
                cmd.ExecuteNonQuery();
                exito = true;
            }
            catch (Exception x)
            {

                throw new Exception(x.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
            }
            return exito;
        }
    }
}
