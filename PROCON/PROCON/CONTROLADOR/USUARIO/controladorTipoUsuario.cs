using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PROCON.CONEXION;
using PROCON.MODELO;

namespace PROCON.CONTROLADOR.USUARIO
{
    class controladorTipoUsuario : abstractControlador
    {
        public static DataSet listarPerfilesdeUnUsuario(int fkusuario)
        {
            MySqlConnection connection;
            MySqlCommand cmd;
            MySqlDataAdapter da;

            connection = null;
            cmd = null;
            DataSet ds = new DataSet();
            da = new MySqlDataAdapter();

            try
            {
                cmd = new MySqlCommand(" SELECT tipo_usuario.id, tipo_usuario.descripcion " +
                                       " FROM tipo_usuario INNER JOIN usuario_tipousuario ON tipo_usuario.id = usuario_tipousuario.fktipo_usuario " +
                                       " WHERE (((usuario_tipousuario.fkusuario)=@fkusuario));");
                cmd.CommandType = CommandType.Text;
                da.SelectCommand = (MySqlCommand)cmd;
                cmd.Parameters.AddWithValue("@fkusuario", fkusuario);

                Conexion con = new Conexion();
                connection = con.getConexion();
                cmd.Connection = connection;
                //connection.Open();
                // fill the dataset
                da.Fill(ds);
            }
            catch
            {
                throw;  // exception occurred here
            }
            finally
            {
                if (da != null)
                    da.Dispose();
                if (cmd != null)
                    cmd.Dispose();
                // implicitly calls close()
                connection.Dispose();
            }
            connection.Close();
            return ds;
        }
        public static DataSet listarPerfilesDisponibles()
        {
            MySqlConnection connection;
            MySqlCommand cmd;
            MySqlDataAdapter da;
            connection = null;
            cmd = null;
            DataSet ds = new DataSet();
            da = new MySqlDataAdapter();

            try
            {
                cmd = new MySqlCommand("SELECT tipo_usuario.id, tipo_usuario.descripcion FROM tipo_usuario;");
                cmd.CommandType = CommandType.Text;
                da.SelectCommand = (MySqlCommand)cmd;

                Conexion con = new Conexion();
                connection = con.getConexion();
                cmd.Connection = connection;
                //connection.Open();
                // fill the dataset
                da.Fill(ds);
            }
            catch
            {
                throw;  // exception occurred here
            }
            finally
            {
                if (da != null)
                    da.Dispose();
                if (cmd != null)
                    cmd.Dispose();
                // implicitly calls close()
                connection.Dispose();
            }
            connection.Close();
            return ds;
        }
        public static int consultarSiElUsuarioTieneElModuloAsignado(int fkusuario, int fktipo_usuario)
        {
            int max = 0;
            Conexion con = new Conexion();
            MySqlConnection cnn = con.getConexion();
            MySqlCommand comando = cnn.CreateCommand();
            comando.CommandText = "SELECT usuario_tipousuario.id FROM usuario_tipousuario WHERE (((usuario_tipousuario.fkusuario)=@fkusuario) AND ((usuario_tipousuario.fktipo_usuario)=@fktipo_usuario));";

            comando.Parameters.AddWithValue("@fkusuario", fkusuario);
            comando.Parameters.AddWithValue("@fktipo_usuario", fktipo_usuario);


            MySqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                max = Convert.ToInt32(lector["id"].ToString());
            }
            lector.Close();
            cnn.Close();
            return max;
        }
    }
}
