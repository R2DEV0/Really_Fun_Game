using System;
using System.Collections.Generic;

namespace Really_Fun_Game
{
    public class Character
    {
        // Attributes
        public bool IsAlive;
        public string Name;
        public int Strength;
        //strength bet 0 and 100
        public int Intelligence;
        //Intelligence bet 0 to 100
        public int Dexterity;
         //dexterity bet 0 and 100 
        public int Health;
        //health bet 1 and 100
        public int MaxHealth;
        public bool Laughing;
        public bool Crying;
        // Constructors
        public Character(string name)
        {
            this.IsAlive = true;
            this.Name = name;
            this.Strength = 3;
            this.Intelligence = 3;
            this.Dexterity = 3;
            this.Health = 100;
            this.MaxHealth = 100;
            this.Laughing = false;
            this.Crying = false;
        }
        // public Character(string name, int strength, int intelligence, int dexterity, int health)
        // {
        //     this.IsAlive = true;
        //     this.Name = name;
        //     this.Strength = strength;
        //     this.Intelligence = intelligence;
        //     this.Dexterity = dexterity;
        //     this.Health = health;
        //     this.MaxHealth = health;
        //     this.Laughing = false;
        //     this.Crying = false;
        // }
        // Methods
        public virtual void Attack(Character target)
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
                target.Health -= (5*this.Strength);
                Console.WriteLine($"{target.Name} has {target.Health} left!");
            }
        }
        public virtual void Tickle(Character target)
        {
            if(this.IsAlive == false)
            {
                Console.WriteLine($"Try as they might, {this.Name} doesn't have the strength left to even tickle!");
            }
            else if(target.IsAlive == false)
            {
                Console.WriteLine($"Show some mercy {this.Name}! {target.Name} is already down for the count!");
            }
            else
            {
                Console.WriteLine($"{this.Name} is tickling {target.Name}!");
                target.Laughing = true;
                Console.WriteLine($"{target.Name} has {target.Health} left!");
            }  
        }
        public virtual void Slap(Character target)
        {            
            if(this.IsAlive == false)
            {
                Console.WriteLine($"Try as they might, {this.Name} doesn't have the strength left to even fight!");
            }
            else if(target.IsAlive == false)
            {
                Console.WriteLine($"Show some mercy! Stop slapping! {this.Name}! {target.Name} is already down for the count!");
            }
            else
            {
                Console.WriteLine($"{this.Name} is slapping {target.Name}!");
                target.Health = target.Health-=(3*this.Strength);
                Console.WriteLine($"{target.Name} has {target.Health}HP left!");
            }
        }

        public virtual void SpecialMove(Character Target)
        {
            Console.WriteLine("This is a special move!");
        }
        // public void EatFood(Character target)
        // {
        //     public List<Character> Food = new List<Character>()
        //     {
        //         new Food("Baked Potato Soup", 35),
        //         new Food("nothing", 1),
        //         new Food("an apple with bruises", 30),
        //         new Food("bag o cookies", 25),
        //         new Food("Spicy Noodle", 15),
        //         new Food("bowl of Pho", 40),
        //         new Food("Flan", 10),
        //         new Food("Magic Beans", 50),
        //     };
        //     Random rand = new Random();
        //     Food item = this.Food[rand.Next(0,8)];

        //     if (target.Health < target.MaxHealth)
        //     {
        //         target.Health += food.HP;
        //         System.Console.WriteLine($"{target} ate {food.Name} and gained {food.HP} HP");
        //     }
        //     else
        //     {
        //         target.Health = target.MaxHealth;
        //         System.Console.WriteLine($"{target} is too full and at max health!");
        //     }
        // }
    }
}