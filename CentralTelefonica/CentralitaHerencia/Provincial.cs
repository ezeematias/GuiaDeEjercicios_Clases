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
            return 0;
        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3,
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendLine($"{base.Mostrar()}");
            // Abandono acá!!!!! /////////////////////////////////////////
            
            return "";
        }








    }
}
