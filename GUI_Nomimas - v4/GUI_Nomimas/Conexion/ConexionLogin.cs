using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Nomimas.Conexion
{
    class ConexionLogin
    {
        public void validarLogin(string user, string pass) {
            Conecction_to_DB conexion = new Conecction_to_DB();
            //SqlConnection conectar = conexion.Conectando();
            try
            {
                using (SqlConnection conectar = conexion.Conectando())
                {
                    var sql = "SELECT* FROM usuarios WHERE codigoUsuario='" + user + "' AND contrasenia'" + pass + "'";
                    SqlCommand com = new SqlCommand(sql, conectar);
                    conectar.Open();
                    var dr = com.ExecuteReader();

                    if (dr.HasRows == true)
                    {
                        MDI_Principal principal = new MDI_Principal();
                        principal.Show();
                        Form1_Login log = new Form1_Login();
                        log.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error de Conexión\n\t", ex);
            }
        }
    }
}
