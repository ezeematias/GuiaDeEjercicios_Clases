using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        private float duracion;
        private string nroDestino;
        private string nroOrigen;
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Origen: {NroOrigen}, Destino: {NroDestino}, Duración {Duracion}");
            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int output = 0;
            if (llamada1.Duracion > llamada2.Duracion)
            {
                output = 1;
            }
            else if (llamada1.Duracion < llamada2.Duracion)
            {
                output = -1;
            }
            return output;
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public float Duracion
        {
            get
            {
                return this.Duracion;
            }
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas,
        }




    }


}
