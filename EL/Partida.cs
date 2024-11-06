using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Partida
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public Jugador Jugador1 { get; set; }
        public Jugador Jugador2 { get; set; }
        public Jugador JugadorGanador { get; set; }
        public int IndiceJ1 { get; set; }
        public int IndiceJ2 { get; set; }
        public int Ronda { get; set; }

        private void Iniciar()
        {

        }

        private void AsignarRotación(Jugador Jugador)
        { 
            if (Jugador.MazoAct == null)
            {
                Random random = new Random();
                int indice = random.Next(1, Enum.GetValues(typeof(Tipo)).Length);
            }
        }
    }
}
