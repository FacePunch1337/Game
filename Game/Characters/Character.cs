using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Characters
{
    abstract class Character
    {
        public int HP { get; set; }
        public int Atack { get; set; }
        public int Defense { get; set; }

        public override string ToString()
        {

            return String.Format("HP: {0}, Atack: {1}, Defense: {2}",
                HP, Atack, Defense);
        }

        public static int operator * (Character c1, Character c2)
        {
            int damage1 = c2.Atack - c1.Defense;
            if (damage1 > 0) c1.HP -= damage1;
            else c1.HP -= 1;

            int damage2 = c2.Atack - c1.Defense;
            if (damage2 > 0) c1.HP -= damage2;
            else c1.HP -= 1;
            return damage1 + damage2;
        }

        
            
    }
}
