using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Mazo MazoAct { get; set; }
        public Queue<Mazo> Mazos { get; set; }

    }
}
