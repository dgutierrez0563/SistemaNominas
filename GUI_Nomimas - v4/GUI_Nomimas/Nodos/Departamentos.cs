using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Nomimas.Nodos
{
    class Departamentos
    {
        /// <summary>
        /// Atributos de el nodo Departamentos
        /// </summary>
        public int codigoDepart;
        public string nombreDepart;
        public string detalleDepart;
        /// <summary>
        /// Metodo get set de codigo departamentos
        /// </summary>
        public int CodigoDepart { get; set; }
        /// <summary>
        /// Metodo get set de nombre departamentos
        /// </summary>
        public string NombreDepart { get; set; }
        /// <summary>
        /// Metodo get set de comentario departamentos
        /// </summary>
        public string DetalleDepart { get; set; }
        /// <summary>
        /// Metodo constructor de la clase nodo departamento
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="nombre"></param>
        /// <param name="detalle"></param>
        public Departamentos(int codigo,string nombre,string detalle) {
            this.codigoDepart = codigo;
            this.nombreDepart = nombre;
            this.detalleDepart = detalle;
        }
        public Departamentos() { }
    }
}
