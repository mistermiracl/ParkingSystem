using Microsoft.Reporting.WinForms;
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

namespace ProyEst_GUI.Reportes
{
    public partial class frmReportViewer : Form
    {
        public int Padre { get; set; }

        //public string strcod { get; set; }
        public DateTime fec_ini { get; set; }
        public DateTime fec_fin { get; set; }
        public ClienteBE cliente { get; set; }

        public DataView dtv { get; set; }
        public string criterio { get; set; }

        RegistroBL objRegistroBL = new RegistroBL();

        public frmReportViewer()
        {
            InitializeComponent();
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            try
            {
                switch (Padre)
                {
                    case 1:
                        reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                        reportViewer1.LocalReport.DataSources.Clear();

                        ReportDataSource rds = new ReportDataSource("DataSet1",
                            objRegistroBL.ListarRegistrosClienteFechas(cliente.id_cliente, fec_ini, fec_fin));
                        reportViewer1.LocalReport.DataSources.Add(rds);
                        reportViewer1.LocalReport.ReportEmbeddedResource = "ProyEst_GUI.Reportes.rptRegistrosCliente.rdlc";//THIS NAME CANNOT HAVE ANY MISTAKES
                        reportViewer1.LocalReport.SetParameters(new List<ReportParameter>
                        {
                            new ReportParameter("fec_ini", fec_ini.ToString()),
                            new ReportParameter("fec_fin", fec_fin.ToString()),
                            new ReportParameter("cli_nombre", cliente.nombre + cliente.apellido_p),
                            new ReportParameter("cli_codigo", cliente.id_cliente)
                        });
                        this.reportViewer1.RefreshReport();
                        reportViewer1.Focus();
                        break;

                    case 2:
                        reportViewer1.ProcessingMode = ProcessingMode.Local;
                        reportViewer1.LocalReport.DataSources.Clear();

                        ReportDataSource rds2 = new ReportDataSource("DataSet2", dtv);
                        reportViewer1.LocalReport.DataSources.Add(rds2);
                        reportViewer1.LocalReport.ReportEmbeddedResource = "ProyEst_GUI.Reportes.rptVehiculosIngresados.rdlc";
                        reportViewer1.LocalReport.SetParameters(new List<ReportParameter>
                        {
                            new ReportParameter("criterio", criterio),
                        });
                        this.reportViewer1.RefreshReport();
                        reportViewer1.Focus();
                        break;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
