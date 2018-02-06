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
    public partial class frmRegistrosCliente : Form
    {
        ClienteBL objClienteBL = new ClienteBL();//WE INSTATIATE THE CLASS AND ALL OF ITS ATTR ARE INSTATIATED AS WELL
        RegistroBL objRegistroBL = new RegistroBL();

        public frmRegistrosCliente()
        {
            InitializeComponent();
        }

        private void frmRegistrosCliente_Load(object sender, EventArgs e)
        {
            cbxClientes.TextChanged -= cbxClientes_TextChanged;//UNSUBSCRIBE EVENT SO THAT IT DOESNT GET TRIGGERED
            cbxClientes.DisplayMember = "NOMBRE_DNI";
            cbxClientes.ValueMember = "ID_CLIENTE";//THESE MIGHT
            cbxClientes.DataSource = objClienteBL.ListarClientesNombreDNI();//THIS TRIGGERS TEXTCHANGED
            cbxClientes.Text = "";//SINCE THE COMBO TEXTBOX IS ALWAYS FILLED WITH THE 1ST REGISTRY WHEN ASSINGING DATASOURCE
                                  //WE CLEAR IT
                                  //THIS TRIGGERS TEXTCHANGED
            cbxClientes.DroppedDown = false;//THIS TRIGGERS TEXT CHANGED
            //SINCE IT TRIGGERS TEXTCHANGED IT IS ALSO OPENED SO WE CLOSE IT

            cbxClientes.TextChanged += cbxClientes_TextChanged;//WE SUBSCRIBE AGAIN

            //ALL OF THIS ONLY HAPPENS ONCE (Form Load EVENT)
        }

        private void cbxClientes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String text = cbxClientes.Text;//WE SAVE THE ENTERED TEXT ON THE COMBOBOX

                cbxClientes.ValueMember = "ID_CLIENTE";
                cbxClientes.DisplayMember = "NOMBRE_DNI";
                cbxClientes.DataSource = objClienteBL.FiltrarClientesDNI(cbxClientes.Text);
                //WE ASSIGNED THE FILTERED DATAVIEW AS THE DATASOURCE FOR OUR COMBO TAKING AS PARAMETER THE TEXT ENTERED
                cbxClientes.Text = text;//SINCE DATASOURCE BY DEFAULT FILLS THE TEXTBOX PART OF COMBO WITH THE 1ST ENCOUNTER
                                        //WE REASSIGN THE ENTERED TEXT

                if (text.Length > 0)//IF GREATER THAN 0
                                    //USING THE TEXT PROPERTY MOVES THE CARET TO THE BEGGINING OF THE TEXTBOX SO WE MOVE TO THE END
                    cbxClientes.SelectionStart = text.Length;//-1 ONE WOULD CAUSE IT TO BE BEFORE THE LAST LETTER SO WE USE LENGHT AS INDEX
                                                             //cbxClientes.SelectionLength = 0;
                cbxClientes.DroppedDown = true;//WE OPEN THE COMBO WITH THE FILTERED RESULTS
            }
            catch(Exception x)
            {
                MessageBox.Show("Error: " + x.Message);
            }
        }

        private void btnRealizarConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                dtgRegistrosCliente.DataSource = objRegistroBL.ListarRegistrosClienteFechas(
                    cbxClientes.SelectedValue.ToString(), dtpInicio.Value, dtpFin.Value);
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message);
            }
        }

        private void btnRealizarConsulta_Clic(object sender, EventArgs e)
        {
            try
            {
                frmReportViewer frm = new frmReportViewer();
                //frm.strcod = cbxClientes.SelectedValue.ToString();
                frm.Padre = 1;
                frm.fec_ini = dtpInicio.Value;
                frm.fec_fin = dtpFin.Value;
                frm.cliente = objClienteBL.ConsultarCliente(cbxClientes.SelectedValue.ToString());
                frm.ShowDialog();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
