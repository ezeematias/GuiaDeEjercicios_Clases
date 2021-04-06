using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Baraja
    {
        Carta[] cartas = new Carta[48];
        public Baraja()
        {
            int i = 0;
            foreach (Carta.Palo item in Carta.Palo.GetValues(typeof(Carta.Palo)))
            {
                foreach (Carta.Valor valorActual in Carta.Palo.GetValues(typeof(Carta.Valor)))
                {
                    cartas[i] = new Carta(valorActual, item);
                    i++;
                    Console.WriteLine("Palo: " + item + "Valor: " + valorActual);
                }
            }
        }
    }
}
