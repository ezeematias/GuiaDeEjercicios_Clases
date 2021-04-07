using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Biblioteca
{
    class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;
        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        public enum Puesto {Caja1, Caja2}

        static int NumeroActual
        {
            get
            {                
                return numeroActual++;
            }
        }

        public bool Atender (Cliente cli)
        {
            Thread.Sleep(1000);
            return true;
        }
    }
}
