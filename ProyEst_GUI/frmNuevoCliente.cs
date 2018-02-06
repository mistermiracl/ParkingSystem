using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyEst_BE;
using ProyEst_BL;
using System.Net.Mail;

namespace ProyEst_GUI
{
    public partial class frmNuevoCliente : Form
    {
        ClienteBL objClienteBL = new ClienteBL();
        ClienteBE objClienteBE = new ClienteBE();
        AbonadoBL objAbonadoBL = new AbonadoBL();
        AbonadoBE objAbonadoBE = new AbonadoBE();
        PuestoBL objPuestoBL = new PuestoBL();
        public frmNuevoCliente()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                //Codifique
                //ASIGNAMOS LOS VALORES DE LAS CLASE CON LOS VALORES DE LOS INGRESADOS EN LOS INPUTS
                objClienteBE.nombre = txtNombre.Text;
                objClienteBE.apellido_p = txtApellidoPaterno.Text;
                objClienteBE.apellido_m = txtApellidoMaterno.Text;
                objClienteBE.tipo_cliente = chkAbonado.Checked;
                if (chkAbonado.Checked)
                {
                    objAbonadoBE.email = txtEmail.Text;
                    objAbonadoBE.direccion = cbxDir.Text + " " + txtDir.Text;
                    objAbonadoBE.telefono = txtTel.Text;
                    objAbonadoBE.dni = txtDni.Text;
                    objAbonadoBE.id_puesto = cbxPuesto.Text;
                    //INSERTAMOS EL CLIENTE
                    if (objAbonadoBL.InsertarClienteAbonado(objClienteBE, objAbonadoBE) == true)
                    {
                        MessageBox.Show("Cliente ingresado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Error: verifique los datos ingresados", "ERROR");
                }
                else
                {
                    //INSERTAMOS EL CLIENTE
                    if (objClienteBL.InsertarCliente(objClienteBE) == true)
                    {
                        MessageBox.Show("Cliente ingresado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Error: verifique los datos ingresados", "ERROR");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.CausesValidation = false; //PONER PROPIEDAD CAUSES VALIDATION DEL CONTROL (BOTON) A FALSE
            txtApellidoPaterno.CausesValidation = false;
            txtApellidoMaterno.CausesValidation = false;
            if (chkAbonado.Checked)
            {
                txtEmail.CausesValidation = false;
                cbxDir.CausesValidation = false;
                txtDir.CausesValidation = false;
                txtTel.CausesValidation = false;
                txtDni.CausesValidation = false;
                cbxPuesto.CausesValidation = false;
            }
            this.Close();
        }

        private void control_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = sender as TextBox;
            //string control = txt.Name == "txtNombre" ? "Nombre" : "Apellido";
            if (txt.Name == "txtEmail" && txt.Enabled == true)
            {
                try
                {
                    MailAddress mail = new MailAddress(txt.Text);
                    int a = txt.Text.IndexOf("@");//INDICE EMPIEZA DESDE CERO, ASI QUE SE PARA TOMAR SU POSICION (NO INDICE) SUMAMOS 1, UNA POSICION MAS
                    string mail2 = txt.Text.Substring(a + 1, txt.Text.Length - (a + 1)); //IT COULD BE -1 SINCE a IS TAKEN AS NEGATIVE SO TO ADD WE 'SUBSTRACT' EASY WAY IS TO ADD THEN USE PARENTHESES
                    int b = mail2.IndexOf(".");//A NO ES DIFERENTE A -1 != NO FUNCIONARA
                    if (b == -1)
                    {
                        MessageBox.Show("E-mail no valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    else
                        return;
                }
                catch (Exception x)
                {
                    MessageBox.Show("E-Mail no valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            //else
            //{
            //    return;
            //}
            //MessageBox.Show(control + " no puede estar vacio");
            //e.Cancel = true;
            //txtApellido.SelectAll();
            string control;

            switch (txt.Name)
            {
                case "txtNombre":
                    if (String.IsNullOrWhiteSpace(txtNombre.Text))
                    {
                        control = "Nombre";
                        MessageBox.Show(control + " no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    break;
                case "txtApellidoPaterno":
                    if (String.IsNullOrWhiteSpace(txtApellidoPaterno.Text))
                    {
                        control = "Apellido Paterno";
                        MessageBox.Show(control + " no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    break;
                case "txtApellidoMaterno":
                    if (String.IsNullOrWhiteSpace(txtApellidoMaterno.Text))
                    {
                        control = "Apellido Materno";
                        MessageBox.Show(control + " no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    break;
                case "txtDir":
                    if (String.IsNullOrWhiteSpace(txtDir.Text) && txtDir.Enabled == true)
                    {
                        control = "Dirrecion";
                        MessageBox.Show(control + " no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    break;
                case "txtTel":
                    if (String.IsNullOrWhiteSpace(txtTel.Text) && txtTel.Enabled == true)
                    {
                        control = "Telefono";
                        MessageBox.Show(control + " no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    break;
                case "txtDni":
                    if (String.IsNullOrWhiteSpace(txtDni.Text) && txtDni.Enabled == true)
                    {
                        control = "DNI";
                        MessageBox.Show(control + " no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    break;
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

        }

        private void chkAbonado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAbonado.Checked)
            {
                txtEmail.Enabled = true;
                cbxDir.Enabled = true;
                txtDir.Enabled = true;
                txtTel.Enabled = true;
                txtDni.Enabled = true;
                cbxPuesto.Enabled = true;
                try
                {
                    cbxPuesto.DataSource = objPuestoBL.ListarPuestosDisponibles();
                    cbxPuesto.DisplayMember = "ID_PUESTO";
                }
                catch(Exception x)
                {
                    MessageBox.Show("Error: " + x.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!chkAbonado.Checked)
            {
                cbxPuesto.DataSource = null;

                txtEmail.Enabled = false;
                cbxDir.Enabled = false;
                txtDir.Enabled = false;
                txtTel.Enabled = false;
                txtDni.Enabled = false;
                cbxPuesto.Enabled = false;
            }
        }

        private void cbx_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cbx = sender as ComboBox;
            if (cbx.SelectedIndex == -1 && cbx.Text.Length == 0) {
                switch (cbx.Name)
                {
                    case "cbxDir":
                        MessageBox.Show("Prefijo Direccion no puede estar en blanco");
                        break;
                    case "cbxPuesto":
                        MessageBox.Show("Puesto no puede estar vacio");
                        break;
                }
                e.Cancel = true;
            }
        }
    }
}
