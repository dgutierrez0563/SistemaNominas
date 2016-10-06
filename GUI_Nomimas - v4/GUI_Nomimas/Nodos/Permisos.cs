using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Nomimas.Nodos
{
    class Permisos
    {
        /// <summary>
        /// Atributos de la clase nodo Permisos
        /// </summary>
        private int cantidadDias;
        private string diaSalida;
        private string diaRegreso;
        private string detallePermiso;
        /// <summary>
        /// Metodo get set de dias solicitados
        /// </summary>
        public int CantidadDias { get; set; }
        /// <summary>
        /// Metodo get set de dia de salida
        /// </summary>
        public string DiaSalida { get; set; }
        /// <summary>
        /// Metodo get set de dia de regreso
        /// </summary>
        public int DiaRegreso { get; set; }
        /// <summary>
        /// Metodo get set de dia de detalle
        /// </summary>
        public string DetallePermiso { get; set; }
        /// <summary>
        /// Metodo constructor de la clase Permisos
        /// </summary>
        /// <param name="dias"></param>
        /// <param name="salida"></param>
        /// <param name="regreso"></param>
        /// <param name="detalle"></param>
        public Permisos(int dias,string salida,string regreso,string detalle) {
            this.cantidadDias = dias;
            this.diaSalida = salida;
            this.diaRegreso = regreso;
            this.detallePermiso = detalle;
        }
    }
}
