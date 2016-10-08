using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GUI_Nomimas.Conexion
{
    class ConexionDepartamentos
    {
        /// <summary>
        /// Objeto sentencia de la clase conexion primaria database
        /// </summary>
        Conecction_to_DB conexion = new Conecction_to_DB();
        /// <summary>
        /// Metodo que realiza el registro de datos en las tabla departamentos
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="nombre"></param>
        /// <param name="detalle"></param>
        public void insertarDepartamentos(int codigo, string nombre, string detalle) {
            SqlConnection conectar = conexion.Conectando();            
            try
            {
                conectar.Open();
                SqlCommand depart = new SqlCommand("INSERT INTO departamentos VALUES(@codigoDepartamento,@nombreDepartamento,@detalleDepartamento)",conectar);
                depart.Parameters.Add("@codigoDepartamento",codigo);
                depart.Parameters.Add("@nombreDepartamento", nombre);
                depart.Parameters.Add("@detalleDepartamento", detalle);
                depart.ExecuteNonQuery();
                conectar.Close();
            }
            catch (Exception e) {
                MessageBox.Show("Error de Conexión", "Mensaje del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw new ArgumentException("Error de Conexión\n", e);
            }
        }
        /// <summary>
        /// Metodo que realiza la actualizacion de datos en las tabla departamentos
        /// </summary>
        /// <param name="codigoViego"></param>
        /// <param name="codigo"></param>
        /// <param name="nombre"></param>
        /// <param name="detalle"></param>
        public void actualizarDepartamentos(int codigoViego,int codigo, string nombre, string detalle) {
            SqlConnection conectar = conexion.Conectando();            
            try
            { 
                conectar.Open();
                SqlCommand depart = new SqlCommand("UPDATE departamentos SET codigo=@codigoDepartamento,nombre=@nombreDepartamento,detalle=@detalleDepartamento WHERE codigoDepartamento=" + codigo, conectar);
                depart.Parameters.Add("@codigoDepartamento", codigo);
                depart.Parameters.Add("@nombreDepartamento", nombre);
                depart.Parameters.Add("@detalleDepartamento", detalle);
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
        /// Metodo que realiza la eliminacion de datos en las tabla departamentos
        /// </summary>
        /// <param name="cod"></param>
        public void eliminarDepartamentos(int codigo) {
            SqlConnection conectar = conexion.Conectando();
            try
            {
                conectar.Open();
                SqlCommand depart = new SqlCommand("DELETE FROM departamentos WHERE codigo=@codigoDepartamento", conectar);
                depart.Parameters.Add("@codigoDepartamento", codigo);
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
