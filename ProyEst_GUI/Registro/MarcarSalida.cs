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
    public partial class MarcarSalida : Form
    {
        //DateTime fecha_actual = DateTime.Now;//WE NEED THIS TO HAVE A VALUE BEFORE THE FORM CLOSED EVENT SINCE WE USE IT IN THERE

        EstacionamientoBL objEstacionamientoBL = new EstacionamientoBL();

        RegistroBL objRegistroBL = new RegistroBL();
        VehiculoBL objVehiculoBL = new VehiculoBL();

        VehiculoBE objVehiculoBE = new VehiculoBE();
        RegistroBE objRegistroBE = new RegistroBE();

        private String vcod;
        private string rcod;

        public string Codigo_Vehiculo
        {
            get { return this.vcod; }
            set { this.vcod = value; }//ASSIGNED VALUE
        }

        public string Codigo_Registro
        {
            get { return this.rcod; }
            set { this.rcod = value; }//ASSIGNED VALUE
        }

        public string Dueño { get; set; }


        double estadia;
        decimal tarifa;

        public MarcarSalida()
        {
            InitializeComponent();
        }

        private void MarcarSalida_Load(object sender, EventArgs e)
        {
            try
            {
                lblEmpleado.Text = frmLogin.CUENTA_ACTIVA.usuario;
                //lblFecha.Text = DateTime.Now.ToShortDateString();

                objVehiculoBE = objVehiculoBL.ConsultarVehiculo(vcod);//USING PRIVATE ATTR IS FASTER ?
                objRegistroBE = objRegistroBL.ConsultarRegistro(rcod);

                lblCodigo.Text = vcod;
                lblPlaca.Text = objVehiculoBE.placa;
                lblDueño.Text = Dueño;
                lblMarca.Text = objVehiculoBE.marca;
                lblModelo.Text = objVehiculoBE.modelo;

                pbxMarca.Image = Image.FromFile(@"..\..\Resources\carlogos\" + lblMarca.Text + ".png");//GET IMAGE USING THE BRAND

                lblFechaIngreso.Text = objRegistroBE.h_entrada.ToLongDateString();
                lblHoraIngreso.Text = objRegistroBE.h_entrada.ToString("hh:mm:ss tt");//WE USE A FORMAT NO MORE LONG OR SHORT STRING

                lblFechaSalida.Text = DateTime.Now.ToLongDateString();
                lblHoraSalida.Text = DateTime.Now.ToString("hh:mm:ss tt");

                estadia = Math.Ceiling((DateTime.Now - objRegistroBE.h_entrada).TotalHours);
                lblEstadia.Text = estadia + " hora(s)";//WE USE MATH CEILING TO ROUND THE NUMBER EVEN IF IT IS JUST 1 DECIMAL TO THE NEXT
                //IMPLICIT CONVERSION CAUSE OF CONCATENATION
                tarifa = objEstacionamientoBL.ListarEstacionamiento().tarifa_diaria * Convert.ToDecimal(estadia);
                lblTarifa.Text = "s/ " + tarifa;
                //WE MULTIPLY THE DAILY COST WITH THE AMOUNT OF HOURS STAYED TO GET THE TOTAL COST
            }
            catch (Exception x)//WHEN A EXCEPTION IS JUSTA A COLUMN NAME IT MEANS IT DIDNT FIND IT (DOES NOT EXIST)
            {
                MessageBox.Show("Error: " + x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //fecha_actual = DateTime.Now;
            lblFechaSalida.Text = DateTime.Now.ToLongDateString();
            lblHoraSalida.Text = DateTime.Now.ToString("hh:mm:ss tt");//FOR EACH TICK (1 SEC)
            lblEstadia.Text = estadia + " hora(s)";
            lblTarifa.Text = "s/ " + tarifa;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                objRegistroBE.id_registro = rcod;
                objRegistroBE.h_salida = DateTime.Now;
                objRegistroBE.tarifa = this.tarifa;
                objRegistroBE.descripcion_salida = rtxtDescripcionSalida.Text;

                if (objRegistroBL.MarcarSalida(objRegistroBE))
                {
                    MessageBox.Show("El vehiculo salio con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Han ocurrido uno o mas errores, revise los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message);
            }
        }
    }
}
