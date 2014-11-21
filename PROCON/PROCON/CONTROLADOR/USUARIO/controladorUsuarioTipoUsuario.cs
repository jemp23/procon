using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PROCON.MODELO;

namespace PROCON.CONTROLADOR.USUARIO
{
    class controladorUsuarioTipoUsuario : abstractControlador
    {
        public int nuevo(entidadUsuarioTipoUsuario utu)
        {
            try
            {
                MySqlConnection conexion = base.getConexion();
                MySqlCommand comando;
                string query = "INSERT INTO usuario_tipousuario " +
                " (Fkusuario, Fktipo_usuario) " +
                " VALUES " +
                " (@Fkusuario, @Fktipo_usuario) " +
                ";";

                comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Fkusuario", utu.Fkusuario);
                comando.Parameters.AddWithValue("@Fktipo_usuario", utu.Fktipo_usuario);
                int Resultado = comando.ExecuteNonQuery();

                conexion.Close();
                base.transaccionFinalizada();
                return Resultado;
            }
            catch
            {
                return 0;
            }
        }
        public int nuevo(entidadOperadorTipoUsuario otu)
        {
            try
            {
                MySqlConnection conexion = base.getConexion();
                MySqlCommand comando;
                string query = "INSERT INTO operador_tipo_usuario " +
                " (FkOperador, FkTipoUsuario) " +
                " VALUES " +
                " (@FkOperador, @FkTipoUsuario) " +
                ";";

                comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@FkOperador", otu.FkOperador);
                comando.Parameters.AddWithValue("@FkTipoUsuario", otu.FkTipoUsuario);
                int Resultado = comando.ExecuteNonQuery();

                conexion.Close();
                base.transaccionFinalizada();
                return Resultado;
            }
            catch
            {
                return 0;
            }
        }
        public int eliminar(entidadUsuarioTipoUsuario utu)
        {
            try
            {
                MySqlConnection conexion = base.getConexion();
                MySqlCommand comando;
                string query = "delete from usuario_tipousuario " +
                " where Fkusuario=@Fkusuario and Fktipo_usuario=@Fktipo_usuario" +
                ";";

                comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Fkusuario", utu.Fkusuario);
                comando.Parameters.AddWithValue("@Fktipo_usuario", utu.Fktipo_usuario);

                int Resultado = comando.ExecuteNonQuery();

                conexion.Close();
                base.transaccionFinalizada();
                return Resultado;
            }
            catch
            {
                return 0;
            }
        }
        public int eliminar(entidadOperadorTipoUsuario otu)
        {
            try
            {
                MySqlConnection conexion = base.getConexion();
                MySqlCommand comando;
                string query = "delete from operador_tipo_usuario " +
                " where FkOperador=@FkOperador and FkTipoUsuario=@FkTipoUsuario" +
                ";";

                comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@FkOperador", otu.FkOperador);
                comando.Parameters.AddWithValue("@FkTipoUsuario", otu.FkTipoUsuario);

                int Resultado = comando.ExecuteNonQuery();

                conexion.Close();
                base.transaccionFinalizada();
                return Resultado;
            }
            catch
            {
                return 0;
            }
        }
    }
}
