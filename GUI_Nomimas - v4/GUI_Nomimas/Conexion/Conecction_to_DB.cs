using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Nomimas.Conexion
{
    class Conecction_to_DB
    {
        /// <summary>
        /// Metodo return para la coneccion al server
        /// </summary>
        /// <returns></returns>
        public SqlConnection Conectando() {
            SqlConnection conecta = new SqlConnection("Data Source=WSLLIVAN03\\SQLEXPRESS;Initial Catalog=sistemaNominas;Integrated Security=true");
            return conecta;
        }
    }
}
