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

namespace ProyEst_GUI.Estacionamiento
{
    public partial class frmEstacionamientoConf : Form
    {
        //event EventHandler NuevoPuestoClosed = new EventHandler(btn) USE A EVENT HANDLER THE HANDLE FORM CLOSED EVENT

        EstacionamientoBL objEstacionamientoBL = new EstacionamientoBL();
        PuestoBL objPuestoBL = new PuestoBL();

        DataTable dt;//TO SHOW IN GRID
        DataTable dtToAdd;//TO ADD IN THE DATABASE
        //private string usuarioactivo;
        //public string Usuarioactivo
        //{
        //    get { return usuarioactivo; }
        //    set { usuarioactivo = value; }
        //}

        public frmEstacionamientoConf()
        {
            InitializeComponent();
        }

        private void btnNuevaMarca_Click(object sender, EventArgs e)
        {
            frmNuevaMarca frm = new frmNuevaMarca();
            frm.ShowDialog();
        }

        private void frmEstacionamientoConf_Load(object sender, EventArgs e)
        {
            try
            {
                dtgPuestos.AutoGenerateColumns = false;//DISABLE THE COLUMN GENERATION WHEN DATASOURCE IS SET SINCE WE ARE USING OUR OWN FORMAT

                dt = objPuestoBL.ListarPuestos();//INITIALIZE THE DATATABLE DECLARED ABOVE TO BE ABLE TO SEND IT TO THE OTHER FORM
                dtgPuestos.DataSource = dt;
                lblCantidad.Text = dt.Rows.Count.ToString();

                mtxtTarifa.Text = objEstacionamientoBL.ListarEstacionamiento().tarifa_diaria.ToString();//CONVERT TO STRING SINCE IT IS A DECIMAL VALUE
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            switch (btn.Name)
            {
                case "btnGuardar":
                    if (objEstacionamientoBL.ActualizarEstacionamiento(decimal.Parse(mtxtTarifa.Text.Substring(2)), dtToAdd))
                    {//IT TAKES ACCOUNT OF THE INDEX AS WELL SO ITS TO TO AVOID 0 AND 1
                        MessageBox.Show("Cambios Realizados con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    break;
                case "btnSalir":
                    this.Close();
                    break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //LETS MAKE THIS WITH 2 DATASET ONE FOR INSERTIONS INTO THE PUESTOS TABLE AND ANOTHER ONE FOR SHOWING NEW PUESTOS INTO THE CURRENT FORM DATAGRID
            frmNuevoPuesto frm = new frmNuevoPuesto();
            frm.dt = dt;//SEND CURRENT DATATABLE TO THE NUEVO PUESTO FORM EACH TIME THE THIS FORM IS OPENED
            frm.dtToAdd = this.dtToAdd;
            frm.FormClosed += (s, e1) => { dtgPuestos.DataSource = frm.dt; dt = frm.dt; dtToAdd = frm.dtToAdd; };//AFTER IT'S CLOSED CHANGE THE GRID DATASOURCE TO MODIFIED DATATABLE AND ASSIGN IT TO CURRRENT DATATABLE, (TO BE ABLE TO SEND IT BACK FOR MORE SPOTS)
            frm.ShowDialog();                                                                                    //ALSO THE WE ASSIGN THE DATATABLE TO BE ADDED IN THE DATABASE
            //ARE OUR DATATABLE ORBJECTS COPIED BY VAL OR REF? WE'LL HAVE TO FIND OUT IF YES OR IF NO THEN WHY
            //IT MIGHT MAKE SENSE TO NO GET ERRORS FOR COPYING OBJECTS(SINCE IT IS SUPPOSED TO BE BY REF)
            //CAUSE WE ARE CLOSING THE DIALOG EACH TIME AND THE ONLY ONE REMAINING IS THE REFERENCE SO THAT BECOMES THE MAIN OBJECT AND SO ON I GUESS
            //WOULD IT MAKE SENSE TO ASSIGN IT EACH TIME SINCE IT IS REFERENCING THE ONE THAT WAS LEFT THEN IT IS MODIFYING IT, IS IT NOT?
        }
    }
}
