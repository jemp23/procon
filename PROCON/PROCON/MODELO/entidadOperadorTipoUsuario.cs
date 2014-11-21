using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROCON.MODELO
{
    class entidadOperadorTipoUsuario
    {
        int idots;
        int fkOperador;
        int fkTipoUsuario;

        public int FkTipoUsuario
        {
            get { return fkTipoUsuario; }
            set { fkTipoUsuario = value; }
        }

        public int FkOperador
        {
            get { return fkOperador; }
            set { fkOperador = value; }
        }

        public int Idots
        {
            get { return idots; }
            set { idots = value; }
        }
    }
}
