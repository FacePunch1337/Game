using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class World
    {
        List<Characters.Character> characters;
        //Random random;

        public World()
        {
           // random = new Random();
            characters = new List<Characters.Character>();

            for (int i = 0; i < 5; i++)
            {
                switch (Services.random.Next(2))
                {
                    case 0: characters.Add(new Characters.Archer()); break;
                    case 1: characters.Add(new Characters.Rider()); break;
                    default: characters.Add(new Characters.Wizard()); break;
                }
            }
        }

        public override string ToString()
        {   
            
            var sb = new StringBuilder();
            foreach (var ch in characters)
            {
                sb.Append(ch);
                sb.Append('\n');
            }
            return sb.ToString();
        }

        public void Go()
        {
            Console.WriteLine(this);

            int res = characters[0] * characters[1];

            Console.WriteLine(this);
        }

        public Characters.Character this[int i]
        {
            get
            {
                return characters[0];
            }
        }
    }
}
