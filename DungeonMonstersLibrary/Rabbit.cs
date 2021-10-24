using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary; 

namespace DungeonMonstersLibrary
{
    public class Rabbit : Monster
    {
        //properties
        public bool IsFluffy { get; set; }

        //ctor
        //FQ Ctor
        public Rabbit(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isFluffy) : base(name, life, maxLife, hitChance, block, maxDamage, description, minDamage)
        {
            IsFluffy = isFluffy; 
        }

        //we will make a custom default ctor - it will accept NO parameters but it will set some default values in the body of the method
        public Rabbit()
        {
            //default values 
            MaxLife = 1;
            MaxDamage = 1;
            Name = "E1 Hull Tech";
            Life = 1;
            HitChance = 1;
            Block = 1;
            MinDamage = 1;
            Description = "Fresh out of boot camp, and inexperienced.";
            IsFluffy = false; 
        }


        //methods 
        public override string ToString()
        {
            return base.ToString() + (IsFluffy ? "Fluffy" : "Not so fluffy..."); 
        }

        public override int CalcBlock()
        {
            //We will use IsFluffy to determine if the monster gets a boost to their block ability
            int calculatedBlock = Block;

            if (IsFluffy)
            {
                calculatedBlock += calculatedBlock / 2; //this gives the monster a 50% boost if they are fluffy
            }

            return calculatedBlock; 
        }
    }
}
 