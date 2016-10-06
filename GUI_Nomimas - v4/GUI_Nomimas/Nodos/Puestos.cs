using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Nomimas.Nodos
{
    class Puestos
    {
        /// <summary>
        /// Atributos de la clase Puestos
        /// </summary>
        /// 
        private int codigoPuesto;
        private string nombrePuesto;
        private string especialidadPuesto;
        private string tipoTrabajoPuesto;
        private decimal salarioPuesto;
        private decimal valorHoraPuesto;
        private string tipoNominaPuesto;
        private string departamentoPuesto;       
        private string comentariosPuesto;
        /// <summary>
        /// Metodo get set de codigo del puesto
        /// </summary>
        private int CodigoPuesto { get; set; }
        /// <summary>
        /// Metodo get set de nombre del puesto
        /// </summary>
        public string NombrePuesto { get; set; }
        /// <summary>
        /// Metodo get set de especialidad del puesto
        /// </summary>
        public string EspecialidadPuesto { get; set; }
        /// <summary>
        /// Metodo get set del tipo de trabajo
        /// </summary>
        public string TipoTrabajo { get; set; }
        /// <summary>
        /// Metodo get set de salario puesto
        /// </summary>
        public decimal SalarioPuesto { get; set; }
        /// <summary>
        /// Metodo get set de valor hora
        /// </summary>
        public decimal ValorHoraPuesto { get; set; }
        /// <summary>
        /// Metodo get set del tipo de nomina
        /// </summary>
        public string TipoNominaPuesto { get; set; }
        /// <summary>
        /// Metodo get set de nombre del departamento al que pertenece
        /// </summary>
        public string DepartamentoPuesto { get; set; }
        /// <summary>
        /// Metodo get set de comentario puesto
        /// </summary>
        public string ComentarioPuesto { get; set; }
        /// <summary>
        /// Metodo constructor de la clase nodo de puesto
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="nombre"></param>
        /// <param name="especialidad"></param>
        /// <param name="tipoTrabajo"></param>
        /// <param name="salario"></param>
        /// <param name="valorHora"></param>
        /// <param name="tipoNomina"></param>
        /// <param name="departamento"></param>
        /// <param name="comentario"></param>
        public Puestos(int codigo, string nombre,string especialidad, string tipoTrabajo, decimal salario, decimal valorHora, string tipoNomina, string departamento, string comentario) {
            this.codigoPuesto = codigo;
            this.nombrePuesto = nombre;
            this.especialidadPuesto = especialidad;
            this.tipoTrabajoPuesto = tipoTrabajo;
            this.salarioPuesto = salario;
            this.valorHoraPuesto = valorHora;
            this.tipoNominaPuesto = tipoNomina;
            this.departamentoPuesto = departamento;
            this.comentariosPuesto = comentario;
        }
    }
}
