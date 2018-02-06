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
using ProyEst_GUI.Empleado;
using ProyEst_GUI.Estacionamiento;
using Microsoft.VisualBasic.Devices;
using System.Media;
using ProyEst_GUI.Vehiculo;
using ProyEst_GUI.Registro;
using ProyEst_GUI.Consultas;

namespace ProyEst_GUI
{
    public partial class frmPrincipal : Form
    {
        //public string usuario { get; set; }
        TimeSpan hentrada = new TimeSpan();
        Computer pcactual = new Computer();

        ClienteBL objClienteBL = new ClienteBL();
        AbonadoBL objAbonadoBL = new AbonadoBL();
        VehiculoBL objVehiculoBL = new VehiculoBL();
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        PuestoBL objPuestoBL = new PuestoBL();


        private Point mouseDownLocation;//WE NEED THE CURRENT LOCATION TO DRAG PANELS
        private bool mousedownstate;//TO CANCEL DRAGGIN EVENT MDOWN MUP


        public frmPrincipal()
        {
            InitializeComponent();
        }



        #region METODOS
        public void ActualizarClientes()
        {
            try
            {
                dtgClientes.DataSource = objClienteBL.ListarClientesAbonado();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ActualizarVehiculos()
        {
            try
            {
                dtgVehiculos.DataSource = objVehiculoBL.ListarVehiculosRegistro();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ActualizarEmpleados()
        {
            try
            {
                dtgEmpleados.DataSource = objEmpleadoBL.ListarEmpleados();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region EVENTOS
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelVehiculos.Visible = false;
            panelEmpleados.Visible = false;
            panelCliente.Visible = true;

            try
            {
                ActualizarClientes();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR: " + x.Message);
            }

        }

        private void vehículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelCliente.Visible = false;
            panelEmpleados.Visible = false;
            panelVehiculos.Visible = true;

            try
            {
                ActualizarVehiculos();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message);
            }
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelCliente.Visible = false;
            panelVehiculos.Visible = false;
            panelEmpleados.Visible = true;
            try
            {
                ActualizarEmpleados();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error" + x.Message);
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAyuda frm = new frmAyuda();
            frm.ShowDialog();
        }

        #region PANEL EVENTS  
        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownLocation = e.Location;
            mousedownstate = true;
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            Panel panel = (Panel)sender;
            if (mousedownstate)
            {
                //panelCliente.Location = new Point(
                //(this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                //this.Update();
                panel.Top = e.Y + panel.Top - mouseDownLocation.Y;
                panel.Left = e.X + panel.Left - mouseDownLocation.X;
            }
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            mousedownstate = false;
        }
        #endregion

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstacionamientoConf frm = new frmEstacionamientoConf();
            //frm.Usuarioactivo = this.Text.Substring(this.Text.IndexOf(":") + 1);//FROM 2 DOTS TO WHATEVER IS LEFT
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + ": " + frmLogin.CUENTA_ACTIVA.usuario;
            hentrada = DateTime.Now.TimeOfDay;

            if (pcactual.Network.IsAvailable)
                lblPC.Text = String.Concat(pcactual.Name, "  Estado: Online");
            else
                lblPC.Text = string.Concat(pcactual.Name, "  Estado: Offline");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTiempoSesion.Text = "Tiempo en Sesion: " + DateTime.Now.TimeOfDay.Subtract(hentrada).ToString().Substring(0, 8);
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemSounds.Asterisk.Play();//QUESTION DOESNT PLAY CAUSE THERE IS NO SOUND LINKED TO IT ON THE SOUNDS IN CONTROL PANEL
            DialogResult resultado = MessageBox.Show("¿Esta seguro que desea salir? se procedera a cerrar la sesion actual.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
                e.Cancel = true;
        }
        #endregion


        #region CLIENTE
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNuevoCliente frm = new frmNuevoCliente();
            //frm.MdiParent = this;
            frm.ShowDialog();
            ActualizarClientes();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            frmActualizarCliente frm = new frmActualizarCliente();
            //frm.MdiParent = this;
            frm.Ccodigo = dtgClientes.CurrentRow.Cells[0].Value.ToString();
            string acod = dtgClientes.CurrentRow.Cells[3].Value.ToString();
            string apue = dtgClientes.CurrentRow.Cells[11].Value.ToString();
            if (!String.IsNullOrWhiteSpace(acod))
                frm.acodigo = acod;
            if (!String.IsNullOrWhiteSpace(apue))
                frm.apuesto = apue;
            frm.ShowDialog();
            ActualizarClientes();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            panelCliente.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = dtgClientes.CurrentRow.Cells[0].Value.ToString();//GRID POSITION OF CODIGO CLIENTE
                DialogResult rpta = MessageBox.Show("¿Esta seguro que desa eliminar este Cliente?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == DialogResult.Yes)
                {
                    if (!String.IsNullOrEmpty(dtgClientes.CurrentRow.Cells[11].Value.ToString()))
                    {
                        if (objAbonadoBL.EliminarAbonado(dtgClientes.CurrentRow.Cells[3].Value.ToString()) == true)
                        {//GRID POSITION OF CODIGO ABONADO, TO DELETE A CLIENTE WHO IS ALSO ABONADO WE DELETE ABONADO FIRST THEN THE CLIENT THEN UPDATE THE VALUES PUESTO VALUES TO BE USED AGAIN
                            if (objClienteBL.EliminarCliente(codigo) == true)
                            {
                                if (objPuestoBL.ActualizarPuesto(dtgClientes.CurrentRow.Cells[11].Value.ToString(), true) == true)
                                {
                                    MessageBox.Show("Cliente eliminado satisfactoriamente", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ActualizarClientes();
                                }
                            }
                        }
                    }
                    else
                    {
                        if (objClienteBL.EliminarCliente(codigo) == true)
                        {
                            MessageBox.Show("Cliente eliminado satisfactoriamente", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ActualizarClientes();
                        }
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region VECHICULO
        private void btnSalirVehiculo_Click(object sender, EventArgs e)
        {
            panelVehiculos.Visible = false;
        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            MarcarEntrada frm = new MarcarEntrada();
            //frm.MdiParent = this;
            frm.ShowDialog();
            ActualizarVehiculos();
        }

        private void btnActualizarVehiculo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(dtgVehiculos.CurrentRow.Cells[9].Value.ToString()))//CHECK WHETHER THE VEHICLE IS OUT OR NOT
            {
                MarcarSalida frm = new MarcarSalida();
                //frm.MdiParent = this;
                frm.Codigo_Vehiculo = dtgVehiculos.CurrentRow.Cells[0].Value.ToString();
                frm.Codigo_Registro = dtgVehiculos.CurrentRow.Cells[1].Value.ToString();
                frm.Dueño = dtgVehiculos.CurrentRow.Cells[6].Value.ToString();//OWNNERS NAME
                frm.ShowDialog();
                ActualizarVehiculos();
            }
            else
            {
                MessageBox.Show("Este Vehiculo ya se encuentra fuera de la playa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region EMPLEADO
        private void btnSalirEmpleado_Click(object sender, EventArgs e)
        {
            panelEmpleados.Visible = false;
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            frmNuevoEmpleado frm = new frmNuevoEmpleado();
            frm.ShowDialog();
            ActualizarEmpleados();
        }

        private void btnInactivarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                string cod = dtgEmpleados.CurrentRow.Cells[0].Value.ToString();
                DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar a este empleado?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(dr == DialogResult.Yes)
                {
                    //if (objEmpleadoBL.InactivarEmpleado(cod, false) == true)
                    //{
                    //    MessageBox.Show("Empleado inactivado con exito", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                    if (objEmpleadoBL.EliminarEmpleado(cod) == true)
                    {
                        MessageBox.Show("Empleado eliminado con exito", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarEmpleados();
                    }
                }
                //else
                //{
                //    return;
                //}
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            frmActualizarEmpleado frm = new frmActualizarEmpleado();
            frm.ecodigo = dtgEmpleados.CurrentRow.Cells[0].Value.ToString();
            frm.ShowDialog();
            ActualizarEmpleados();
        }
        #endregion

        #region CONSULTAS CLIENTE
        private void entradasfechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrosCliente frm = new frmRegistrosCliente();
            frm.ShowDialog();
        }
        #endregion

        #region CONSULTAS VEHICULO
        private void totalIngresosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TotalIngresos frm = new TotalIngresos();
            frm.ShowDialog();
        }

        private void vehiculosIngresadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVehiculosIngresados frm = new frmVehiculosIngresados();
            frm.ShowDialog();
        }
        #endregion

        #region CONSULTAAS EMPLEADO
        #endregion
    }
}
