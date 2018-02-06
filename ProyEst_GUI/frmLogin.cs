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
    public partial class frmLogin : Form
    {
        public static CuentaBE CUENTA_ACTIVA;
        CuentaBL objCuentaBL = new CuentaBL();
        CuentaBE objCuentaBE = new CuentaBE();
        public frmLogin()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                objCuentaBE = objCuentaBL.consultarCuenta(txtUsuario.Text, txtContraseña.Text);
                //this query needs to return and employee id so it return null if it finds none
                if ((objCuentaBE.usuario != null && objCuentaBE.contraseña != null) && (objCuentaBE.usuario != String.Empty && objCuentaBE.contraseña != String.Empty))
                {
                    CUENTA_ACTIVA = objCuentaBE;

                    frmPrincipal frmprincipal = new frmPrincipal();
                    this.Hide();

                    niBalloon.Icon = SystemIcons.Information;
                    niBalloon.BalloonTipTitle = "Bienvenido";
                    niBalloon.BalloonTipText = "El usuario: " + txtUsuario.Text + ", a ingresado correctamente";
                    niBalloon.BalloonTipIcon = ToolTipIcon.Info;

                    niBalloon.ShowBalloonTip(1000);

                    //frmprincipal.usuario = txtUsuario.Text;
                    frmprincipal.Show();
                    frmprincipal.FormClosed += delegate
                    {
                        this.Show();
                        txtUsuario.Clear();//PERFORM ALL OF THESE AFTER THE WINDOW IS SHOWN OTHERWISE IT WILL FOCUS THE CONTROL THAT HAD THE FOCUS THE LAST TIME
                        txtContraseña.Text = String.Empty;
                        txtUsuario.Focus();
                    };
                }
                else
                {
                    MessageBox.Show("ERROR: Credenciales Incorrectas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Clear();
                    txtContraseña.Clear();
                    txtUsuario.Focus();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;//WE HANDLE THE KEY PRESS SO THAT THE BEEP SOUND DOESNT TRIGGER (ONLY WHEN PRESSING ENTER)
                btnIngresar.PerformClick();
            }
        }
    }
}
