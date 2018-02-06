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

namespace ProyEst_GUI
{
    public partial class frmNuevoVehiculo : Form
    {
        VehiculoBL objVehiculoBL = new VehiculoBL();
        VehiculoBE objVehiculoBE = new VehiculoBE();
        ClienteBL objClienteBL = new ClienteBL();

        public frmNuevoVehiculo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNuevoVehiculo_Load(object sender, EventArgs e)
        {
            try
            {
                cbxClientes.DisplayMember = "NOMBRE_DNI"; //"DNI" == null ? "NOMBRE" : "NOMBRE" + " " + "DNI";
                cbxClientes.ValueMember = "ID_CLIENTE";
                cbxClientes.DataSource = objClienteBL.ListarClientesNombreDNI();

                cbxMarcas.DisplayMember = "NOMBRE_MARCA";
                cbxMarcas.ValueMember = "ID_MARCA";
                cbxMarcas.DataSource = objVehiculoBL.ListarMarcas();

                pbxLogo.Image = Image.FromFile(@"..\..\Resources\carlogos\alfa romeo.png");
                cbxTipoVehiculo.SelectedIndex = 0;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Console.WriteLine(cbxClientes.SelectedValue.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            lblHoraActual.Text = datetime.ToShortTimeString().ToString();
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
    }
}
