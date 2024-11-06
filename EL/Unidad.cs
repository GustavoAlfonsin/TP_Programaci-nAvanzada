using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public abstract class Unidad
    {
        protected int hp { get; set; }

        protected int damage { get; set; }

        public abstract void Effect();

    }
}
