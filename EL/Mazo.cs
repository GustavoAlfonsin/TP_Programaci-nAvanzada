using EL.Cartas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Mazo
    {
        public int id {  get; set; }
        public int idJugador { get; set; }
        public Tipo tipo { get; set; }
        public List<Carta> cartas { get; set; }

        public Mazo()
        {
            Carta.onCardDestroy += removerCarta;
        }

        private void removerCarta(Carta carta)
        {
            throw new NotImplementedException();
        }
    }
}
