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
    public class RegistroADO
    {
        ConexionADO conexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataView dtv;//FILTERING PURPOUSES
        SqlDataReader dtr;

        public bool InsertarRegistro(RegistroBE objRegistroBE)
        {
            try
            {
                cnx.ConnectionString = conexion.getConexion();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarRegistro";

                cmd.Parameters.Add(new SqlParameter("@rhent", objRegistroBE.h_entrada));
                cmd.Parameters.Add(new SqlParameter("@rhsal", objRegistroBE.h_salida));
                cmd.Parameters.Add(new SqlParameter("@rtarf", objRegistroBE.tarifa));
                cmd.Parameters.Add(new SqlParameter("@rdesen", objRegistroBE.descripcion_entrada));
                cmd.Parameters.Add(new SqlParameter("@rdesal", objRegistroBE.descripcion_salida));
                cmd.Parameters.Add(new SqlParameter("@ccod", objRegistroBE.id_cliente));
                cmd.Parameters.Add(new SqlParameter("@ecod", objRegistroBE.id_empleado));
                cmd.Parameters.Add(new SqlParameter("@vcod", objRegistroBE.id_vehiculo));
                cmd.Parameters.Add(new SqlParameter("@pcod", objRegistroBE.id_puesto));

                cnx.Open();
                cmd.ExecuteNonQuery();

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
            return true;
        }

        public RegistroBE ConsultarRegistro(string strcod)
        {
            RegistroBE objRegistroBE = new RegistroBE();
            try
            {
                cnx.ConnectionString = conexion.getConexion();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarRegistro";

                cmd.Parameters.Add(new SqlParameter("@rcod", strcod));

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows)
                {
                    dtr.Read();//DONT FORGET TE READ OF THE SQLDATAREADER SINCE THIS METHOD OPEN THE CONNECTION
                    objRegistroBE.id_registro = strcod;
                    objRegistroBE.h_entrada = dtr.GetDateTime(dtr.GetOrdinal("H_ENTRADA"));
                    //objRegistroBE.h_salida = dtr.GetDateTime(dtr.GetOrdinal("H_SALIDA"));
                    //objRegistroBE.h_entrada = dtr.GetDateTime(dtr.GetOrdinal("TARIFA"));
                    objRegistroBE.descripcion_entrada = dtr.GetString(dtr.GetOrdinal("DESCRIPCION_ENTRADA"));
                    //objRegistroBE.h_entrada = dtr.GetDateTime(dtr.GetOrdinal("DESCRIPCION_SALIDA"));
                    objRegistroBE.id_cliente = dtr.GetString(dtr.GetOrdinal("ID_CLIENTE"));
                    objRegistroBE.id_empleado = dtr.GetString(dtr.GetOrdinal("ID_EMPLEADO"));
                    objRegistroBE.id_vehiculo = dtr.GetString(dtr.GetOrdinal("ID_VEHICULO"));
                    objRegistroBE.id_puesto = dtr.GetString(dtr.GetOrdinal("ID_PUESTO"));
                    objRegistroBE.estado = dtr.GetByte(dtr.GetOrdinal("ESTADO_PLAYA"));//BYTE SINCE IT IS A TINYINT
                    dtr.Close();
                }
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
            return objRegistroBE;
        }

        public bool ActualizarRegistro(RegistroBE objRegistroBE)
        {
            try
            {
                cnx.ConnectionString = conexion.getConexion();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarRegistro";

                cmd.Parameters.Add(new SqlParameter("@rhent", objRegistroBE.h_entrada));
                cmd.Parameters.Add(new SqlParameter("@rhsal", objRegistroBE.h_salida));
                cmd.Parameters.Add(new SqlParameter("@rtarf", objRegistroBE.tarifa));
                cmd.Parameters.Add(new SqlParameter("@rdesen", objRegistroBE.descripcion_entrada));
                cmd.Parameters.Add(new SqlParameter("@rdesal", objRegistroBE.descripcion_salida));
                cmd.Parameters.Add(new SqlParameter("@ccod", objRegistroBE.id_cliente));
                cmd.Parameters.Add(new SqlParameter("@ecod", objRegistroBE.id_empleado));
                cmd.Parameters.Add(new SqlParameter("@vcod", objRegistroBE.id_vehiculo));
                cmd.Parameters.Add(new SqlParameter("@pcod", objRegistroBE.id_puesto));

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

        public bool MarcarEntrada(RegistroBE objRegistroBE)
        {
            try
            {
                cnx.ConnectionString = conexion.getConexion();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_MarcarEntrada";

                cmd.Parameters.Add(new SqlParameter("@rhent", objRegistroBE.h_entrada));
                cmd.Parameters.Add(new SqlParameter("@rdesen", objRegistroBE.descripcion_entrada));
                cmd.Parameters.Add(new SqlParameter("@ccod", objRegistroBE.id_cliente));
                cmd.Parameters.Add(new SqlParameter("@ecod", objRegistroBE.id_empleado));
                cmd.Parameters.Add(new SqlParameter("@vcod", objRegistroBE.id_vehiculo));
                cmd.Parameters.Add(new SqlParameter("@pcod", objRegistroBE.id_puesto));

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

        public bool MarcarSalida(RegistroBE objRegistroBE)
        {
            try
            {
                cnx.ConnectionString = conexion.getConexion();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_MarcarSalida";

                cmd.Parameters.Add(new SqlParameter("@rcod", objRegistroBE.id_registro));
                cmd.Parameters.Add(new SqlParameter("@rhsal", objRegistroBE.h_salida));
                cmd.Parameters.Add(new SqlParameter("@rtarf", objRegistroBE.tarifa));
                cmd.Parameters.Add(new SqlParameter("@rdesal", objRegistroBE.descripcion_salida));
                cmd.Parameters.Add(new SqlParameter("@pcod", objRegistroBE.id_puesto));

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception x)
            {
                return false;
            }
        }

        public DataSet ListarRegistrosDetalle()
        {
            try
            {
                DataSet dts = new DataSet("REGISTROS DETALLE");
                SqlDataAdapter sqlda;

                cnx.ConnectionString = conexion.getConexion();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarClientes";

                sqlda = new SqlDataAdapter(cmd);
                sqlda.Fill(dts, "CLIENTES");

                cmd.CommandText = "usp_ListarVehiculos";
                sqlda = new SqlDataAdapter(cmd);
                sqlda.Fill(dts, "VEHICULOS");

                cmd.CommandText = "usp_ListarRegistros";
                sqlda = new SqlDataAdapter(cmd);
                sqlda.Fill(dts, "REGISTROS");

                dts.Tables["CLIENTES"].PrimaryKey = new DataColumn[] { dts.Tables["CLIENTES"].Columns["ID_CLIENTE"] };
                dts.Tables["VEHICULOS"].PrimaryKey = new DataColumn[] { dts.Tables["VEHICULOS"].Columns["ID_VEHICULO"] };
                dts.Tables["REGISTROS"].PrimaryKey = new DataColumn[] { dts.Tables["REGISTROS"].Columns["ID_REGISTRO"] };

                dts.Relations.Add(dts.Tables["CLIENTES"].Columns["ID_CLIENTE"], dts.Tables["VEHICULOS"].Columns["ID_CLIENTE"]);
                //2ND OVERLOAD (PARENT COLUMN, CHILD COLUMN)
                dts.Relations.Add(dts.Tables["VEHICULOS"].Columns["ID_VEHICULO"], dts.Tables["REGISTROS"].Columns["ID_VEHICULO"]);

                return dts;
            }
            catch (SqlException x)
            {
                throw;
            }
            catch (Exception x)
            {
                throw;
            }
        }

        public DataTable ListarRegistrosClienteFechas(String strcod, DateTime ini, DateTime fin)
        {
            DataSet dts = new DataSet();

            try
            {
                cnx.ConnectionString = conexion.getConexion();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarRegistrosCliente";

                cmd.Parameters.Add(new SqlParameter("@ccod", strcod));
                cmd.Parameters.Add(new SqlParameter("@fec_ini", ini));
                cmd.Parameters.Add(new SqlParameter("@fec_fin", fin));

                SqlDataAdapter sqlda = new SqlDataAdapter();
                sqlda.SelectCommand = cmd;
                sqlda.Fill(dts, "RegistrosCliente");
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cmd.Parameters.Clear();
            }
            return dts.Tables["RegistrosCliente"];
        }
    }
}
