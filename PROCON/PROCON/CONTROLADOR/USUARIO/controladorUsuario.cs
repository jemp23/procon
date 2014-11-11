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

namespace PROCON.CONTROLADOR.USUARIO
{
    class controladorUsuario : abstractControlador
    {
        //verificar el usuario que incio la sesion
        public int verificarUsuario(string log, string pass)
        {
            int id = 0; string nombres = ""; 
            MySqlConnection cnn = base.getConexion();
            MySqlCommand comando = cnn.CreateCommand();
            comando.CommandText = "SELECT * from usuario where usuario='" + log + "' and clave = '" + pass + "' and nivel>0";
            int total = Convert.ToInt16(comando.ExecuteScalar());




            if (total > 0)
            {
                MySqlDataReader resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    id = Convert.ToInt16( resultado["id"].ToString());
                    nombres = resultado["nombres"].ToString();

                    /*
                     *  Color c = ColorTranslator.FromHtml(ccolor); //Aqui le pasas el string que define el color
                    sesion.AUTOFORMPACIENTE = resultado["autoformpaciente"].ToString();
                    sesion.CODUSUARIOSESION = Convert.ToInt32(usu_cod.ToString());
                    sesion.NOMBREUSUARIOSESION = nombre.ToString();
                    sesion.TIPODEUSUARIO = Convert.ToInt32(usu_tipo.ToString());
                    sesion.NIVELUSUARIO = Convert.ToInt32(nivel.ToString());
                    sesion.LOGINUSUARIO = usu_log.ToString();
                    sesion.COLORFORMULARIO = c;
                    sesion.AUTOLLAMADO = Convert.ToInt16(resultado["autollamado"]);
                    sesion.PERMISODEFACTURAR = resultado["usu_ing"].ToString();
                    */
                    //CARGO LAS IMPRESORAS 
                    /*
                    entidadEquipo esteEquipo = CONTROLADOR.EQUIPO.controladorEquipo.examinarEquipoPorNombre(Dns.GetHostName());

                    if (esteEquipo != null)
                    {
                        sesion.IMPRESORADEUTM = esteEquipo.Impresorautm;
                        sesion.IMPRESORAFACTURA = esteEquipo.Impresorafactura;
                        sesion.IMPRESORADEROTULOS = esteEquipo.Impresorarotulo;
                        sesion.IMPRESORADERESULTADOS = esteEquipo.Impresoraresultado;
                        sesion.SERIEDEFACTURA = esteEquipo.Serie;
                        sesion.DIRECCIONDEINFORMES = esteEquipo.DirReportes;
                        sesion.DIRECCIONDEFUENTES = esteEquipo.DirFuentes;
                        sesion.IMPRESORACARNET = esteEquipo.Impresoracarnet;
                        sesion.DIRECCIONFOTOSPACIENTEEQUIPO = esteEquipo.DirFotos;
                    }
                    //
                    */
                    //cargo variables de la empresa
                    /*
                    entidadEmpresa estaEmpresa = CONTROLADOR.EMPRESA.controladorEmpresa.examinarPorId(1);
                    if (estaEmpresa != null)
                    {
                        sesion.CANTIDADEXAMENSPERMITIDOSENFACTURA = estaEmpresa.Cantidadexamen;

                        sesion.ABONOMINIMO = estaEmpresa.Abonominimo;
                        sesion.ACTIVAREXPRESIONESREGULARESPARAVALIDAR = estaEmpresa.Expresionesregulares; //valor recomendado -1, (0 desactiva las validaciones)
                        sesion.VALORDELALFACASH = estaEmpresa.Valoralfacash;
                        sesion.PREJIFOCODIGOPACIENTE = estaEmpresa.PrefijoPaciente;

                        //si hay una direccion cargada para el equipo se debe cambiar por la de la empresa.
                        if (sesion.DIRECCIONFOTOSPACIENTEEQUIPO.Length > 1) sesion.DIRECCIONDONDESEALMACENANLASFOTOGRAFIAS = sesion.DIRECCIONFOTOSPACIENTEEQUIPO;
                        else sesion.DIRECCIONDONDESEALMACENANLASFOTOGRAFIAS = estaEmpresa.Direccionfotos;
                    }
                    //
                     */
                }
                resultado.Close();
            }


            cnn.Close();

            //REGISTRO LA SESION comando.CommandText = "SELECT * from tranx_usu where usu_log='" + log + "' and usu_pass = '" + pass + "' and estatus=1";




            return total;
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
                cmd = new MySqlCommand("SELECT * FROM usuario");
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
                cmd = new MySqlCommand("SELECT id, nombres, apellidos, usuario, correo, celular from usuario");
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
        public int modificar(entidadUsuario usuario)
        {
            try
            {
                MySqlConnection conexion = base.getConexion();
                MySqlCommand comando;
                string query = "UPDATE usuario set nombres = @nombres, apellidos = @apellidos, correo = @correo, " +
                "celular = @celular, usuario = @usuario, clave = @clave, nivel = @nivel " +
                "WHERE id = @id";

                comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombres", usuario.Nombres);
                comando.Parameters.AddWithValue("@apellidos", usuario.Apellidos);
                comando.Parameters.AddWithValue("@correo", usuario.Correo);
                comando.Parameters.AddWithValue("@celular", usuario.Celular);
                comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
                comando.Parameters.AddWithValue("@clave", usuario.Clave);
                comando.Parameters.AddWithValue("@nivel", usuario.Nivel);
                comando.Parameters.AddWithValue("@id", usuario.Id);
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
        public int nuevo(entidadUsuario usuario)
        {
            try
            {
                MySqlConnection conexion = base.getConexion();
                MySqlCommand comando;
                string query = "INSERT INTO usuario " +
                " (nombres, apellidos, correo, celular, usuario, clave, nivel ) " +
                " VALUES " +
                " (@nombres, @apellidos, @correo, @celular, @usuario, @clave, @nivel ) " +
                ";";

                comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombres", usuario.Nombres);
                comando.Parameters.AddWithValue("@apellidos", usuario.Apellidos);
                comando.Parameters.AddWithValue("@correo", usuario.Correo);
                comando.Parameters.AddWithValue("@celular", usuario.Celular);
                comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
                comando.Parameters.AddWithValue("@clave", usuario.Clave);
                comando.Parameters.AddWithValue("@nivel", usuario.Nivel);
                comando.Parameters.AddWithValue("@id", usuario.Id);

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

                comando.CommandText = "SELECT Max(usuario.id) AS ULTIMO FROM usuario";


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
    }
}
