using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROCON.MODELO
{
    class entidadModulos
    {
        int id;
        string descripcion;
        string direccion;
        string imagen;
        int interfaz;
        int orden;
        int superior;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Descripcion
        {

            get { return descripcion; }
            set { descripcion = value; }
        }
        public string Direccion
        {

            get { return direccion; }
            set { direccion = value; }
        }
        public string Imagen
        {

            get { return imagen; }
            set { imagen = value; }
        }
        public int Interfaz
        {
            get { return interfaz; }
            set { interfaz = value; }
        }
        public int Orden
        {
            get { return orden; }
            set { orden = value; }
        }
        public int Superior
        {
            get { return superior; }
            set { superior = value; }
        }

    }
}
