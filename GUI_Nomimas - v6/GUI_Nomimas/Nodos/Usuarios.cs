using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Nomimas.Nodos
{
    class Usuarios
    {
        /// <summary>
        /// Atributos del nodo usuarios
        /// </summary>
        private int codigoUsuario;
        private string numeroCedula;
        private string nombreUsuario;
        private string contraseniaUsuario;
        private string privilegioUsuario;
        /// <summary>
        /// Metodo get set de codigo de usuario
        /// </summary>
        public int CodigoUsuario { get; set; }
        /// <summary>
        /// Metodo get set de Numero de cedula
        /// </summary>        
        public string NumeroCedula { get; set; }
        /// <summary>
        /// Metodo get set de nombre
        /// </summary>
        public string NombreUsuario { get; set; }
        /// <summary>
        /// Metodod get set de contrasenia
        /// </summary>
        public string ContraseniaUsuario { get; set; }
        /// <summary>
        /// Metodo get set de privilegio
        /// </summary>
        public string PrivilegioUsuario { get; set;}
        /// <summary>
        /// Metodo constructor de la clase Usuarios
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="cedula"></param>
        /// <param name="nombre"></param>
        /// <param name="contrasenia"></param>
        /// <param name="privilegio"></param>
        public Usuarios(int codigo,string cedula, string nombre,string contrasenia,string privilegio) {
            this.codigoUsuario = codigo;
            this.numeroCedula = cedula;
            this.nombreUsuario = nombre;
            this.contraseniaUsuario = contrasenia;
            this.privilegioUsuario = privilegio;
        }
    }
}
