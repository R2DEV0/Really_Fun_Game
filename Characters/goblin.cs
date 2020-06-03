using System;

namespace Really_Fun_Game
{
    class Goblin : Enemy{
        public Goblin(string name, string location): base(name, location){
            this.Health=50;
        }
    }
}