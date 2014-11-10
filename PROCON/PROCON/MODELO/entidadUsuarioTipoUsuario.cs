using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROCON.MODELO
{
    class entidadUsuarioTipoUsuario
    {
        Int32 id;
        Int32 fkusuario;
        Int32 fktipo_usuario;


        public Int32 Fktipo_usuario
        {
            get { return fktipo_usuario; }
            set { fktipo_usuario = value; }
        }

        public Int32 Fkusuario
        {
            get { return fkusuario; }
            set { fkusuario = value; }
        }

        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
