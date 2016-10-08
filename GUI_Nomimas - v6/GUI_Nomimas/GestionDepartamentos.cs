using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GUI_Nomimas
{
    public partial class GestionDepartamentos : Form
    {
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public GestionDepartamentos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo vacio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabPage2_Click(object sender, EventArgs e)
        {
            //Vacio
        }
        /// <summary>
        /// Metodo boton quenvia los datos al metodo de registro de departamentos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NuevoAgregarDepa_Click(object sender, EventArgs e)
        {
            if (!txt_NuevoCodigoDepa.Equals("") & !txt_NuevoNombreDepa.Equals("") & !txt_NuevoDetallesDepa.Equals("")) {
                Conexion.ConexionDepartamentos departamentos = new Conexion.ConexionDepartamentos();
                try {
                    int codigo = Convert.ToInt32(txt_NuevoCodigoDepa.Text);
                    string nombre = txt_NuevoNombreDepa.Text;
                    string detalle = txt_NuevoDetallesDepa.Text;                    
                    departamentos.insertarDepartamentos(codigo,nombre,detalle);
                    MessageBox.Show("¡Información Registrada con Exito!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCamposNuevoDepartamento();
                } catch (Exception ex) {
                    throw new ArgumentException("Ha ocurrido un Error en el Registro\n\n", ex);
                }
            } else {
                MessageBox.Show("¡Información No Registrada!\nComplete los campos obligatorios", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Metodo boton quenvia los datos al metodo de actualizacion de departamentos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EdisionGuardarDepa_Click(object sender, EventArgs e)
        {
            if (!cmb_EditarBuscarCodigoDepa.Equals("") & !txt_EditarNuevoCodigo.Equals("") & !txt_EditarNombreDepa.Equals("") & !txt_EdisionDetallesDepa.Equals(""))
            {
                Conexion.ConexionDepartamentos departamentos = new Conexion.ConexionDepartamentos();
                try
                {
                    int codigoViejo = Convert.ToInt32(cmb_EditarBuscarCodigoDepa.Text);
                    int codigo = Convert.ToInt32(txt_EditarNuevoCodigo.Text);
                    string nombre = txt_EditarNombreDepa.Text;
                    string detalle = txt_EdisionDetallesDepa.Text;
                    departamentos.actualizarDepartamentos(codigoViejo, codigo, nombre, detalle);
                    MessageBox.Show("¡Información Actualizada con Exito!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCamposEditarDepartamento();
                }
                catch (Exception ex)
                {
                    throw new ArgumentException("Ha ocurrido un Error en el la Actualización\n\n", ex);
                }
            }
            else
            {
                MessageBox.Show("¡Información No Actualizada!\nComplete los campos obligatorios", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Metodo boton que llama al metodo limpiarCamposNuevoDepartamento();
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NuevoCancelarDepa_Click(object sender, EventArgs e)
        {
            limpiarCamposNuevoDepartamento();
        }
        /// <summary>
        /// Metodo que limpia los campos del registro de departamentos
        /// </summary>
        public void limpiarCamposNuevoDepartamento() {
            txt_NuevoCodigoDepa.Clear();
            txt_NuevoNombreDepa.Clear();
            txt_NuevoDetallesDepa.Clear();
        }
        /// <summary>
        /// Metodo que devuelve al MDI principla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NuevoVolverPrincipalDepa_Click(object sender, EventArgs e)
        {
            this.Dispose();           
        }
        /// <summary>
        /// Metodo boton que envia al metodo limpieza de campos de edicion de departamentos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EdisionCancelarDepa_Click(object sender, EventArgs e)
        {
            limpiarCamposEditarDepartamento();
        }
        /// <summary>
        /// Metodo que limpia los campos de edicion del departamento
        /// </summary>
        public void limpiarCamposEditarDepartamento()
        {
            cmb_EditarBuscarCodigoDepa.Text = "";
            txt_EditarNuevoCodigo.Clear();
            txt_EditarNombreDepa.Clear();
            txt_EdisionDetallesDepa.Clear();
        }
        /// <summary>
        /// Metodo que regresa al MDI principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EdisionVolverPrincipalDepa_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /// <summary>
        /// Metodo Vacio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GestionDepartamentos_Load(object sender, EventArgs e)
        {
            //Vacio
        }
        /// <summary>
        /// Metodo que carga datos para el combobox de Edicion de departamentos
        /// </summary>
        public void cargarComboBoxEditarDepartamentos() {
            Conexion.Conecction_to_DB conecta = new Conexion.Conecction_to_DB();
            DataSet dateset = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT codigoDepartamento FROM departamentos", conecta.Conectando());
            dataAdapter.Fill(dateset, "departamentos");
            cmb_EditarBuscarCodigoDepa.DataSource = dateset.Tables[0].DefaultView;
            cmb_EditarBuscarCodigoDepa.ValueMember = "codigoDepartamento";
        }
        /// <summary>
        /// Metodo que carga datos para el combobox de Registro de departamentos
        /// </summary>
        public void cargarComboBoxRegistroDepartamentos()
        {
            Conexion.Conecction_to_DB conecta = new Conexion.Conecction_to_DB();
            DataSet dateset = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT codigoDepartamento FROM departamentos", conecta.Conectando());
            dataAdapter.Fill(dateset, "departamentos");
            cmb_EditarBuscarCodigoDepa.DataSource = dateset.Tables[0].DefaultView;
            cmb_EditarBuscarCodigoDepa.ValueMember = "codigoDepartamento";
        }
        /// <summary>
        /// Metodo boton quenvia los datos al metodo de eliminacion de departamentos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EliminarEliminarDepa_Click(object sender, EventArgs e)
        {
            if (!cmb_EliminarBuscarCodigoDepa.Text.Equals(""))                
            {
                Conexion.ConexionDepartamentos departamentos = new Conexion.ConexionDepartamentos();
                int codigo = Convert.ToInt32(cmb_EliminarBuscarCodigoDepa.Text);
                departamentos.eliminarDepartamentos(codigo);
                MessageBox.Show("Empleado eliminado exitosamente", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb_EliminarBuscarCodigoDepa.Text = "";
            }
            else
            {
                MessageBox.Show("Error, no se ha eliminado el usuario", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
