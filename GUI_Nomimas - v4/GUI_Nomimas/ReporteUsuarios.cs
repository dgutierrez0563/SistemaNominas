using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Nomimas
{
    public partial class ReporteUsuarios : Form
    {
        public ReporteUsuarios()
        {
            InitializeComponent();
        }

        private void ReporteUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet_Usuarios.usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.DataSet_Usuarios.usuario);

            this.reportViewer1.RefreshReport();
            
        }
    }
}
