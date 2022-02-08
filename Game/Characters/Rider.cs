using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Characters
{
    class Rider : Character
    {
        public Rider()
        {
            base.HP = 100;
            base.Atack = 10;
            base.Defense = 7;
        }
        public override string ToString()
        {
            return $"Rider ({base.ToString()})";
        }
    }
}
