using System;

namespace Really_Fun_Game
{
    class Wizard : Character{
        // Constructors
        public Wizard(string name) : base(name)
        {
            
            this.Intelligence = 90;
           
        }
        

        // Methods
        public override void Attack(Character target)
        {
            if(this.IsAlive == false)
                {
                    Console.WriteLine($"{this.Name} opens their eyes. Attempts to get up. {this.Name}'s can't pull themself up. {this.Name} has died!");
                }
                else if(this == target)
                {
                    Console.Write($"{this.Name} draws their wand and lightening emits from the tip with a crackling sound. Perhaps standing under the wand is not a good idea. Attacking oneself isn't a good strategy.");
                }
                else if(target.IsAlive == false)
                {
                    Console.WriteLine($"Show some mercy {this.Name}! You can only turn {target.Name} into so many different animals!");
                }
                else
                {
                    Console.WriteLine($"{this.Name} spells {target.Name} into their older self!");
                    target.Health = target.Health-(5*this.Strength);
                    if(target.Health < 50)
                    {
                        target.Health = 0;
                        target.IsAlive = false;
                    }
                    Console.WriteLine($"{target.Name} has {target.Health}HP left!");
                }
        }

        public override void SpecialMove(Character target)
        {
            if(this.IsAlive == false)
            {
                Console.WriteLine($"Nice try, {this.Name} but even a wizard can't meditate out of death!");
            }
            else
            {
                this.Health = this.MaxHealth;
            }
        }
    }
}