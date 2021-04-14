using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;
        public Provincial(Franja miFranja, Llamada llamada) : base (llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : this(miFranja, new Llamada(duracion, destino, origen))
        {
            this.franjaHoraria = miFranja;
        }

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            float output = 0;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    output = this.Duracion * 0.99F;
                    break;
                case Franja.Franja_2:
                    output = this.Duracion * 1.25F;
                    break;
                case Franja.Franja_3:
                    output = this.Duracion * 0.66F;
                    break;
            }
            return output;
        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3,
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Costo:{this.CostoLlamada}, {this.franjaHoraria}");
            return sb.ToString();
        }

    }
}
