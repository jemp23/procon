using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROCON.DATASET
{
    class dsImpresionRotuloDesperdicio
    {
        Int32 id;
        DateTime fecha;
        Int32 fkorden_produccion;
        string maquina;
        string nombreOperador;
        double cantidad;
        string tipodesperdicio;



        public string Tipodesperdicio
        {
            get { return tipodesperdicio; }
            set { tipodesperdicio = value; }
        }

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public string NombreOperador
        {
            get { return nombreOperador; }
            set { nombreOperador = value; }
        }

        public string Maquina
        {
            get { return maquina; }
            set { maquina = value; }
        }

        public Int32 Fkorden_produccion
        {
            get { return fkorden_produccion; }
            set { fkorden_produccion = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
