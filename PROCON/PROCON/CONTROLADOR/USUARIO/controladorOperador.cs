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
    class controladorOperador : abstractControlador
    {
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
                cmd = new MySqlCommand("SELECT * FROM operador");
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
                cmd = new MySqlCommand("SELECT idOperador, nombreOperador, telefonoOperador from operador");
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
        public int modificar(entidadOperador op)
        {
            try
            {
                MySqlConnection conexion = base.getConexion();
                MySqlCommand comando;
                string query = "UPDATE operador set NombreOperador = @NombreOperador, FkSede = @FkSede, Estatus = @Estatus " +
                "WHERE IdOperador = @IdOperador";

                comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@NombreOperador", op.NombreOperador);
                comando.Parameters.AddWithValue("@TelefonoOperador", op.TelefonoOperador);
                comando.Parameters.AddWithValue("@FkSede", op.FkSede);
                comando.Parameters.AddWithValue("@Estatus", op.Estatus);

                comando.Parameters.AddWithValue("@IdOperador", op.IdOperador);
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
        public int nuevo(entidadOperador op)
        {
            try
            {
                MySqlConnection conexion = base.getConexion();
                MySqlCommand comando;
                string query = "INSERT INTO operador " +
                " (NombreOperador, TelefonoOperador, FkSede, Estatus ) " +
                " VALUES " +
                " (@NombreOperador, @TelefonoOperador, @FkSede, @Estatus ) " +
                ";";

                comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@NombreOperador", op.NombreOperador);
                comando.Parameters.AddWithValue("@TelefonoOperador", op.TelefonoOperador);
                comando.Parameters.AddWithValue("@FkSede", op.FkSede);
                comando.Parameters.AddWithValue("@Estatus", op.Estatus);

                comando.Parameters.AddWithValue("@IdOperador", op.IdOperador);

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

                comando.CommandText = "SELECT Max(operador.IdOperador) AS ULTIMO FROM operador";


                MySqlDataReader resultado = comando.ExecuteReader();
                while (resultado.Read())
                {
                    ULTIMO =  Convert.ToInt32( resultado["ULTIMO"].ToString());
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
        ///
        public static List<entidadOperador> listarPorTipo(int fkTipoUsuario, int fkSede) //me muestra la lista de un registro
        {
            List<entidadOperador> Lista = new List<entidadOperador>();

            Conexion con = new Conexion();
            MySqlConnection cnn = con.getConexion();
            MySqlCommand comando = cnn.CreateCommand();
            comando.CommandText = "SELECT operador.idOperador, operador.nombreOperador, operador.estatus " +
                                  " FROM operador INNER JOIN operador_tipo_usuario ON operador.idOperador = operador_tipo_usuario.fkOperador " +
                                  " WHERE (((operador.estatus)=1) AND ((operador.fkSede)=@fkSede) AND ((operador_tipo_usuario.fkTipoUsuario)=@fkTipoUsuario));";
            comando.Parameters.AddWithValue("@fkTipoUsuario", fkTipoUsuario);
            comando.Parameters.AddWithValue("@fkSede", fkSede);
            MySqlDataReader lector = comando.ExecuteReader();


            while (lector.Read())
            {
                entidadOperador entidad = new entidadOperador();

                entidad.IdOperador = Convert.ToInt16(lector["idOperador"].ToString());
                entidad.NombreOperador = lector["nombreOperador"].ToString();
                Lista.Add(entidad);
            }
            lector.Close();
            cnn.Close();
            return Lista;
        }

   }
}
