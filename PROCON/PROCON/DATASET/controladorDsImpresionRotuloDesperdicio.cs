using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PROCON.CONEXION;
using PROCON.CONTROLADOR;

namespace PROCON.DATASET
{
    class controladorDsImpresionRotuloDesperdicio : abstractControlador
    {
        public static dsImpresionRotuloDesperdicio examinarPorId(Int32 id)
        {
            dsImpresionRotuloDesperdicio des = null;
            Conexion con = new Conexion();
            MySqlConnection cnn = con.getConexion2();
            MySqlCommand comando = cnn.CreateCommand();
            comando.CommandText = " SELECT desperdicio.id, desperdicio.fecha, desperdicio.fkorden_produccion, maquinas.descripcion AS maquina, operador.nombreOperador, desperdicio.cantidad, tipo_desperdicio.descripcion AS tipodesperdicio " +
                                  " FROM ((desperdicio INNER JOIN maquinas ON desperdicio.fkmaquina = maquinas.id) INNER JOIN operador ON desperdicio.fkoperador = operador.idOperador) INNER JOIN tipo_desperdicio ON desperdicio.fktipo_desperdicio = tipo_desperdicio.id " +
                                  " WHERE (((desperdicio.id)=@id));";
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
        private static dsImpresionRotuloDesperdicio leerTabla(IDataReader lector)
        {
            try
            {
                dsImpresionRotuloDesperdicio  ds = new dsImpresionRotuloDesperdicio();
                ds.Id = Convert.ToInt32(lector["id"].ToString());
                ds.Fecha = Convert.ToDateTime(lector["fecha"].ToString());
                ds.Fkorden_produccion = Convert.ToInt32(lector["fkorden_produccion"].ToString());
                ds.Maquina = lector["maquina"].ToString();
                ds.NombreOperador = lector["nombreOperador"].ToString();
                ds.Tipodesperdicio = (lector["tipodesperdicio"].ToString());
                ds.Cantidad = Convert.ToDouble(lector["cantidad"].ToString());
                return ds;
            }
            catch
            {
                return null;
            }
        }
    }
}
