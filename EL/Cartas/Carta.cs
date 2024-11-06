using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL.Cartas
{
    public abstract class Carta
    {
        public string name { get; set; }
        public string description { get; set; }
        public int cost { get; set; }
        public Tipo tipo { get; set; }

        public static Action<Carta> onCardDestroy;
        public void destruirCarta() 
        {
            
        }
    }
}
