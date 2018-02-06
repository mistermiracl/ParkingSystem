using ProyEst_BL;
using ProyEst_GUI.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyEst_GUI.Consultas
{
    public partial class frmVehiculosIngresados : Form
    {
        VehiculoBL objVehiculoBL = new VehiculoBL();

        string criterio;
        int orden;

        public frmVehiculosIngresados()
        {
            InitializeComponent();
        }

        private void frmVehiculosIngresados_Load(object sender, EventArgs e)
        {
            try
            {
                cbxMarcas.DisplayMember = "NOMBRE_MARCA";
                cbxMarcas.ValueMember = "ID_MARCA";
                cbxMarcas.DataSource = objVehiculoBL.ListarMarcas();

                objVehiculoBL.ListarVehiculos();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtnPlaca.Checked)
                {
                    orden = 1;
                    criterio = "Placa";
                }
                else if (rbtnMarca.Checked)
                {
                    orden = 2;
                    criterio = "Marca";
                }

                dtgVehiculosIngresados.DataSource = objVehiculoBL.OrdenarVehiculosYFiltrarPorMarca(orden);
                
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultarPorMarca_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtnPlaca.Checked)
                {
                    orden = 1;
                    criterio = "Placa";
                }
                else if (rbtnMarca.Checked)
                {
                    orden = 2;
                    criterio = "Marca";
                }

                dtgVehiculosIngresados.DataSource = objVehiculoBL.OrdenarVehiculosYFiltrarPorMarca(orden, cbxMarcas.Text);
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimirReporte_Click(object sender, EventArgs e)
        {
            try
            {
                frmReportViewer frm = new frmReportViewer();
                frm.Padre = 2;
                frm.dtv = (DataView)dtgVehiculosIngresados.DataSource;
                frm.criterio = criterio;
                frm.ShowDialog();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
