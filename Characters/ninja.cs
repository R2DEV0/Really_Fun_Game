using System;

namespace Really_Fun_Game
{
    class Ninja : Character{

        public Ninja(string name) : base(name){
            this.Dexterity=10;
        }
        public override void Attack(Character target)
        {
            if(this.IsAlive == false)
            {
                Console.WriteLine($"Try as they might, {this.Name} doesn't have the strength left to fight!");
            }
            else if(target.IsAlive == false)
            {
                Console.WriteLine($"Show some mercy {this.Name}! {target.Name} is already down for the count!");
            }
            else
            {
                Console.WriteLine($"{this.Name} is attacking {target.Name}!");
                target.Health -= (5*this.Dexterity);
                Console.WriteLine($"{target.Name} has {target.Health}HP left!");
            }
        }
        public override void SpecialMove(Character target){
            target.Health-=this.Dexterity;
            this.Health+=this.Dexterity;
            Console.WriteLine($"{this.Name} stole {this.Dexterity} health from {target.Name}!");
            
        }
    }
} 
