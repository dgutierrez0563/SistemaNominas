using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Nomimas.Nodos
{
    class Empleados
    {
        /// <summary>
        /// Atributos de la clase para el manejo del nodo
        /// </summary>
        private int codigoEmpleado;
        private string cedulaEmpleado;
        private string nombreEmpleado;
        private string apellidosEmpleado;
        private string fechaNace;
        private string fechaIngreso;
        private int telefonoEmpleado;
        private string emailEmpleado;
        private string direccionEmpleado;
        private string generoEmpleado;
        private string estadoCivil;
        private string paisEmpleado;
        private string profesionEmpleado;
        private int puesto;
        private int departamento;
        private string comentariosEmpleado;
        /// <summary>
        /// Metodo get set de codigo empleado
        /// </summary>
        public int CodigoEmpleado { get; set; }
        /// <summary>
        /// Metodo get set de cedula
        /// </summary>
        public int CedulaEmpleado { get; set; }
        /// <summary>
        /// Metodo get set de nombre
        /// </summary>
        public string NombreEmpleado { get; set; }
        /// <summary>
        /// Metodo get set de apellidos
        /// </summary>
        public string ApellidosEmpleado { get; set; }
        /// <summary>
        /// Metodo get set de fecha nacimiento
        /// </summary>
        public string FechaNace { get; set; }
        /// <summary>
        /// Metodo get set de fecha de ingreso
        /// </summary>
        public string FechaIngreso { get; set; }
        /// <summary>
        /// Metodo get set de telefono
        /// </summary>
        public int TelefonoEmpleado { get; set; }
        /// <summary>
        /// Metodo get set de email
        /// </summary>
        public string EmailEmpleado { get; set; }
        /// <summary>
        /// Metodo get set de direccion
        /// </summary>
        public string DireccionEmpleado { get; set; }
        /// <summary>
        /// Metodo get set de genero
        /// </summary>
        public string GeneroEmpleado { get; set; }
        /// <summary>
        /// Metodo get set de etado civil
        /// </summary>
        public string EstadoCivil { get; set; }
        /// <summary>
        /// Metodo get set de pais
        /// </summary>
        public string PaisEmpleado { get; set; }
        /// <summary>
        /// Metodo get set de profesion
        /// </summary>
        public string ProfesionEmpleado { get; set; }
        /// <summary>
        /// Metodo get set de puesto
        /// </summary>
        public string Puesto { get; set; }
        /// <summary>
        /// Metodo get set de departamento
        /// </summary>
        public string Departamento { get; set; }
        /// <summary>
        /// Metodo get set de comentario
        /// </summary>
        public string ComentariosEmpleado { get; set; }
        /// <summary>
        /// Constructor de la clase empleados
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="cedula"></param>
        /// <param name="nombre"></param>
        /// <param name="apellidos"></param>
        /// <param name="fechaNace"></param>
        /// <param name="fechaIngreso"></param>
        /// <param name="telefono"></param>
        /// <param name="email"></param>
        /// <param name="direccion"></param>
        /// <param name="genero"></param>
        /// <param name="estadoCivil"></param>
        /// <param name="pais"></param>
        /// <param name="profesion"></param>
        /// <param name="puesto"></param>
        /// <param name="departamento"></param>
        /// <param name="detalle"></param>
        public Empleados(int codigo,string cedula,string nombre,string apellidos,string fechaNace,string fechaIngreso,int telefono,string email,string direccion,string genero,string estadoCivil,string pais, string profesion,int puesto, int departamento, string detalle) {
            this.codigoEmpleado = codigo;
            this.cedulaEmpleado = cedula;
            this.nombreEmpleado = nombre;
            this.apellidosEmpleado = apellidos;
            this.fechaNace = fechaNace;
            this.fechaIngreso = fechaIngreso;
            this.telefonoEmpleado = telefono;
            this.emailEmpleado = email;
            this.direccionEmpleado = direccion;
            this.generoEmpleado = genero;
            this.estadoCivil = estadoCivil;
            this.paisEmpleado = pais;
            this.profesionEmpleado = profesion;
            this.puesto = puesto;
            this.departamento = departamento;
            this.comentariosEmpleado = detalle;
        }
    }
}
