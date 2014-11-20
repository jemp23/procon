using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;


namespace PROCON.CONEXION
{
    class ConexionFB
    {
        //declaro los atributos de la conexion
        FbConnectionStringBuilder Cnn = new FbConnectionStringBuilder();
        
        
        public bool estatusConexion = false;


        /*
            Cnn.ServerType = FbServerType.Embedded;
            Cnn.UserID     = "SYSDBA";
            Cnn.Password   = "masterkey";
            Cnn.Dialect    = 3;
            Cnn.Database   = @"data\database.fdb";      // Path must exists
            Cnn.Charset    = "UTF8";                    // http://www.destructor.de/firebird/charsets.htm

        */

     /*   public FbConnection getConexion()
        {
            try
            {
                string cadenaConexion = ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString;
                Cnn.ConnectionString = cadenaConexion;
                Cnn.Open();
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
        }*/
    }
}
