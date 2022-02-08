using System;

namespace Game
{
    class Services
    {
        public static Random random = new Random();

    }
    class Program
    {
        static void Main(string[] args)
        {
            //new World().Go();
            var world = new World();
            //var world = new World();
            int i1 = Services.random.Next(5);
            int i2 = Services.random.Next(5);

            do { i2 = Services.random.Next(5); } while (i2 == i1);

            int damage = world[i1] * world[i2];
            Console.WriteLine($"{i1} vs {i2}: {world[i1]} {world[i2]}");
       
            
        }
    }
}
