using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                bool boolean;
                boolean = this + value;
            }
        }

        private Negocio()
        {
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
            this.clientes = new Queue<Cliente>();
        }

        public Negocio(string nombre)
        {
            this.nombre = nombre;
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            n.clientes.Enqueue(c);
            return true;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach(Cliente c1 in n.clientes)
            {
                if(c1 == c)
                {
                    return true;
                }
            }
            return false;            
        }

        public static bool operator ~(Negocio n)
        {
            return n.caja.Atender(n.clientes.Dequeue());
        }
            
            






    }
}
