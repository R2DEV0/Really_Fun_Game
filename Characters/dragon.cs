using System;

namespace Really_Fun_Game
{
    class Dragon : Enemy
    {
        public Dragon(string name, string location): base(name, location)
        {
            Health = 500;
            Strength = 50;
            Intelligence = 5;
        }
        public void FireAttack(Character target)
        {
            target.Health -= 25;
            System.Console.WriteLine($"a dragon just rained fire on {target.Name}!");
            if(target.Health <= 0)
            {
                System.Console.WriteLine($"the dragon then ate {target.Name}");
            }
        }
    }
}