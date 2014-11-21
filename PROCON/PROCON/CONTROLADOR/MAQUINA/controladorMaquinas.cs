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


namespace PROCON.CONTROLADOR.MAQUINAS
{
    class controladorMaquinas : abstractControlador
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
                cmd = new MySqlCommand("SELECT * FROM maquinas");
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
                cmd = new MySqlCommand("SELECT maquinas.Id, maquinas.descripcion, empresa.sede, tipo_desperdicio.descripcion as descripciondesperdicio "+
" FROM empresa INNER JOIN (tipo_desperdicio INNER JOIN maquinas ON tipo_desperdicio.Id = maquinas.fktipo_maquina) ON empresa.Id = maquinas.fkempresa;"); //ESTA SENTECIA CONCATENA SE HACE PARA QUE ME HAGA LOS JOIN CON LAS OTRAS TABLAS X Q TIENEN FK
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
        public int nuevo(entidadMaquinas entMaquinas)
        {
            try
            {
                MySqlConnection conexion = base.getConexion();
                MySqlCommand comando;
                string query = "INSERT INTO maquinas " +
                " (numero, descripcion, fkempresa, fktipo_maquina) " +
                " VALUES " +
                " (@numero, @descripcion, @fkempresa, @fktipo_maquina) " +
                ";";

                comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@numero", entMaquinas.Numero);
                comando.Parameters.AddWithValue("@descripcion", entMaquinas.Descripcion);
                comando.Parameters.AddWithValue("@fkempresa", entMaquinas.Fkempresa);
                comando.Parameters.AddWithValue("@fktipo_maquina", entMaquinas.Fktipo_maquina);
                comando.Parameters.AddWithValue("@id", entMaquinas.Id);

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

        public int modificar(entidadMaquinas entMaquinas) //guardar cambios
        {
            try
            {
                MySqlConnection conexion = base.getConexion();
                MySqlCommand comando;
                string query = "UPDATE maquinas set numero = @numero, descripcion=@descripcion, fkempresa=@fkempresa, fktipo_maquina=@fktipo_maquina " +
                "WHERE id = @id";

                comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@numero", entMaquinas.Numero);
                comando.Parameters.AddWithValue("@descripcion", entMaquinas.Descripcion);
                comando.Parameters.AddWithValue("@fkempresa", entMaquinas.Fkempresa);
                comando.Parameters.AddWithValue("@fktipo_maquina", entMaquinas.Fktipo_maquina);
                comando.Parameters.AddWithValue("@id", entMaquinas.Id);
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

                comando.CommandText = "SELECT Max(maquinas.id) AS ULTIMO FROM maquinas";


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

        public static List<entidadMaquinas> listar() //me muestra la lista de un registro
        {
            List<entidadMaquinas> Lista = new List<entidadMaquinas>();

            Conexion con = new Conexion();
            MySqlConnection cnn = con.getConexion();
            MySqlCommand comando = cnn.CreateCommand();
            comando.CommandText = "SELECT * FROM maquinas ORDER BY numero;";
            MySqlDataReader lector = comando.ExecuteReader();


            while (lector.Read())
            {
                entidadMaquinas entidad = new entidadMaquinas();

                entidad.Id = Convert.ToInt16(lector["id"].ToString());
                entidad.Numero = Convert.ToInt16(lector["numero"].ToString());
                entidad.Descripcion = lector["descripcion"].ToString();
                Lista.Add(entidad);
            }
            lector.Close();
            cnn.Close();
            return Lista;
        }
        public static List<entidadMaquinas> listarPorTipo(int tipo) //me muestra la lista de un registro
        {
            List<entidadMaquinas> Lista = new List<entidadMaquinas>();

            Conexion con = new Conexion();
            MySqlConnection cnn = con.getConexion();
            MySqlCommand comando = cnn.CreateCommand();
            comando.CommandText = "SELECT * FROM maquinas where fktipo_maquina =@fktipo_maquina ORDER BY numero;";
            comando.Parameters.AddWithValue("@fktipo_maquina", tipo);
            MySqlDataReader lector = comando.ExecuteReader();


            while (lector.Read())
            {
                entidadMaquinas entidad = new entidadMaquinas();

                entidad.Id = Convert.ToInt16(lector["id"].ToString());
                entidad.Numero = Convert.ToInt16(lector["numero"].ToString());
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
            comando.CommandText = "SELECT * FROM maquinas ORDER BY numero;";
            MySqlDataReader lector = comando.ExecuteReader();



            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

            while (lector.Read())
            {
                coleccion.Add(lector["numero"].ToString());
            }
            lector.Close();
            cnn.Close();
            return coleccion;
        }




    }
}
