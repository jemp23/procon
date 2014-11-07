using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROCON.CONTROLADOR.USUARIO;

namespace PROCON.VISTA.SESION
{
    public partial class acceso : Form
    {

        public acceso()
        {
            InitializeComponent();
        }

        private void tabularEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //datos del formulario
            string Usuario = this.txtUsuario.Text;
            string Password = this.txtPassword.Text;

            try
            {
                //instancio la clase usuario
                controladorUsuario usuario = new controladorUsuario();

                //consulto las credenciales del usario y guardo el resultado
                int resultado = usuario.verificarUsuario(Usuario, Password);

                if (resultado == 0)
                {
                    MessageBox.Show("USUARIO O CONTRASEÑAS INCORRECTO", "VERIFIQUE LA INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                       principal Principal = new principal();
                        Principal.Show();
                        this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            claveConfigurarConexion confgi = new claveConfigurarConexion();
            confgi.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



    }
}

