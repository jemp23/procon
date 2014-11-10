using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROCON.MODELO
{
    class entidadUsuario
    {
        private int id;
        private string nombres;
        private string apellidos;
        private string correo;
        private string celular;
        private string usuario;
        private string clave;
        private string remoto;
        private int nivel;

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }



        public int Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }

        public string Remoto
        {
            get { return remoto; }
            set { remoto = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
