using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Net;
using PROCON.CONEXION;
using PROCON.MODELO;
using PROCON.CONTROLADOR.SESION;

namespace PROCON.CONTROLADOR.TIPO_DESPERDICIO
{
    class controladorDesperdicio : abstractControlador
    {
        public int nuevo(entidadDesperdicio desperdicio)
        {
            try
            {
                MySqlConnection conexion = base.getConexion();
                MySqlCommand comando;
                string query = "INSERT INTO desperdicio " +
                " (fecha, fkoperador, fkmaquina, observacion, cantidad, fktipo_desperdicio, fkorden_produccion, fkusuario, fkempresa, fechaRegistro ) " +
                " VALUES " +
                " (@fecha, @fkoperador, @fkmaquina, @observacion, @cantidad, @fktipo_desperdicio, @fkorden_produccion, @fkusuario, @fkempresa, @fechaRegistro ) " +
                ";";

                comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@fecha", desperdicio.Fecha);
                comando.Parameters.AddWithValue("@fkoperador", desperdicio.Fkoperador);
                comando.Parameters.AddWithValue("@fkmaquina", desperdicio.Fkmaquina);
                comando.Parameters.AddWithValue("@observacion", desperdicio.Observacion);
                comando.Parameters.AddWithValue("@cantidad", desperdicio.Cantidad);
                comando.Parameters.AddWithValue("@fktipo_desperdicio", desperdicio.Fktipo_desperdicio);
                comando.Parameters.AddWithValue("@fkorden_produccion", desperdicio.Fkorden_produccion);
                comando.Parameters.AddWithValue("@fkusuario", desperdicio.Fkusuario);
                comando.Parameters.AddWithValue("@fkempresa", desperdicio.Fkempresa);
                comando.Parameters.AddWithValue("@fechaRegistro", DateTime.Now);


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
                cmd = new MySqlCommand(" SELECT desperdicio.id, tipo_desperdicio.descripcion, desperdicio.fecha, desperdicio.fkorden_produccion, maquinas.descripcion AS maquina, operador.nombreOperador, desperdicio.cantidad " +
                                       " FROM ((desperdicio INNER JOIN tipo_desperdicio ON desperdicio.fktipo_desperdicio = tipo_desperdicio.id) INNER JOIN maquinas ON desperdicio.fkmaquina = maquinas.id) INNER JOIN operador ON desperdicio.fkoperador = operador.idOperador " +
                                       " ORDER BY desperdicio.id DESC;");
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
    }
}
