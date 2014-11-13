using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROCON.MODELO
{
    class entidadMaquinas
    {
        int id;
        int numero;
        string descripcion;
        int fkempresa;
        int fktipo_maquina;

        public int Fktipo_maquina
        {
            get { return fktipo_maquina; }
            set { fktipo_maquina = value; }
        }

        public int Fkempresa
        {
            get { return fkempresa; }
            set { fkempresa = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }


        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
