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
    public partial class Form1_Login : Form
    {
        //public int progreso = 50;
        public Form1_Login()
        {
            InitializeComponent();
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Metodo boton de cancelar la sesion y cerrar el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando Sistema","Mensaje del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);            
            Application.Exit();
        }
        /// <summary>
        /// Metodo de sesion de ususario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Enter_Click(object sender, EventArgs e)
        {
            if (!txt_UserLogin.Text.Equals("") & !txt_PassLogin.Text.Equals("")) {
                Conexion.ConexionLogin validar = new Conexion.ConexionLogin();
                string user = Convert.ToString(txt_UserLogin.Text);
                string pass = Convert.ToString(txt_PassLogin.Text);
                validar.validarLogin(user,pass);             
            } else {
                MessageBox.Show("Completar campos vacios","Error de Sesion",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
        }
        private void progressBarLogin_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Login_Load(object sender, EventArgs e)
        {
            //Vacio
        }
    }
}
