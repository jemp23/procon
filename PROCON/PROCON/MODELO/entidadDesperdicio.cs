using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROCON.MODELO
{
    class entidadDesperdicio
    {
        Int32 id;
        DateTime fecha;
        int fkoperador;
        int fkmaquina;
        string observacion;
        double cantidad;
        int fktipo_desperdicio;
        int fkorden_produccion;
        int fkusuario;
        int fkempresa;
        DateTime fechaRegistro;


        public DateTime FechaRegistro
        {
            get { return fechaRegistro; }
            set { fechaRegistro = value; }
        }

        public int Fkempresa
        {
            get { return fkempresa; }
            set { fkempresa = value; }
        }

        public int Fkusuario
        {
            get { return fkusuario; }
            set { fkusuario = value; }
        }

        public int Fkorden_produccion
        {
            get { return fkorden_produccion; }
            set { fkorden_produccion = value; }
        }

        public int Fktipo_desperdicio
        {
            get { return fktipo_desperdicio; }
            set { fktipo_desperdicio = value; }
        }

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }

        public int Fkmaquina
        {
            get { return fkmaquina; }
            set { fkmaquina = value; }
        }

        public int Fkoperador
        {
            get { return fkoperador; }
            set { fkoperador = value; }
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
