using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROCON.MODELO
{
    class entidadEmpresa
    {

        int id;
        string sede;
        string nombre;
        string rif;
        string direccion;
        string telefono;
        string correo;

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }


        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Rif
        {
            get { return rif; }
            set { rif = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Sede
        {
            get { return sede; }
            set { sede = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
