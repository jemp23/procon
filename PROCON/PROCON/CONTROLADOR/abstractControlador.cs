using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using PROCON.CONEXION;

namespace PROCON.CONTROLADOR
{
    class abstractControlador
    {


        protected void transaccionFinalizada()
        {
        }

        protected MySqlConnection getConexion()
        {

            Conexion conexion = new Conexion();
            return conexion.getConexion();
        }
        protected MySqlConnection getConexion2()
        {

            Conexion conexion = new Conexion();
            return conexion.getConexion2();
        }


    }
}