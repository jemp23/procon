using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Net;

namespace PROCON.CONTROLADOR.USUARIO
{
    class controladorUsuario : abstractControlador
    {
        //verificar el usuario que incio la sesion
        public int verificarUsuario(string log, string pass)
        {
            string usu_cod = ""; string nombre = ""; string usu_log = ""; int usu_tipo = 0; int nivel = 0;
            MySqlConnection cnn = base.getConexion();
            MySqlCommand comando = cnn.CreateCommand();
            comando.CommandText = "SELECT * from tranx_usu where usu_log='" + log + "' and usu_pass = '" + pass + "' and estatus=1";
            int total = Convert.ToInt16(comando.ExecuteScalar());




            if (total > 0)
            {
                MySqlDataReader resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    usu_cod = resultado["usu_cod"].ToString();
                    nombre = resultado["usu_mon"].ToString();
                    usu_log = resultado["usu_log"].ToString();
                    usu_tipo = Convert.ToInt32(resultado["usu_tipo"].ToString());
                    nivel = Convert.ToInt32(resultado["usu_nivel"].ToString());
                    string ccolor = resultado["colorformulario"].ToString();


                    Color c = ColorTranslator.FromHtml(ccolor); //Aqui le pasas el string que define el color


                    /*
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
    }
}
