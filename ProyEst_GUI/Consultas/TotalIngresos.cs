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

namespace ProyEst_GUI.Consultas
{
    public partial class TotalIngresos : Form
    {
        RegistroBL objRegistroBL = new RegistroBL();

        public TotalIngresos()
        {
            InitializeComponent();
        }

        private void TotalIngresos_Load(object sender, EventArgs e)
        {
            try
            {
                dtgRegistros.DataSource = objRegistroBL.ListarRegistrosDetalle();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message);
            }
        }
    }
}
