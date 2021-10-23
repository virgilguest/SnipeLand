using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        //fields
        private int _minDamage;
        //propfull + tab + tab


        //props
        public int MaxDamage { get; set; }
        public string Description { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1; 
                }
            }
        }

        //ctors
        public Monster()
        {
            //default ctor
        }

        public Monster(string name, int life, int maxLife, int hitChance, int block, int maxDamage, string description, int minDamage)
        {
            MaxLife = maxLife; 
            MaxDamage = maxDamage;
            Name = name;
            Life = life;
            HitChance = hitChance;
            Block = block; 
            Description = description;
            MinDamage = minDamage;
        }
        //methods
        public override string ToString()
        {
            return string.Format($"\n******MONSTER*******\n" +
                $"{Name}\n" +
                $"Life: {Life} of {MaxLife}\n" +
                $"Damage: {MinDamage} to {MaxDamage}\n" +
                $"Block: {Block}\n" +
                $"Description:\n{Description}\n"); 
        }

        //Override the base functionality for calcDamage() to use the MinDamage and MaxDamage properties from this class
        public override int CalcDamage()
        {
            //return base.CalcDamage(); - this just returns 0
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1); 
        }
    }
}
