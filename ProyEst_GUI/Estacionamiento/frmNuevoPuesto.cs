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
    public partial class frmNuevoPuesto : Form
    {
        //PuestoBL objPuestoBL = new PuestoBL();

        public DataTable dt { get; set; }//DATATABLE FROM THE DATABASE (ON FTRST LAUNCH)
        public DataTable dtToAdd { get; set; }//DATATABLE TO BE INSERTED TO THE DATABASE (ITS ROWS TO THE PUESTOS TABLE)

        string nuevoID;

        public frmNuevoPuesto()
        {
            InitializeComponent();
            //SINCE WE ARE USING FORM PROPERTIES (DECLARED ABOVE) IT IS BETTER TO USE THE FORM_LOAD EVENT INSTEAD OF THE CONSTRUCTOR
        }

        private void frmNuevoPuesto_Load(object sender, EventArgs e)
        {

            if (dtToAdd == null)//(!dtToAdd.IsInitialized)//CHECK WHETHER THE DATATABLE WAS INITIALIZED OR NOT
            {
                dtToAdd = new DataTable("NUEVOS_PUESTOS");//INITIALIZATION, IT CANNOT BE NULL SINCE WE CHECK IN THE DATABASE IF IT HAS ROWS OR IF IT DOESNT
                dtToAdd.Columns.Add(new DataColumn("ID_PUESTO", typeof(string)));
                dtToAdd.Columns.Add(new DataColumn("NIVEL", typeof(int)));
                dtToAdd.Columns.Add(new DataColumn("BLOQUE", typeof(string)));
                dtToAdd.Columns.Add(new DataColumn("ESTADO_DISPONIBILIDAD", typeof(bool)));
            }

            nuevoID = "PUE" + (int.Parse(dt.Rows[dt.Rows.Count - 1]["ID_PUESTO"].ToString().Substring(3)) + 1001).ToString().Substring(1);//WE GET THE LAST ROW OF THE DATATABLE AND INCREMENT ITS NUMBER PART BY ONE SUBSTRING (STARTING BY INDEX 3) THEN INCREMENT THEN CONCATENATE TO "PUE"
            lblCodigo.Text = nuevoID;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cbxBloque.Text))
            {
                MessageBox.Show("Bloque no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataRow dr = dt.NewRow();//WE DECALRE A NEW ROW TO BE ADDED WITH THE INSERTED VALUES
                dr[0] = nuevoID;
                dr[1] = nudNivel.Value;
                dr[2] = cbxBloque.Text;
                dr[3] = "DISPONIBLE";
                                       //MessageBox.Show("ROW " + dr[0]);
                dt.Rows.Add(dr);//WE ADD THE ROWS TO THE DATATABLE THAT IS GOING TO BE USED IN THE PARENT FORM

                //dr[3] = false;//MODIFY THE LAST ROW AGAIN SINCE ITS DATABASE TYPE IS BIT WE NEED IT TO BE BOOLEAN
                DataRow drToAdd = dtToAdd.NewRow();//WE CREATE A DIFFERENT ROW SINCE THE SAME ROW CANNOT BE ASSIGNED TWICE
                drToAdd[0] = nuevoID;
                drToAdd[1] = nudNivel.Value;
                drToAdd[2] = cbxBloque.Text;
                drToAdd[3] = true;//IT IS ALWAYS AVAILABLE WHEN IT IS ADDED
                dtToAdd.Rows.Add(drToAdd);

                this.Close();
            }
        }
    }
}
