using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
