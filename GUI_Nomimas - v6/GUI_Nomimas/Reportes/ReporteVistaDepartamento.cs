using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace GUI_Nomimas.Reportes
{
    public partial class ReporteVistaDepartamento : Form
    {
        public ReporteVistaDepartamento()
        {
            InitializeComponent();
        }

        private void ReporteVistaDepartamento_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        public void cargarDatosReportView() {
            ReportParameter[] parameters = new ReportParameter[4];
            String date = DateTime.Now.ToLongDateString();
            String hours = DateTime.Now.ToLongTimeString();
            parameters[0]= new ReportParameter(date);
            parameters[1] = new ReportParameter(hours);

            //this..Fill(this.ds.DataTable1);
            //Pasamos el array de los parámetros al ReportViewer
            this.reportViewer1.LocalReport.SetParameters(parameters);
            this.reportViewer1.RefreshReport();
        }
    }
}
