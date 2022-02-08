using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Characters
{
    class Archer : Character
    {
        public Archer()
        {
            base.HP = 100;
            base.Atack = 10;
            base.Defense = 7;
          
        }
        public override string ToString()
        {
            return $"Archer ({base.ToString()})";
        }


    }
}
