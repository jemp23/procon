using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using PROCON.CONEXION;
using PROCON.MODELO;
using System.Windows.Forms;


namespace PROCON.CONTROLADOR.USUARIO
{
    class controladorModulos : abstractControlador
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
                cmd = new MySqlCommand("SELECT * FROM modulos");
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

        public static DataSet ListarDataGridDataset()//me carga el data grid
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
                cmd = new MySqlCommand("SELECT id, descripcion from modulos");
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
        public int nuevo(entidadModulos entModulos)
        {
            try
            {
                MySqlConnection conexion = base.getConexion();
                MySqlCommand comando;
                string query = "INSERT INTO modulos " +
                " (descripcion, direccion, imagen, interfaz, orden, superior) " +
                " VALUES " +
                " (@descripcion, @direccion, @imagen, @interfaz, @orden, @superior) " +
                ";";

                comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@descripcion", entModulos.Descripcion);
                comando.Parameters.AddWithValue("@direccion", entModulos.Direccion);
                comando.Parameters.AddWithValue("@imagen", entModulos.Imagen);
                comando.Parameters.AddWithValue("@interfaz", entModulos.Interfaz);
                comando.Parameters.AddWithValue("@orden",entModulos.Orden);
                comando.Parameters.AddWithValue("@superior",entModulos.Superior);
                comando.Parameters.AddWithValue("@id", entModulos.Id);

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
        public int modificar(entidadModulos entModulos)
        {
            try
            {
                MySqlConnection conexion = base.getConexion();
                MySqlCommand comando;
                string query = "UPDATE modulos set descripcion = @descripcion, direccion=@direccion, imagen=@imagen, interfaz=@interfaz, orden=@orden, superior=@superior " +
                "WHERE id = @id";

                comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@descripcion", entModulos.Descripcion);
                comando.Parameters.AddWithValue("@direccion", entModulos.Direccion);
                comando.Parameters.AddWithValue("@imagen", entModulos.Imagen);
                comando.Parameters.AddWithValue("@interfaz", entModulos.Interfaz);
                comando.Parameters.AddWithValue("@orden", entModulos.Orden);
                comando.Parameters.AddWithValue("@superior", entModulos.Superior);
                comando.Parameters.AddWithValue("@id", entModulos.Id);
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
        public Int32 idUltimoRegistrado()
        {
            try
            {
                Int32 ULTIMO = 1;
                MySqlConnection cnn = base.getConexion();
                MySqlCommand comando = cnn.CreateCommand();

                comando.CommandText = "SELECT Max(modulos.id) AS ULTIMO FROM modulos";


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

        public static List<entidadModulos> listar() //me muestra la lista de un registro
        {
            List<entidadModulos> Lista = new List<entidadModulos>();

            Conexion con = new Conexion();
            MySqlConnection cnn = con.getConexion();
            MySqlCommand comando = cnn.CreateCommand();
            comando.CommandText = "SELECT * FROM modulos ORDER BY descripcion;";
            MySqlDataReader lector = comando.ExecuteReader();


            while (lector.Read())
            {
                entidadModulos entidad = new entidadModulos();

                entidad.Id = Convert.ToInt16( lector["id"].ToString());
                entidad.Descripcion = lector["descripcion"].ToString();
                Lista.Add(entidad);
            }
            lector.Close();
            cnn.Close();
            return Lista;
        }
        public static AutoCompleteStringCollection autocompletar() // me autocompleta al ir escribiendo
        {



            Conexion con = new Conexion();
            MySqlConnection cnn = con.getConexion();
            MySqlCommand comando = cnn.CreateCommand();
            comando.CommandText = "SELECT * FROM modulos ORDER BY descripcion;";
            MySqlDataReader lector = comando.ExecuteReader();



            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

            while (lector.Read())
            {
                coleccion.Add(lector["descripcion"].ToString());
            }
            lector.Close();
            cnn.Close();
            return coleccion;
        }

        public int eliminarUnModulo(Int32 id)
        {
            try
            {
                MySqlConnection conexion = base.getConexion();
                MySqlCommand comando;
                string query = "delete from modulos " +
                " where id=@id" +
                ";";

                comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@id", id);

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