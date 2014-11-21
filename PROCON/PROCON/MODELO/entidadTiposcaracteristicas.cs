using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROCON.MODELO
{
    class entidadTipocaracteristicas
    {
        int id;
        string descripcion;
    
       public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
     public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
