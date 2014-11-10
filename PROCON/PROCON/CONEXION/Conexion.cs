using System;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace PROCON.CONEXION
{
    public class Conexion
    {
        //declaro los atributos de la conexion
        MySqlConnection Cnn         =   new MySqlConnection();
        public bool estatusConexion = false;
        public MySqlConnection getConexion ()
            {
            try
                {
                string cadenaConexion = ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString;
                Cnn.ConnectionString = cadenaConexion;
                Cnn.Open(); 
                //System.Windows.Forms.MessageBox.Show("conectado", "BIEN HECHO MOTTA");
                this.estatusConexion = true;
                }
            catch 
                {
                    this.estatusConexion = false;
                    string RES = MessageBox.Show("ERROR CONECTANDO... \n Si = Reconectar \n No = Cerrar el Sistema", "Fallo la Conexión", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                    if (RES == "Yes")
                    {
                        getConexion();
                    }
                    else
                    {
                        Application.Exit();
                        
                    }


            }
            return Cnn;
            }
        public MySqlConnection getConexion2()
        {
            try
            {
                string cadenaConexion = ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString;
                Cnn.ConnectionString = cadenaConexion;
                Cnn.Open();
                //System.Windows.Forms.MessageBox.Show("conectado", "BIEN HECHO MOTTA");
                this.estatusConexion = true;
            }
            catch
            {
                this.estatusConexion = false;
                Application.Exit();
            }
            return Cnn;
        }
    }
}

