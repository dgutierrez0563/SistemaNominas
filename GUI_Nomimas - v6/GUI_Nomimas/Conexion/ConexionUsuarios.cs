using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GUI_Nomimas.Conexion
{
    class ConexionUsuarios
    {
        /// <summary>
        /// Objeto sentencia de la clase conexion primaria database
        /// </summary>
        Conecction_to_DB conexion = new Conecction_to_DB();
        
        /// <summary>
        /// Metodo que realiza el registro de datos en las tabla usuarios
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="cedula"></param>
        /// <param name="nombre"></param>
        /// <param name="contrasenia"></param>
        /// <param name="privilegio"></param>
        public void insertarUsuarios(int codigo,string cedula,string nombre,string contrasenia,string privilegio)
        {
            SqlConnection conectar = conexion.Conectando();
            try
            {
                conectar.Open();
                SqlCommand depart = new SqlCommand("INSERT INTO usuarios VALUES(@codigoUsuario,@cedulaUsuario,@nombreUsuario,@contrasenia,@privilegio)", conectar);
                depart.Parameters.Add("@codigoUsuario", codigo);
                depart.Parameters.Add("@cedulaUsuario", cedula);
                depart.Parameters.Add("@nombreUsuario", nombre);
                depart.Parameters.Add("@contrasenia", contrasenia);
                depart.Parameters.Add("@privilegio", privilegio);
                depart.ExecuteNonQuery();
                conectar.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error de Conexión", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new ArgumentException("Error de Conexión\n", e);
            }
        }
        /// <summary>
        /// Metodo que realiza la actualizacion de datos en las tabla usuarios
        /// </summary>
        /// <param name="codigoViejo"></param>
        /// <param name="codigo"></param>
        /// <param name="cedula"></param>
        /// <param name="nombre"></param>
        /// <param name="contrasenia"></param>
        /// <param name="privilegio"></param>
        public void actualizarUsuarios(int codigoViejo,int codigo, string cedula, string nombre, string contrasenia, string privilegio)
        {
            SqlConnection conectar = conexion.Conectando();
            try
            {
                conectar.Open();
                SqlCommand depart = new SqlCommand("UPDATE usuarios SET codigo=@codigoUsuario,cedula=@cedulaUsuario,nombre=@nombreUsuario,contrasenia=@contrasenia,privilegio=@privilegio WHERE codigoUsuario=" + codigoViejo, conectar);
                depart.Parameters.Add("@codigoUsuario", codigo);
                depart.Parameters.Add("@cedulaUsuario", cedula);
                depart.Parameters.Add("@nombreUsuario", nombre);
                depart.Parameters.Add("@contrasenia", contrasenia);
                depart.Parameters.Add("@privilegio", privilegio);
                depart.ExecuteNonQuery();
                conectar.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error de Conexión", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new ArgumentException("Error de Conexión\n", e);
            }
        }
        /// <summary>
        /// Metodo que realiza la eliminacion de datos en las tabla usuarios
        /// </summary>
        /// <param name="codigo"></param>
        public void eliminarUsuarios(int codigo)
        {
            SqlConnection conectar = conexion.Conectando();
            try
            {
                conectar.Open();
                SqlCommand depart = new SqlCommand("DELETE FROM usuarios WHERE codigo=@codigoUsuario", conectar);
                depart.Parameters.Add("@codigoUsuario", codigo);
                depart.ExecuteNonQuery();
                conectar.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error de Conexión", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new ArgumentException("Error de Conexion\n", e);
            }
        }
    }
}
