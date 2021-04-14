using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {

        }

        public Centralita(string nombreEmpresa) :this()
        {

        }
        
        public float GananciasPorLocal
        {
            get
            {
                return 0;
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return 0;
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return 0;
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return Llamadas;
            }
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float output = 0;
            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    
                    break;
                case Llamada.TipoLlamada.Provincial:

                    break;
                case Llamada.TipoLlamada.Todas:

                    break;
            }
            return output;            
        }


        public string Mostrar()
        {
            return "";
        }

        public void OrdenarLlamadas()
        {

        }        
    }
}
