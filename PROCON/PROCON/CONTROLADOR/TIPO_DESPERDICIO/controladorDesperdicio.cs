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
        public int modificar(entidadDesperdicio desperdicio)
        {
            try
            {
                MySqlConnection conexion = base.getConexion();
                MySqlCommand comando;
                string query = "UPDATE desperdicio SET " +
                " fecha=@fecha, fkoperador=@fkoperador, fkmaquina=@fkmaquina, observacion=@observacion, cantidad=@cantidad, fktipo_desperdicio=@fktipo_desperdicio, fkorden_produccion=@fkorden_produccion, fkusuario=@fkusuario, fkempresa=fkempresa, fechaRegistro=@fechaRegistro " +
                " where id=@id" +
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
                comando.Parameters.AddWithValue("@id", desperdicio.Id);


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
                                       " ORDER BY desperdicio.id DESC LIMIT 0 , 500");
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

        public static entidadDesperdicio examinarPorId(Int32 id)
        {
            entidadDesperdicio des = null;
            Conexion con = new Conexion();
            MySqlConnection cnn = con.getConexion2();
            MySqlCommand comando = cnn.CreateCommand();
            comando.CommandText = "SELECT * FROM desperdicio WHERE id = @id;";
            comando.Parameters.AddWithValue("@id", id);
            MySqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                des = leerTabla(lector);
            }
            lector.Close();
            cnn.Close();
            return des;
        }
        //PASA LOS RESULTADOS DE LA CONSULTA A LA ENTIDAD
        private static entidadDesperdicio leerTabla(IDataReader lector)
        {
            try
            {
                entidadDesperdicio factura = new entidadDesperdicio();
                factura.Id = Convert.ToInt32(lector["id"].ToString());
                factura.Fktipo_desperdicio = Convert.ToInt16(lector["fktipo_desperdicio"].ToString());
                factura.Fecha = Convert.ToDateTime(lector["fecha"].ToString());
                factura.Fkorden_produccion = Convert.ToInt32(lector["fkorden_produccion"].ToString());
                factura.Fkmaquina = Convert.ToInt16(lector["fkmaquina"].ToString());
                factura.Fkoperador = Convert.ToInt16(lector["fkoperador"].ToString());
                factura.Observacion = (lector["observacion"].ToString());
                factura.Cantidad = Convert.ToDouble(lector["cantidad"].ToString());
                return factura;
            }
            catch
            {
                return null;
            }
        }
        public Int32 idUltimoRegistrado()// me muestre el ultimo id que se registro
        {
            try
            {
                Int32 ULTIMO = 1;
                MySqlConnection cnn = base.getConexion();
                MySqlCommand comando = cnn.CreateCommand();

                comando.CommandText = "SELECT Max(desperdicio.id) AS ULTIMO FROM desperdicio";


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
    }
}
