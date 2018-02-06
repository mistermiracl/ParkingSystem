using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ProyEst_BE;

namespace ProyEst_ADO
{
    public class ClienteADO
    {
        ConexionADO conexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr; //LEE LOS DATOS OBTENIDOS POR LE METODO CMD.EXECUTEREADER INTERNAL CONSTRUCTOR CANNOT BE INSTATIATED
        DataView dtv_clientesdni;
        bool exito = false;

        public DataTable ListarClientes()
        {
            DataSet dts = new DataSet();
            try
            {
                //Codifique
                cnx.ConnectionString = conexion.getConexion();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarClientes";
                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd); //EJECUTA EL COMMANDO Y OBTIENE SUS RESULTADOS
                miada.Fill(dts, "Clientes");//CONVIERTE LOS RESULTADOS DEL COMANDO EN UN DATATABLE
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dts.Tables["Clientes"];


        }

        public DataTable ListarClientesAbonado()
        {
            DataSet dts = new DataSet();
            try
            {
                cnx.ConnectionString = conexion.getConexion();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarClientesAbonado";

                SqlDataAdapter sqla = new SqlDataAdapter(cmd);
                sqla.Fill(dts, "ClientesAbonado");
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }
            return dts.Tables["ClientesAbonado"];
        }

        public Boolean InsertarCliente(ClienteBE objClienteBE)
        {
            cnx.ConnectionString = conexion.getConexion();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_InsertarCliente";
            //Agregamos parametros 
            try
            {
                //Codifique
                cmd.Parameters.Add(new SqlParameter("@cnom", SqlDbType.VarChar, 50));//NOMBRE DE VARIABLE EN USP
                cmd.Parameters["@cnom"].Value = objClienteBE.nombre;//LLAMAMOS A LOS DATOS DE LAS PROPIEDADES DE LA CLASE CLIENTES

                cmd.Parameters.Add(new SqlParameter("@capep", SqlDbType.VarChar, 50));
                cmd.Parameters["@capep"].Value = objClienteBE.apellido_p;

                cmd.Parameters.Add(new SqlParameter("@capem", SqlDbType.VarChar, 50));
                cmd.Parameters["@capem"].Value = objClienteBE.apellido_m;

                cmd.Parameters.Add(new SqlParameter("@cabo", SqlDbType.Bit));
                cmd.Parameters["@cabo"].Value = objClienteBE.tipo_cliente;


                cnx.Open();
                cmd.ExecuteNonQuery();//EJECUTA LA CONSULTA SIN DEVOLVER FILAS
                exito = true;
            }
            catch (SqlException x)
            {
                exito = false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                // No olvidarse!!!!!!
                cmd.Parameters.Clear();//LIMPIA LA COLLECCION DE PARAMETROS EN EL COMMANDO
            }
            return exito;

        }

        public ClienteBE ConsultarCliente(string strcod)
        {
            ClienteBE objClienteBE = new ClienteBE();
            cnx.ConnectionString = conexion.getConexion();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarCliente";
            try
            {
                cmd.Parameters.Add(new SqlParameter("@cod", SqlDbType.Char, 6));

                cmd.Parameters["@cod"].Value = strcod;

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objClienteBE.id_cliente = dtr.GetValue(dtr.GetOrdinal("ID_CLIENTE")).ToString();
                    objClienteBE.nombre = dtr.GetValue(dtr.GetOrdinal("NOMBRE COMPLETO")).ToString();
                    //objClienteBE.apellido_p = dtr.GetValue(dtr.GetOrdinal("APELLIDO PATERNO")).ToString();
                    //objClienteBE.apellido_m = dtr.GetString(dtr.GetOrdinal("APELLIDO MATERNO"));
                    bool abonado = dtr.GetValue(dtr.GetOrdinal("ES_ABONADO")).ToString().Equals("VERDADERO");
                    objClienteBE.tipo_cliente = abonado;
                    dtr.Close();
                }
                else
                    exito = false;
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
            return objClienteBE;
        }

        public Boolean EliminarCliente(string strcod)
        {
            cnx.ConnectionString = conexion.getConexion();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_EliminarCliente";
            try
            {
                cmd.Parameters.Add(new SqlParameter("@ccod", SqlDbType.Char, 6));
                cmd.Parameters["@ccod"].Value = strcod;

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

        public Boolean ActualizarCliente(ClienteBE objClienteBE)
        {
            try
            {
                cnx.ConnectionString = conexion.getConexion();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarCliente";

                cmd.Parameters.Add(new SqlParameter("@ccod", objClienteBE.id_cliente));
                cmd.Parameters.Add(new SqlParameter("@cnom", objClienteBE.nombre));
                cmd.Parameters.Add(new SqlParameter("@capep", objClienteBE.apellido_p));
                cmd.Parameters.Add(new SqlParameter("@capem", objClienteBE.apellido_m));
                cmd.Parameters.Add(new SqlParameter("@cabo", objClienteBE.tipo_cliente));

                cnx.Open();
                cmd.ExecuteNonQuery();
                exito = true;
            }
            catch (SqlException)
            {
                exito = false;
            }
            catch (Exception)
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

        public DataTable ListarClientesNombreDNI()
        {
            DataSet dts = new DataSet();
            try
            {
                cnx.ConnectionString = conexion.getConexion();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ID_CLIENTE, ID_CLIENTE + ' | ' + NOMBRE + ' ' + [APELLIDO PATERNO] + ' ' + [APELLIDO MATERNO] AS NOMBRE_DNI FROM TB_CLIENTE";
                SqlDataAdapter sqla = new SqlDataAdapter(cmd);
                sqla.Fill(dts, "Clientes");

                dtv_clientesdni = dts.Tables["Clientes"].DefaultView;
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
            return dts.Tables["Clientes"];
        }

        public DataView FiltrarClientesDNI(string filtro)
        {
            try
            {
                dtv_clientesdni.RowFilter = String.Format("NOMBRE_DNI LIKE '%{0}%'", filtro);
                //WE SET THE FILTER USING LIKE KEYWORD THEN APPLYING A PSEUDO REGULAR EXPRESION
            }
            catch (Exception x)
            {
                throw;
            }
            return dtv_clientesdni;
        }
    }
}


