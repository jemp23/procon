using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROCON.MODELO
{
    class entidadOperador
    {
        int idOperador;
        string nombreOperador;
        string telefonoOperador;
        int estatus;
        int fkSede;


        public int FkSede
        {
            get { return fkSede; }
            set { fkSede = value; }
        }

        public int Estatus
        {
            get { return estatus; }
            set { estatus = value; }
        }

        public string TelefonoOperador
        {
            get { return telefonoOperador; }
            set { telefonoOperador = value; }
        }

        public string NombreOperador
        {
            get { return nombreOperador; }
            set { nombreOperador = value; }
        }

        public int IdOperador
        {
            get { return idOperador; }
            set { idOperador = value; }
        }
    }
}
