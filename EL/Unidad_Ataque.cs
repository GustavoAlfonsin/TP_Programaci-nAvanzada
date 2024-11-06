using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Unidad_Ataque : Unidad
    {
        public void ChangeHP(int value)
        {
            hp -= value; //valor negativo para curar

            if(hp < 0)
            {
                hp = 0;
            }
        }

        public override void Effect()
        {
            throw new NotImplementedException();
        }
    }
}
