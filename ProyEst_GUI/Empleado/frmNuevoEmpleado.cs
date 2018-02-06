using ProyEst_BE;
using ProyEst_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyEst_GUI.Empleado
{
    public partial class frmNuevoEmpleado : Form
    {
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        EmpleadoBE objEmpleadoBE = new EmpleadoBE();

        public frmNuevoEmpleado()
        {
            InitializeComponent();
            cbxTurno.SelectedIndex = 0;
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
                if (!char.IsDigit(e.KeyChar))
                    e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.CausesValidation = false;
            txtApellidoPaterno.CausesValidation = false;
            txtApellidoMaterno.CausesValidation = false;
            txtTel.CausesValidation = false;
            txtEmail.CausesValidation = false;
            cbxDir.CausesValidation = false;
            txtDir.CausesValidation = false;
            nudNivel.CausesValidation = false;
            cbxTurno.CausesValidation = false;
            txtDni.CausesValidation = false;

            //foreach(Control control in this.Controls)
            //{
            //    control.CausesValidation = false;
            //}

            Close();
        }

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = sender as TextBox;

            string control;

            if (txt.Name == "txtEmail")
            {
                try
                {
                    MailAddress mail = new MailAddress(txt.Text);
                    int a = txt.Text.IndexOf("@");//INDICE EMPIEZA DESDE CERO, ASI QUE SE PARA TOMAR SU POSICION (NO INDICE) SUMAMOS 1, UNA POSICION MAS
                    string mail2 = txt.Text.Substring(a + 1, txt.Text.Length - (a + 1)); //IT COULD BE -1 SINCE a IS TAKEN AS NEGATIVE SO TO ADD WE 'SUBSTRACT' EASY WAY IS TO ADD THEN USE PARENTHESES
                    int b = mail2.IndexOf(".");//A NO ES DIFERENTE A -1 != NO FUNCIONARA edit != IS NOT VIABLE CUS IF A IS -1 THEN -1 IS NOT DIFFERENT FROM -1 !=
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
                        control = "Apellido";
                        MessageBox.Show(control + " no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    break;
                case "txtApellidoMaterno":
                    if (string.IsNullOrWhiteSpace(txtApellidoMaterno.Text))
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

        private void nudNivel_Validating(object sender, CancelEventArgs e)
        {
            if (nudNivel.Value <= 0)
            {
                MessageBox.Show("Nivel debe ser 1 o mas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void cbx_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cbx = sender as ComboBox;
            switch (cbx.Name)
            {
                case "cbxTurno":
                    if (cbxTurno.SelectedIndex == -1 || cbxTurno.Text.Length == 0)
                    {
                        MessageBox.Show("Turno no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    break;
                case "cbxDir":
                    if (cbxDir.Text.Length == 0)
                    {
                        MessageBox.Show("Error: Prefijo direccion no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    break;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                int turno = 0;

                objEmpleadoBE.nombre = txtNombre.Text;
                objEmpleadoBE.apellido_p = txtApellidoPaterno.Text;
                objEmpleadoBE.apellido_m = txtApellidoMaterno.Text;
                objEmpleadoBE.telefono = txtTel.Text;
                objEmpleadoBE.email = txtEmail.Text;
                objEmpleadoBE.direccion = cbxDir.Text + " " + txtDir.Text;

                switch (cbxTurno.Text)
                {
                    case "MAÑANA":
                        turno = 1;
                        break;
                    case "TARDE":
                        turno = 2;
                        break;
                    case "NOCHE":
                        turno = 3;
                        break;
                }

                objEmpleadoBE.turno = turno;
                objEmpleadoBE.nivel = (int)nudNivel.Value;
                objEmpleadoBE.dni = txtDni.Text;

                if (objEmpleadoBL.InsertarEmpleado(objEmpleadoBE) == true)
                    this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

