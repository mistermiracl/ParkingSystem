using ProyEst_BE;
using ProyEst_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyEst_GUI.Registro
{
    public partial class MarcarEntrada : Form
    {
        ClienteBL objClienteBL = new ClienteBL();
        RegistroBL objRegistroBL = new RegistroBL();
        VehiculoBL objVehiculoBL = new VehiculoBL();
        PuestoBL objPuestoBL = new PuestoBL();

        VehiculoBE objVehiculoBE = new VehiculoBE();
        RegistroBE objRegistroBE = new RegistroBE();

        DateTime fecha_hora_ingreso;

        public MarcarEntrada()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MarcarEntrada_Load(object sender, EventArgs e)
        {
            try
            {
                cbxClientes.DisplayMember = "NOMBRE_DNI"; //"DNI" == null ? "NOMBRE" : "NOMBRE" + " " + "DNI";
                cbxClientes.ValueMember = "ID_CLIENTE";
                cbxClientes.DataSource = objClienteBL.ListarClientesNombreDNI();

                cbxMarcas.DisplayMember = "NOMBRE_MARCA";
                cbxMarcas.ValueMember = "ID_MARCA";
                cbxMarcas.DataSource = objVehiculoBL.ListarMarcas();

                cbxPuestos.DisplayMember = "ID_PUESTO";
                cbxPuestos.DataSource = objPuestoBL.ListarPuestosDisponibles();

                pbxLogo.Image = Image.FromFile(@"..\..\Resources\carlogos\alfa romeo.png");
                cbxTipoVehiculo.SelectedIndex = 0;

                mtxtPlaca.SelectionStart = 0;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(cbxClientes.SelectedValue.ToString());
            //string tarifa = Convert.ToString(fecha_hora_ingreso - DateTime.Now);
            try
            {
                objVehiculoBE.marca = cbxMarcas.Text;
                objVehiculoBE.modelo = cbxModelos.Text;
                objVehiculoBE.placa = mtxtPlaca.Text;
                objVehiculoBE.id_cliente = cbxClientes.SelectedValue.ToString();
                objVehiculoBE.tipo = cbxTipoVehiculo.Text;

                string vcod = objVehiculoBL.InsertarVehiculo(objVehiculoBE);

                if (!String.IsNullOrWhiteSpace(vcod))
                {
                    objRegistroBE.h_entrada = fecha_hora_ingreso;
                    objRegistroBE.descripcion_entrada = rtxtDescripcion.Text;
                    objRegistroBE.id_cliente = cbxClientes.SelectedValue.ToString();
                    objRegistroBE.id_empleado = frmLogin.CUENTA_ACTIVA.id_empleado;
                    objRegistroBE.id_vehiculo = vcod;
                    objRegistroBE.id_puesto = cbxPuestos.Text;
                    objRegistroBE.estado = 1; //INSIDE OF PARKING LOT

                    if (objRegistroBL.MarcarEntrada(objRegistroBE))//WE INSERT THE REGITRY AND WE DONT NEED TO WORRY ABOUT THE STATE OF THE SPOT SINCE MARCAR ENTRADA usp HANDLES IT NICELY
                    {
                        MessageBox.Show("Registro ingresado con éxito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Se encontraron uno o más errores, verifique lo ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Se encontraron uno o más errores, verifique lo ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fecha_hora_ingreso = DateTime.Now;
            lblHoraActual.Text = fecha_hora_ingreso.ToString();// + " " + fecha_hora_ingreso.TimeOfDay.ToString().Substring(0, 8);
        }

        private void cbxMarcas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(cbxMarcas.Text))
                {
                    cbxModelos.Enabled = true;
                    cbxModelos.DisplayMember = "NOMBRE_MODELO";
                    cbxModelos.ValueMember = "ID_MODELO";
                    cbxModelos.DataSource = objVehiculoBL.ConsultarModelos(cbxMarcas.SelectedValue.ToString());
                    pbxLogo.Image = Image.FromFile(@"..\..\Resources\carlogos\" + cbxMarcas.Text.ToLower() + ".png");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mtxtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                //mtxtPlaca.Text.Remove(mtxtPlaca.Text.IndexOf(e.KeyChar));
                //mtxtPlaca.AppendText(e.KeyChar.ToString().ToUpper());
            }
        }

        private void mtxtPlaca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(mtxtPlaca.TextLength == 7)
                {
                    VehiculoBE veh = objVehiculoBL.ConsultarVehiculoPorPlaca(mtxtPlaca.Text);
                    if (veh != null)
                    {
                        cbxTipoVehiculo.SelectedIndex = cbxTipoVehiculo.FindStringExact(veh.tipo);
                        cbxMarcas.SelectedIndex = cbxMarcas.FindStringExact(veh.marca);
                        cbxModelos.Text = veh.modelo;
                        cbxClientes.SelectedValue = veh.id_cliente;
                        cbxModelos.Enabled = true;
                    }
                    else
                    {
                        cbxTipoVehiculo.SelectedIndex = 0;
                        cbxMarcas.SelectedIndex = 0;
                        cbxModelos.Text = "";
                        cbxClientes.SelectedIndex = 0;
                        cbxModelos.Enabled = false;
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error:" + x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
