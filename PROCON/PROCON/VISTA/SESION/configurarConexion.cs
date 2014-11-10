using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace PROCON.VISTA.SESION
{
    public partial class configurarConexion : Form
    {
        public configurarConexion()
        {
            InitializeComponent();
        }
        private void tabularEnter(object sender, KeyPressEventArgs e)
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
                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
            Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String server = this.txtDireccion.Text;
            String Database = this.txtBd.Text;
            String User = this.txtUsuario.Text;
            String pass = this.txtPassword.Text;
            String port = this.txtPuerto.Text.ToString();

            if (server == "" || Database == "" || User == "" || pass == "" || port == "")
            {

                MessageBox.Show("Debe llenar todos los campos", "VERIFIQUE LA INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtPassword.Focus();
                txtDireccion.Focus();
            }
            else
            {
                try
                {
                    Configuration conf = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                    ConnectionStringsSection css = conf.ConnectionStrings;
                    css.ConnectionStrings["cadenaConexion"].ConnectionString = "Server=" + server + ";Database=" + Database + ";uid=" + User + ";pwd=" + pass + ";port=" + port + ";Allow Zero Datetime=true";
                    conf.Save();
                    MessageBox.Show("Configuración Almacenada, el sistema SE REINICIARA, para probar los cambios", "Configuración Guardada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}