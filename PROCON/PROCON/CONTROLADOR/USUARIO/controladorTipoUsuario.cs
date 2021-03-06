﻿using System;
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

        public static DataSet listarModulosdeUnTipoUsuario(int id)
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
                cmd = new MySqlCommand(" SELECT modulos.id, modulos.descripcion, modulos.direccion, modulos.interfaz, modulos.orden, modulos.imagen, modulos.superior " +
" FROM modulos INNER JOIN (tipo_usuario INNER JOIN permisos ON tipo_usuario.id = permisos.fk_tipousuario) ON modulos.id = permisos.fk_tipomodulo " +
" WHERE (((tipo_usuario.id)=@id)) " +
" ORDER BY modulos.orden;");
                cmd.CommandType = CommandType.Text;
                da.SelectCommand = (MySqlCommand)cmd;
                cmd.Parameters.AddWithValue("@id", id);

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
        public static DataSet listarModulosdeUnTipoUsuarioDisponibles()
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
                cmd = new MySqlCommand(" SELECT * from modulos " +
" ORDER BY modulos.orden;");
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
        public static int consultarSiElPerfilTieneElModuloAsignado(int fk_tipousuario, int fk_tipomodulo)
        {
            int max = 0;
            Conexion con = new Conexion();
            MySqlConnection cnn = con.getConexion();
            MySqlCommand comando = cnn.CreateCommand();
            comando.CommandText = "SELECT permisos.id, permisos.fk_tipousuario, permisos.fk_tipomodulo " +
" FROM permisos " +
" WHERE (((permisos.fk_tipousuario)=@fk_tipousuario) AND ((permisos.fk_tipomodulo)=@fk_tipomodulo));";

            comando.Parameters.AddWithValue("@fk_tipousuario", fk_tipousuario);
            comando.Parameters.AddWithValue("@fk_tipomodulo", fk_tipomodulo);


            MySqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                max = Convert.ToInt32(lector["id"].ToString());
            }
            lector.Close();
            cnn.Close();
            return max;
        }

        public int eliminarUnModulo(int fk_tipousuario, int fk_tipomodulo)
        {
            try
            {
                MySqlConnection conexion = base.getConexion();
                MySqlCommand comando;
                string query = "delete from permisos where fk_tipousuario=@fk_tipousuario and fk_tipomodulo=@fk_tipomodulo;";

                comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@fk_tipousuario", fk_tipousuario);
                comando.Parameters.AddWithValue("@fk_tipomodulo", fk_tipomodulo);

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
        public int AnexarUnModulo(int fk_tipousuario, int fk_tipomodulo)
        {
            try
            {
                MySqlConnection conexion = base.getConexion();
                MySqlCommand comando;
                string query = "INSERT INTO permisos  " +
                " (fk_tipousuario, fk_tipomodulo) " +
                " VALUES " +
                " (@fk_tipousuario, @fk_tipomodulo) " +
                ";";

                comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@fk_tipousuario", fk_tipousuario);
                comando.Parameters.AddWithValue("@fk_tipomodulo", fk_tipomodulo);

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

        //metodos comunes en todos los formularios
        public static DataSet examinarPorIdDataset()
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
                cmd = new MySqlCommand("SELECT * FROM tipo_usuario");
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
        public static DataSet ListarDataGridDataset()
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
                cmd = new MySqlCommand("SELECT id, descripcion from tipo_usuario");
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
        public int modificar(entidadTipoUsuario tusuario)
        {
            try
            {
                MySqlConnection conexion = base.getConexion();
                MySqlCommand comando;
                string query = "UPDATE tipo_usuario set descripcion = @descripcion " +
                "WHERE id = @id";

                comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@descripcion", tusuario.Descripcion);
                comando.Parameters.AddWithValue("@id", tusuario.Id);
                int Resultado = comando.ExecuteNonQuery();

                conexion.Close();
                base.transaccionFinalizada();
                return Resultado;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error de UPDATE " + ex);
                return 0;
            }
        }
        //guardar cambios en el registro
        public int nuevo(entidadTipoUsuario tusuario)
        {
            try
            {
                MySqlConnection conexion = base.getConexion();
                MySqlCommand comando;
                string query = "INSERT INTO tipo_usuario " +
                " (descripcion) " +
                " VALUES " +
                " (@descripcion) " +
                ";";

                comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@descripcion", tusuario.Descripcion);
                comando.Parameters.AddWithValue("@id", tusuario.Id);

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
        //guardar cambios en el registro
        public Int32 idUltimoRegistrado()
        {
            try
            {
                Int32 ULTIMO = 1;
                MySqlConnection cnn = base.getConexion();
                MySqlCommand comando = cnn.CreateCommand();

                comando.CommandText = "SELECT Max(tipo_usuario.id) AS ULTIMO FROM tipo_usuario";


                MySqlDataReader resultado = comando.ExecuteReader();
                while (resultado.Read())
                {
                    ULTIMO = Convert.ToInt32(resultado["ULTIMO"].ToString());
                }
                resultado.Close();
                cnn.Close();

                return ULTIMO;
            }
            catch
            {
                return 0;
            }
        }
        ///metodos comunes en todos los formularios
        public static DataSet listarPerfilesdeUnOperador(int fkOperador)
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
                cmd = new MySqlCommand(" SELECT tipo_desperdicio.id, tipo_desperdicio.descripcion " +
                                       " FROM operador_tipo_usuario INNER JOIN tipo_desperdicio ON operador_tipo_usuario.fkTipoUsuario = tipo_desperdicio.id " +
                                       " WHERE (((operador_tipo_usuario.fkOperador)=@fkOperador)) " +
                                       " ORDER BY tipo_desperdicio.descripcion;");
                cmd.CommandType = CommandType.Text;
                da.SelectCommand = (MySqlCommand)cmd;
                cmd.Parameters.AddWithValue("@fkOperador", fkOperador);

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
        public static DataSet listarPerfilesDisponiblesDeUnOperador()
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
                cmd = new MySqlCommand("SELECT * from tipo_desperdicio");
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
        public static int consultarSiElOperadorTieneElModuloAsignado(int fkOperador, int fkTipoUsuario)
        {
            int max = 0;
            Conexion con = new Conexion();
            MySqlConnection cnn = con.getConexion();
            MySqlCommand comando = cnn.CreateCommand();
            comando.CommandText = "SELECT operador_tipo_usuario.idots FROM operador_tipo_usuario WHERE (((operador_tipo_usuario.fkOperador)=@fkOperador) AND ((operador_tipo_usuario.fkTipoUsuario)=@fkTipoUsuario));";

            comando.Parameters.AddWithValue("@fkOperador", fkOperador);
            comando.Parameters.AddWithValue("@fkTipoUsuario", fkTipoUsuario);


            MySqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                max = Convert.ToInt32(lector["idots"].ToString());
            }
            lector.Close();
            cnn.Close();
            return max;
        }
        
    }
}
