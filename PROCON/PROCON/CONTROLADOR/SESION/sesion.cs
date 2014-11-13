using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data;
using MySql.Data.MySqlClient;
using PROCON.CONEXION;

namespace PROCON.CONTROLADOR.SESION
{
    public class sesion 
    {
        public static int CODUSUARIOSESION = 0; //codigo del usuario que tiene la sesion
        public static string NOMBREUSUARIOSESION = ""; //NOMBRE DEL USUARIO QUE INICIO LA SESION
        public static int TIPODEUSUARIO = 0;  //TIPO DE USUARIO QUE INGRESA AL SISTEMA DE ESTA FORMA SE BUSCAN LOS PERMISOS
        public static int NIVELUSUARIO = 0; //EL NIVEL DE ACCESO DEL 1 AL 99
        public static string LOGINUSUARIO = ""; //EL LOGIN DEL USUARIO QUE INICIA SESION
        public static Color COLORFORMULARIO = Color.WhiteSmoke;


        //VARIABLES DE LA MAQUINA
        public static string IMPRESORAFACTURA = "Microsoft XPS Document Writer"; //"\\\\192.168.0.53\\EPSON T50 DIVI";
        public static string IMPRESORADEROTULOS = "ROTULO";
        public static string IMPRESORADEUTM = "Microsoft XPS Document Writer";
        public static string IMPRESORADERESULTADOS = "Microsoft XPS Document Writer";
        public static string IMPRESORACARNET = "Microsoft XPS Document Writer";
        public static string SERIEDEFACTURA = "A";
        public static string DIRECCIONDEINFORMES = @"..\..\REPORTE\";
        public static string DIRECCIONDEFUENTES = @"..\..\Fonts\";


        //VARIABLES DE LA EMPRESA
        public static int ACTIVAREXPRESIONESREGULARESPARAVALIDAR = 1; //valor recomendado -1, (0 desactiva las validaciones)


        //VARIABLES DEL SISTEMA
        public static string NOMBREAPLICACION = "PROCON";//DATOS DEL PROGRAMA
        public static string LICENCIAAPLICACION = "PROCON 20140101-001";

        public static DataSet listarMenu()
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
                if (sesion.CODUSUARIOSESION == 1)
                {
                    cmd = new MySqlCommand("select * from modulos order by modulos.orden");

                }
                else
                {
                    
                    cmd = new MySqlCommand("SELECT modulos.id, modulos.descripcion, modulos.direccion, modulos.interfaz, modulos.orden, modulos.superior, modulos.imagen, usuario_tipousuario.fkusuario " +
" FROM modulos INNER JOIN ((tipo_usuario INNER JOIN usuario_tipousuario ON tipo_usuario.id = usuario_tipousuario.fktipo_usuario) INNER JOIN permisos ON tipo_usuario.id = permisos.fk_tipousuario) ON modulos.id = permisos.fk_tipomodulo " +
" GROUP BY modulos.id, modulos.descripcion, modulos.direccion, modulos.interfaz, modulos.orden, modulos.superior, usuario_tipousuario.fkusuario " +
" HAVING (((usuario_tipousuario.fkusuario)=@fkusuario)) " +
" ORDER BY modulos.orden");
                }
                cmd.CommandType = CommandType.Text;
                da.SelectCommand = (MySqlCommand)cmd;
                cmd.Parameters.AddWithValue("@fkusuario", sesion.CODUSUARIOSESION);

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

