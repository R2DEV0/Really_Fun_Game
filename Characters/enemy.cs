using System;

namespace Really_Fun_Game
{
    class Enemy : Character{

        private bool EncounterStart;
        private string Location;
        public Enemy(string name, string location): base(name){
            this.Health=70;
            this.EncounterStart=false;
            this.Location=location;
        }

        private int Ambush(Character target, bool EncounterStart ){
            if (this.EncounterStart==false){
                target.Health-=(10*this.Strength);
                this.EncounterStart=true;
            }
            return target.Health;
        }
    }



}