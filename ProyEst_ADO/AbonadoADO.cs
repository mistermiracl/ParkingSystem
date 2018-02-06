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
    public class AbonadoADO
    {
        ConexionADO conexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        bool exito;

        public bool InsertarAbonado(AbonadoBE objAbonadoBE)
        {
            try
            {
                cnx.ConnectionString = conexion.getConexion();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarAbonado";

                cmd.Parameters.Add(new SqlParameter("@amail", objAbonadoBE.email));
                cmd.Parameters.Add(new SqlParameter("@adir", objAbonadoBE.direccion));
                cmd.Parameters.Add(new SqlParameter("@atel", objAbonadoBE.telefono));
                cmd.Parameters.Add(new SqlParameter("@adni", objAbonadoBE.dni));
                cmd.Parameters.Add(new SqlParameter("@pcod", objAbonadoBE.id_puesto));
                cmd.Parameters.Add(new SqlParameter("@ccod", objAbonadoBE.id_cliente));
                cnx.Open();
                cmd.ExecuteNonQuery();
                exito = true;
            }
            catch (Exception)
            {
                exito = false;
            }
            finally
            {
                cmd.Parameters.Clear();
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
            return exito;
        }

        public bool InsertarClienteAbonado(ClienteBE objClienteBE, AbonadoBE objAbonadoBE)
        {
            try
            {
                cnx.ConnectionString = conexion.getConexion();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarClienteAbonado";

                cmd.Parameters.Add(new SqlParameter("@cnom", objClienteBE.nombre));
                cmd.Parameters.Add(new SqlParameter("@capep", objClienteBE.apellido_p));
                cmd.Parameters.Add(new SqlParameter("@capem", objClienteBE.apellido_m));
                cmd.Parameters.Add(new SqlParameter("@cabo", objClienteBE.tipo_cliente));
                cmd.Parameters.Add(new SqlParameter("@amail", objAbonadoBE.email));
                cmd.Parameters.Add(new SqlParameter("@adir", objAbonadoBE.direccion));
                cmd.Parameters.Add(new SqlParameter("@atel", objAbonadoBE.telefono));
                cmd.Parameters.Add(new SqlParameter("@adni", objAbonadoBE.dni));
                cmd.Parameters.Add(new SqlParameter("@pcod", objAbonadoBE.id_puesto));
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
                {
                    cnx.Close();
                }
            }
            return exito;
        }

        public AbonadoBE ConsultarAbonado(string strcod)
        {
            AbonadoBE objAbonadoBE = new AbonadoBE();
            try
            {
                cnx.ConnectionString = conexion.getConexion();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarAbonado";

                cmd.Parameters.Add(new SqlParameter("@acod", strcod));

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objAbonadoBE.id_abonado = dtr.GetValue(dtr.GetOrdinal("ID_ABONADO")).ToString();
                    objAbonadoBE.estado_pago = dtr.GetString(dtr.GetOrdinal("ESTADO_PAGO")) == "DEBIENDO" ? false : true;
                    objAbonadoBE.email = dtr.GetString(dtr.GetOrdinal("EMAIL"));
                    objAbonadoBE.direccion = dtr.GetString(dtr.GetOrdinal("DIRECCION"));
                    objAbonadoBE.telefono = dtr.GetString(dtr.GetOrdinal("TELEFONO"));
                    objAbonadoBE.dni = dtr.GetString(dtr.GetOrdinal("DNI"));
                    objAbonadoBE.id_puesto = dtr.GetString(dtr.GetOrdinal("ID_PUESTO"));
                    objAbonadoBE.id_cliente = dtr.GetString(dtr.GetOrdinal("ID_CLIENTE"));
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
            return objAbonadoBE;
        }

        public bool ActualizarAbonado(AbonadoBE objAbonadoBE)
        {
            try
            {
                cnx.ConnectionString = conexion.getConexion();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarAbonado";

                cmd.Parameters.Add(new SqlParameter("@acod", objAbonadoBE.id_abonado));
                cmd.Parameters.Add(new SqlParameter("@aest", objAbonadoBE.estado_pago));
                cmd.Parameters.Add(new SqlParameter("@amail", objAbonadoBE.email));
                cmd.Parameters.Add(new SqlParameter("@adir", objAbonadoBE.direccion));
                cmd.Parameters.Add(new SqlParameter("@atel", objAbonadoBE.telefono));
                cmd.Parameters.Add(new SqlParameter("@adni", objAbonadoBE.dni));
                cmd.Parameters.Add(new SqlParameter("@pcod", objAbonadoBE.id_puesto));
                cmd.Parameters.Add(new SqlParameter("@ccod", objAbonadoBE.id_cliente));

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

        public bool EliminarAbonado(string strcod)
        {
            try
            {
                cnx.ConnectionString = conexion.getConexion();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarAbonado";

                cmd.Parameters.Add(new SqlParameter("@acod", strcod));

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
    }
}
