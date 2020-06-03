using System;

namespace Really_Fun_Game
{
    class Troll : Enemy{
        int Salt;
        int Regen; 
        public Troll(string name, string location) : base(name, location){
            Health=300;
            Salt=10;
            Regen=10;
            Strength=30;
            Intelligence=2;
        }
        public int Regenerate(){
            Random rand = new Random();
            int recover=rand.Next(0,3)*Regen;
            this.Health+=recover;
            return recover;
        }
        public void AsSalt(Character target){
            target.Health-=3*Salt;           
            target.Health-=3*target.Strength;
            Console.WriteLine($"Troll makes {target.Name} very salty! They hurt themselves in their apopletic rage");
            int amount = Regenerate();
            Console.WriteLine($"Trollolol, your frustration feeds him! Troll regenerates {amount} health! ");
        }
    }
} 
