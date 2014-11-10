using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROCON.CONTROLADOR.SESION;

namespace PROCON.VISTA.SESION
{
    public partial class claveConfigurarConexion : Form
    {
        public claveConfigurarConexion()
        {
            try
            {
                InitializeComponent();
                this.Text = "CAMBIO DE CONEXION " + sesion.NOMBREAPLICACION + " FORMULARIO PRINCIPAL";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        private void claveConfigurarConexion_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
            Application.Exit();
                        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

                                    }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), sesion.NOMBREAPLICACION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.txtPassword.Text == "")
                {
                    MessageBox.Show("Ingrese Password", "VERIFIQUE LA INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.txtPassword.Focus();
                }
                else
                {
                    if (this.txtPassword.Text == "4dm1n")
                    {
                        this.Hide();
                        configurarConexion confgi = new configurarConexion();
                        confgi.Show();

                    }
                    else MessageBox.Show("Contraseña incorrecta", "VERIFIQUE CLAVE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error encontrado: " + ex.ToString(), "Fallo en el Sistema");
            }
        }
    }
}
