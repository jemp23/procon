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

namespace PROCON.CONTROLADOR.TIPO_DESPERDICIO
{
    class controladorTipo_desperdicio : abstractControlador
    {
        public static List<entidadTipo_desperdicio> listar() //me muestra la lista de un registro
        {
            List<entidadTipo_desperdicio> Lista = new List<entidadTipo_desperdicio>();

            Conexion con = new Conexion();
            MySqlConnection cnn = con.getConexion();
            MySqlCommand comando = cnn.CreateCommand();
            comando.CommandText = "SELECT * FROM tipo_desperdicio ORDER BY descripcion;";
            MySqlDataReader lector = comando.ExecuteReader();


            while (lector.Read())
            {
                entidadTipo_desperdicio entidad = new entidadTipo_desperdicio();

                entidad.Id = Convert.ToInt16(lector["id"].ToString());
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
            comando.CommandText = "SELECT * FROM tipo_desperdicio ORDER BY descripcion;";
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




    }
}
