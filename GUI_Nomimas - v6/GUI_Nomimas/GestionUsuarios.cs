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
        /// <summary>
        /// Metodo boton que envia los datos al metodo de registro de usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NuevoAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (!txt_NuevoCodigoUsuario.Equals("") & !txt_NuevaCedulaUsuario.Equals("") & !txt_NuevoNombreUsuario.Equals("") & !txt_NuevoPassUsuario.Equals("") & !txt_NuevoRepitePassUsuario.Equals(""))
            {
                Conexion.ConexionUsuarios usuarios = new Conexion.ConexionUsuarios();
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
                            usuarios.insertarUsuarios(codigo,cedula, nombre, contrasenia,privilegio);
                            MessageBox.Show("¡Información Registrada con Exito!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarCamposNuevoUsuarios();
                        }
                        catch (Exception ex)
                        {
                            throw new ArgumentException("Ha ocurrido un Error en el Registro\n\n", ex);
                        }
                    }
                    else {
                        try
                        {
                            int codigo = Convert.ToInt32(txt_NuevoCodigoUsuario.Text);
                            string cedula = txt_NuevaCedulaUsuario.Text;
                            string nombre = txt_NuevoNombreUsuario.Text;
                            string contrasenia = txt_NuevoPassUsuario.Text;
                            string privilegio = "Usuario";
                            usuarios.insertarUsuarios(codigo, cedula, nombre, contrasenia, privilegio);
                            MessageBox.Show("¡Información Registrada con Exito!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarCamposNuevoUsuarios();
                        }
                        catch (Exception ex)
                        {
                            throw new ArgumentException("Ha ocurrido un Error en el Registro\n\n", ex);
                        }
                    }
                }               
            }
            else
            {
                MessageBox.Show("¡Información No Registrada!\nComplete los campos obligatorios", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
        /// <summary>
        /// Metodo que limpia los campos del registro de usuarios
        /// </summary>
        public void limpiarCamposNuevoUsuarios() {
            txt_NuevoCodigoUsuario.Clear();
            txt_NuevaCedulaUsuario.Clear();
            txt_NuevoNombreUsuario.Clear();
            txt_NuevoPassUsuario.Clear();
            txt_NuevoRepitePassUsuario.Clear();
        }
        /// <summary>
        /// Metodo que limpia los campos de edicion de usuarios
        /// </summary>
        public void limpiarCamposEdicionUsuarios() {
            cmb_EditarBuscarCodigoUsuario.Text = "";
            txt_EditarNuevoCodigoUsuario.Clear();
            txt_EditarCedulaUsuario.Clear();
            txt_EditarNombreUsuario.Clear();
            txt_EditarPassUsuario.Clear();
            txt_EditarRepitPassUsuario.Clear();
        }
        /// <summary>
        /// Metodo que llama a limpiarCamposNuevoUsuarios()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NuevoCancelarUsuario_Click(object sender, EventArgs e)
        {
            limpiarCamposNuevoUsuarios();
        }
        /// <summary>
        /// Metodo boton que envia los datos al metodo de actualizacion de usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EdisionGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (!txt_EditarNuevoCodigoUsuario.Equals("") & !txt_EditarCedulaUsuario.Equals("") & !txt_EditarNombreUsuario.Equals("") & !txt_EditarPassUsuario.Equals("") & !txt_EditarRepitPassUsuario.Equals(""))
            {
                Conexion.ConexionUsuarios usuarios = new Conexion.ConexionUsuarios();
                if (txt_EditarPassUsuario.Text.Equals(txt_EditarRepitPassUsuario.Text))
                {
                    if (radioBtn_EdisionAdminUsuario.Enabled == true)
                    {
                        try
                        {
                            int codigoViejo = Convert.ToInt32(cmb_EditarBuscarCodigoUsuario.Text);
                            int codigo = Convert.ToInt32(txt_EditarNuevoCodigoUsuario.Text);
                            string cedula = txt_EditarCedulaUsuario.Text;
                            string nombre = txt_EditarNombreUsuario.Text;
                            string contrasenia = txt_EditarPassUsuario.Text;
                            string privilegio = "Administrador";
                            usuarios.actualizarUsuarios(codigoViejo,codigo, cedula, nombre, contrasenia, privilegio);
                            MessageBox.Show("¡Información Actualizada con Exito!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarCamposEdicionUsuarios();
                        }
                        catch (Exception ex)
                        {
                            throw new ArgumentException("Ha ocurrido un Error en la Actualizacion\n\n", ex);
                        }
                    }
                    else
                    {
                        try
                        {
                            int codigoViejo = Convert.ToInt32(cmb_EditarBuscarCodigoUsuario.Text);
                            int codigo = Convert.ToInt32(txt_EditarNuevoCodigoUsuario.Text);
                            string cedula = txt_EditarCedulaUsuario.Text;
                            string nombre = txt_EditarNombreUsuario.Text;
                            string contrasenia = txt_EditarPassUsuario.Text;
                            string privilegio = "Administrador";
                            usuarios.actualizarUsuarios(codigoViejo, codigo, cedula, nombre, contrasenia, privilegio);
                            MessageBox.Show("¡Información Actualizada con Exito!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarCamposEdicionUsuarios();
                        }
                        catch (Exception ex)
                        {
                            throw new ArgumentException("Ha ocurrido un Error en la Actualizacion\n\n", ex);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("¡Información No Registrada!\nComplete los campos obligatorios", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
