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
    }
}
