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


namespace PROCON.CONTROLADOR.EMPRESA
{
    class controladorEmpresa : abstractControlador
    {
        //metodos comunes en todos los formularios
        public static DataSet examinarPorIdDataset() //trae una copia de la tabla
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
                cmd = new MySqlCommand("SELECT * FROM empresa");
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
                cmd = new MySqlCommand("SELECT id, sede, nombre from empresa");
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
        public int nuevo(entidadEmpresa entEmpresa)
        {
            try
            {
                MySqlConnection conexion = base.getConexion();
                MySqlCommand comando;
                string query = "INSERT INTO empresa " +
                " (sede, nombre, rif, direccion, telefono, correo) " +
                " VALUES " +
                " (@sede, @nombre, @rif, @direccion, @telefono, @correo) " +
                ";";

                comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@sede", entEmpresa.Sede);
                comando.Parameters.AddWithValue("@nombre", entEmpresa.Nombre);
                comando.Parameters.AddWithValue("@rif", entEmpresa.Rif);
                comando.Parameters.AddWithValue("@direccion", entEmpresa.Direccion);
                comando.Parameters.AddWithValue("@telefono", entEmpresa.Telefono);
                comando.Parameters.AddWithValue("@correo", entEmpresa.Correo);
                comando.Parameters.AddWithValue("@id", entEmpresa.Id);

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

        public int modificar(entidadEmpresa entEmpresa) //guardar cambios
        {
            try
            {
                MySqlConnection conexion = base.getConexion();
                MySqlCommand comando;
                string query = "UPDATE empresa set sede = @sede, nombre=@nombre, rif=@rif, direccion=@direccion, telefono=@telefono, correo=@correo " +
                "WHERE id = @id";

                comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@sede", entEmpresa.Sede);
                comando.Parameters.AddWithValue("@nombre", entEmpresa.Nombre);
                comando.Parameters.AddWithValue("@rif", entEmpresa.Rif);
                comando.Parameters.AddWithValue("@direccion", entEmpresa.Direccion);
                comando.Parameters.AddWithValue("@telefono", entEmpresa.Telefono);
                comando.Parameters.AddWithValue("@correo", entEmpresa.Correo);
                comando.Parameters.AddWithValue("@id", entEmpresa.Id);
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
        
        public Int32 idUltimoRegistrado()// me muestre el ultimo id que se registro
        {
            try
            {
                Int32 ULTIMO = 1;
                MySqlConnection cnn = base.getConexion();
                MySqlCommand comando = cnn.CreateCommand();

                comando.CommandText = "SELECT Max(empresa.id) AS ULTIMO FROM empresa";


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

        public static List<entidadEmpresa> listar() //me muestra la lista de un registro
        {
            List<entidadEmpresa> Lista = new List<entidadEmpresa>();

            Conexion con = new Conexion();
            MySqlConnection cnn = con.getConexion();
            MySqlCommand comando = cnn.CreateCommand();
            comando.CommandText = "SELECT * FROM empresa ORDER BY nombre;";
            MySqlDataReader lector = comando.ExecuteReader();


            while (lector.Read())
            {
                entidadEmpresa entidad = new entidadEmpresa();

                entidad.Id = Convert.ToInt16(lector["id"].ToString());
                entidad.Nombre = lector["Nombre"].ToString();
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
            comando.CommandText = "SELECT * FROM empresa ORDER BY nombre;";
            MySqlDataReader lector = comando.ExecuteReader();



            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

            while (lector.Read())
            {
                coleccion.Add(lector["nombre"].ToString());
            }
            lector.Close();
            cnn.Close();
            return coleccion;
        }




    }
}
