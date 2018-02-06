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
    public partial class frmActualizarCliente : Form
    {
        ClienteBE objClienteBE = new ClienteBE();
        ClienteBL objClienteBL = new ClienteBL();
        AbonadoBE objAbonadoBE = new AbonadoBE();
        AbonadoBL objAbonadoBL = new AbonadoBL();
        PuestoBL objPuestoBL = new PuestoBL();

        int posicioncbx;

        private string ccodigo;
        public string Ccodigo
        {
            get { return ccodigo; }
            set { ccodigo = value; }
        }

        public string acodigo { get; set; }

        public string apuesto { get; set; }

        public frmActualizarCliente()
        {
            InitializeComponent();
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                //Codifique
                objClienteBE = objClienteBL.ConsultarCliente(Ccodigo);//LLENAMOS LA CLASE CON LA FILA A LA QUE LE PERTENECE ID DESEADO
                //CLOSE INTERVAL ON RIGHT, ON LEFT IT TAKES THE FIRST VALUE PROVIDED AS CERO, BUT IT TAKES IT. EDIT: NO INTERVALS THIS IS C#
                txtNombre.Text = objClienteBE.nombre.Substring(0, objClienteBE.nombre.IndexOf(" "));//LLENAMOS LOS INPUTS CON LOS DATOS ADQUIRIDOS

                //string apellido_p = objClienteBE.apellido_p;
                //string apellido_m = objAbonadoBE.ape
                //int index = objClienteBE.nombre.IndexOf(' ', objClienteBE.nombre.IndexOf(' ') + 1); //ADD 1 OTHERWISE WE GET THE FIRST OCURRENCE OF SPACE SINCE WE ARE CALLIING ITS FIRST INDEX
                string ape = objClienteBE.nombre.Substring(objClienteBE.nombre.IndexOf(' ') + 1);//REMEMBER PLUS ONE SINCE WE DONT WANT TO TAKE THE WHITESPACE CUZ ITS A CLOSED INTERVAL (ONLY IN THE BEGINNING THIS ISNT JAVA)
                txtApellidoPaterno.Text = ape.Substring(0, ape.IndexOf(' '));//WE DONT ADD OR SUBSCTRACT ANYTHING SINCE WE DONT WANT TO TAKE THE WHITESPACE AND INDEXES START FROM CERO (if its index is 3 its position its 4 and so on)
                txtApellidoMaterno.Text = objClienteBE.nombre.Substring(objClienteBE.nombre.IndexOf(' ', objClienteBE.nombre.IndexOf(' ') + 1) + 1);//PLUS 1 TO NOT TAKE THE WHITESPACE AND SINCE WE NEED THE REMAINING PART OF THE STRING WE DO NOT NEED TO SPECIFY HOW MANY CHARS TO THE LEFT TO 'JUMP'
                chkAbonado.Checked = objClienteBE.tipo_cliente;                                                                                     //WE ALSO ADD 1 TO THE SECOND INDEX OF CUZ OTHERWISE IT WOULD TAKE IT (THE FIRST SPACE) AS START INDEX (NOT SURE IF ITS A CLOSED INTERVAL IN THE BEGGINING AS WELL)

                if (!String.IsNullOrEmpty(acodigo))
                {
                    cbxPuesto.DataSource = objPuestoBL.ListarPuestos();
                    cbxPuesto.ValueMember = "ID_PUESTO";

                    objAbonadoBE = objAbonadoBL.ConsultarAbonado(acodigo);

                    chkAbonado.Checked = true;

                    txtEmail.Text = objAbonadoBE.email;

                    string dir = objAbonadoBE.direccion;
                    string a = dir.Substring(0, dir.IndexOf(' '));
                    string b = dir.Substring(dir.IndexOf(' ') + 1, dir.Length - dir.IndexOf(' ') - 1);//WE ARE 'ADDING' TO A NEGATIVE BY USING A MINUS
                    cbxDir.Text = a;
                    txtDir.Text = b;
                    txtTel.Text = objAbonadoBE.telefono;
                    txtDni.Text = objAbonadoBE.dni;
                    //cbxPuesto.Items.Add(apuesto);
                    //cbxPuesto.SelectedIndex = cbxPuesto.Items.IndexOf(apuesto);
                    //chkAldia.Checked = ;
                    if (objAbonadoBE.estado_pago)
                        rbtnAldia.Checked = true;
                    else
                        rbtnDebiendo.Checked = true;

                    return;
                }
                //chkAldia.Checked = true; //IF IT ISNT AN ABONADO THEN WE CHECK ALDIA SINCE IT CANNOT HAVE DEBTS
                rbtnAldia.Checked = true;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                objClienteBE.id_cliente = Ccodigo;
                objClienteBE.nombre = txtNombre.Text;
                objClienteBE.apellido_p = txtApellidoPaterno.Text;
                objClienteBE.apellido_m = txtApellidoMaterno.Text;
                objClienteBE.tipo_cliente = chkAbonado.Checked; //THE TYPE BOOLEAN IS CONVERTED TO BIT WHEN ENTERING THE DATABASE

                if (!chkAbonado.Checked)//WE CHECK WETHER THE CLIENT WAS AN ABONADO OR NOT
                {
                    if (String.IsNullOrWhiteSpace(acodigo))//WE CHECK IF THE CLIENT IS AN ABONADO BY VALIDATING ITS CODE
                    {//IF IT ISNT AN ABONADO THEN
                        if (objClienteBL.ActualizarCliente(objClienteBE) == true)
                        {
                            MessageBox.Show("Cliente actualizado con exito", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Error: Verifique los datos Ingresados");
                    }
                    else
                    {
                        if (objAbonadoBL.EliminarAbonado(acodigo) == true)//IF IT WAS AND ABONADO THEN WE ERASE IT
                        {
                            if (objClienteBL.ActualizarCliente(objClienteBE) == true)
                            {
                                MessageBox.Show("Cliente actualizado con exito", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error: Verifique los datos Ingresados");
                        }
                    }
                }
                else if (chkAbonado.Checked)//TWO POSSIBILITIES IT WAS AN ABONADO AND ITS BEING MODIFIED OR IT WASNT AND ITS BEING ADDED
                {

                    objAbonadoBE.id_abonado = acodigo;
                    //objAbonadoBE.estado_pago = chkAldia.Checked;
                    objAbonadoBE.estado_pago = rbtnAldia.Checked ? true : false;
                    objAbonadoBE.email = txtEmail.Text;
                    objAbonadoBE.direccion = cbxDir.Text + " " + txtDir.Text;
                    objAbonadoBE.telefono = txtTel.Text;
                    objAbonadoBE.dni = txtDni.Text;
                    objAbonadoBE.id_puesto = cbxPuesto.Text;
                    objAbonadoBE.id_cliente = Ccodigo;

                    //IF IT WAS AN ABONADO TO BEGIN WITH (WE KNOW BECAUSE WE RETRIVED ITS CODE PREVIOULY)
                    if (!String.IsNullOrWhiteSpace(acodigo))//WE VERIFY IT HAS A CODE
                    {
                        if (objClienteBL.ActualizarCliente(objClienteBE) == true)//FIRST WE UPDATE THE CLIENT
                        {

                            if (objAbonadoBL.ActualizarAbonado(objAbonadoBE))//THEN THE ABONADO, AND THEN ITS CORRESPONDING SPOT
                            {
                                if (objPuestoBL.ActualizarPuesto(apuesto, true) == true)//WE CHANGE THE OLD SPOT STATE TO AVAILABLE IN CASE IS THE SAME SPOT WE STILL CHANGE IT LATER 
                                    if (objPuestoBL.ActualizarPuesto(cbxPuesto.Text, false) == true)
                                    {
                                        MessageBox.Show("Cliente actualizado con exito", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Close();
                                    }
                                    else
                                        MessageBox.Show("Error: Verifique los datos ingresados", "ERROR");
                            }
                        }
                    }
                    else//IF IT WASNT AN ABONADO THEN WE ADD HIM/HER
                    {
                        if (objAbonadoBL.InsertarAbonado(objAbonadoBE) == true)
                        {
                            MessageBox.Show("Cliente actualizado con exito", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error" + x.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                //chkAldia.Enabled = true;
                groupBox1.Enabled = true;

                if (!String.IsNullOrEmpty(apuesto))
                    cbxPuesto.DataSource = objPuestoBL.ListarPuestos();
                else
                    cbxPuesto.DataSource = objPuestoBL.ListarPuestosDisponibles();

                cbxPuesto.DisplayMember = "ID_PUESTO";
            }
            else
            {
                txtEmail.Enabled = false;
                cbxDir.Enabled = false;
                txtDir.Enabled = false;
                txtTel.Enabled = false;
                txtDni.Enabled = false;
                cbxPuesto.Enabled = false;
                chkAldia.Enabled = false;

                //chkAldia.Checked = false;
                groupBox1.Enabled = false;
                cbxPuesto.DataSource = null;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.CausesValidation = false; //PONER PROPIEDAD CAUSES VALIDATION DEL CONTROL (BOTON) A FALSE
            txtApellidoPaterno.CausesValidation = false;
            txtApellidoMaterno.CausesValidation = false;
            this.Close();
        }

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = sender as TextBox;
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
                        MessageBox.Show("E-mail no valido");
                        e.Cancel = true;
                    }
                    else
                        return;
                }
                catch (Exception x)
                {
                    MessageBox.Show("E-Mail no valido");
                    e.Cancel = true;
                }
            }
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
                    if (string.IsNullOrWhiteSpace(txtApellidoMaterno.Text))
                    {
                        control = "Apellido Materno";
                        MessageBox.Show(control + " no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cbx_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cbx = sender as ComboBox;
            if (cbx.SelectedIndex == -1 && cbx.Text.Length == 0)
            {
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

        private void frmActualizarCliente_Activated(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(apuesto))//IF ITS AND ABONADO
                cbxPuesto.SelectedValue = apuesto;//THIS IS NEEDS TO BE EXECUTED AFTER THE FORM IS SHOWN, OTHERWISE IT WONT WORK
        }

        private void cbxPuesto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(apuesto))
                {//SINCE WE ONLY EVALUATE WHEN THE CLIENT IS ABONADO CAUSE HE HAS A PUESTO ALREADY
                    if (objPuestoBL.ConsultarPuestoDisponible(cbxPuesto.SelectedValue.ToString()) == false)
                    {
                        if (cbxPuesto.SelectedValue.ToString() == apuesto)
                            return;
                        else
                        {
                            cbxPuesto.SelectedIndex = posicioncbx;
                            MessageBox.Show("Puesto ocupado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        posicioncbx = cbxPuesto.SelectedIndex;
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(x.StackTrace);
            }
        }

        //private void cbxPuesto_Enter(object sender, EventArgs e)
        //{
        //    posicioncbx = cbxPuesto.SelectedIndex;
        //}
    }
}
