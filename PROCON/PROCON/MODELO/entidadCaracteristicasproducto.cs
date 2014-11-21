using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROCON.MODELO
{
    class entidadCaracteristicasproducto
    {
        int id;
        string descripcion;
        int fkidtipo_caracteristicas;
        float valor;
        decimal cantidad;

        public decimal Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public float Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public int Fkidtipo_caracteristicas
        {
            get { return fkidtipo_caracteristicas; }
            set { fkidtipo_caracteristicas = value; }
        }
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
