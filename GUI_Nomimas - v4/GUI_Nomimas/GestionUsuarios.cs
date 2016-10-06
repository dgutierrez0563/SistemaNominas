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
    public partial class GestionUsuarios : Form
    {
        public GestionUsuarios()
        {
            InitializeComponent();
            radioBtn_EdisionUsuarioNormal.Enabled = true;
            radioBtn_NuevoUsuarioNormal.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_EliminarCancelar_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_NuevoAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (!txt_NuevoCodigoUsuario.Equals("") & !txt_NuevaCedulaUsuario.Equals("") & !txt_NuevoNombreUsuario.Equals(""))
            {
                Conexion.ConexionDepartamentos departamentos = new Conexion.ConexionDepartamentos();
                if (txt_NuevoPassUsuario.Text.Equals(txt_NuevoRepitePassUsuario.Text)) {
                    if (radioBtn_NuevoAdminUsuario.Enabled == true)
                    {
                        try
                        {
                            int codigo = Convert.ToInt32(txt_NuevoCodigoUsuario.Text);
                            string cedula = txt_NuevaCedulaUsuario.Text;
                            string nombre = txt_NuevoNombreUsuario.Text;
                            string contrasenia = txt_NuevoPassUsuario.Text;
                            string privilegio = "Administrador";
                            departamentos.insertarDepartamentos(codigo,cedula, nombre, contrasenia,privilegio);
                            MessageBox.Show("¡Información Registrada con Exito!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarCamposNuevoDepartamento();
                        }
                        catch (Exception ex)
                        {
                            throw new ArgumentException("Ha ocurrido un Error en el Registro\n\n", ex);
                        }
                    }
                    else {

                    }
                }
                try
                {
                    int codigo = Convert.ToInt32(txt_NuevoCodigoDepa.Text);
                    string nombre = txt_NuevoNombreDepa.Text;
                    string detalle = txt_NuevoDetallesDepa.Text;
                    departamentos.insertarDepartamentos(codigo, nombre, detalle);
                    MessageBox.Show("¡Información Registrada con Exito!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCamposNuevoDepartamento();
                }
                catch (Exception ex)
                {
                    throw new ArgumentException("Ha ocurrido un Error en el Registro\n\n", ex);
                }
            }
            else
            {
                MessageBox.Show("¡Información No Registrada!\nComplete los campos obligatorios", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
