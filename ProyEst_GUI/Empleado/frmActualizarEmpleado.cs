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
    public partial class frmActualizarEmpleado : Form
    {
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        EmpleadoBE objEmpleadoBE = new EmpleadoBE();

        public string ecodigo { get; set; }

        public frmActualizarEmpleado()
        {
            InitializeComponent(); //CANNOT USE CONSTRUCTOR TO SET CLASS PORPERTIES CUZ ecodigo IS NOT SUPPLIED UNTIL THE FORM HAS BEEN LOADED
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
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                objEmpleadoBE.id_empleado = ecodigo;
                objEmpleadoBE.nombre = txtNombre.Text;
                objEmpleadoBE.apellido_p = txtApellidoPaterno.Text;
                objEmpleadoBE.apellido_m = txtApellidoMaterno.Text;
                objEmpleadoBE.telefono = txtTel.Text;
                objEmpleadoBE.email = txtEmail.Text;
                objEmpleadoBE.direccion = cbxDir.Text + " " + txtDir.Text;

                int turno = 0;
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
                objEmpleadoBE.estado = chkEstado.Checked;

                if (objEmpleadoBL.ActualizarEmpleado(objEmpleadoBE) == true)
                {
                    this.Close();
                }

            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmActualizarEmpleado_Load(object sender, EventArgs e)
        {
            try
            {
                objEmpleadoBE = objEmpleadoBL.ConsultarEmpleado(ecodigo);

                txtNombre.Text = objEmpleadoBE.nombre;
                txtApellidoPaterno.Text = objEmpleadoBE.apellido_p;
                txtApellidoMaterno.Text = objEmpleadoBE.apellido_m;
                txtTel.Text = objEmpleadoBE.telefono;
                txtEmail.Text = objEmpleadoBE.email;

                string dir = objEmpleadoBE.direccion;

                cbxDir.Text = dir.Substring(0, dir.IndexOf(" "));
                txtDir.Text = dir.Substring(dir.IndexOf(" ") + 1);

                string turno;
                switch (objEmpleadoBE.turno)
                {
                    case 1:
                        turno = "MAÑANA";
                        break;
                    case 2:
                        turno = "TARDE";
                        break;
                    case 3:
                        turno = "NOCHE";
                        break;
                    default:
                        throw new Exception("Indice fuera del rango permitida para TURNO");
                }
                cbxTurno.Text = turno;
                nudNivel.Value = objEmpleadoBE.nivel;
                txtDni.Text = objEmpleadoBE.dni;
                chkEstado.Checked = objEmpleadoBE.estado;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    if (string.IsNullOrWhiteSpace(txtApellidoMaterno.Text))
                    {
                        control = "Apellido Materno";
                        MessageBox.Show($"{control} no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if ((String.IsNullOrWhiteSpace(txtDni.Text) || txtDni.Text.Length < 8) && txtDni.Enabled == true)
                    {
                        control = "DNI";
                        MessageBox.Show(control + " no puede estar vacio o contener menos de 8 numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    break;
            }
        }

        private void cbx_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cbx = sender as ComboBox;

            switch (cbx.Name)
            {
                case "cbxDir":
                    if (cbxDir.Text.Length == 0)
                    {
                        MessageBox.Show("Prefijo direccion no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    break;
                case "cbxTurno":
                    if (cbxTurno.Text.Length == 0 || cbxTurno.SelectedIndex == -1)
                    {
                        MessageBox.Show("Direccion no puede estar vacia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    break;
            }
        }

        private void nudNivel_Validating(object sender, CancelEventArgs e)
        {
            if(nudNivel.Value < 1)
            {
                MessageBox.Show("Nivel no puede ser menos de 1", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
    }
}
