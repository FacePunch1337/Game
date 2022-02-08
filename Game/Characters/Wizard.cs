﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Characters
{
    class Wizard : Character
    {
        public Wizard()
        {
            base.HP = 100;
            base.Atack = 7;
            base.Defense = 10;
        }
        public override string ToString()
        {
            return $"Wizard ({base.ToString()})";
        }

    }
}
