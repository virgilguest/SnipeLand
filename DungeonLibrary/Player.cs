﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //The sealed keyword means that this is the end of the inheritance chain. It is now impossible to setup a child of Player.
    public sealed class Player : Character
    {
        //fields
        //No fields because the info specific to Player does NOT need biz rules

        //Props
        public PlayerRace CharacterRace { get; set; }
        //We need our player to have a weapon. I want this weapon to be made up of many attributes (i.e. kind, is two handed, etc) so I need to 
        //make a custom data type class for weapon
        public Weapon EquippedWeapon { get; set; }
        
        
        //Ctors
        public Player(string name, int hitChance, int block, int life, int maxLife, PlayerRace characterRace, Weapon equippedWeapon)
        {
            //Since Life depends on MaxLife we will set a value for MaxLife first
            MaxLife = maxLife;
            Name = name;
            HitChance = hitChance;
            Block = block;
            Life = life; 
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;

            switch (CharacterRace)
            {
                case PlayerRace.ElectronicsTechnician:
                    break;
                case PlayerRace.Radioman:
                    HitChance += 5; 
                    break;
                case PlayerRace.Signalman:
                    break;
            }
        }

        //Methods
        public override string ToString()
        {
            string description = "";

            switch (CharacterRace)
            {
                case PlayerRace.ElectronicsTechnician:
                    description = "Electronics Technician";
                    break;
                case PlayerRace.Radioman:
                    description = "Radioman"; 
                    break;
                case PlayerRace.Signalman:
                    description = "Signalman";
                    break;
            }

            return string.Format($"----{Name}-----\n" +
                $"Life: {Life} of {MaxLife}\n" +
                $"Hit Chance: {CalcHitChance()}%\n" +
                $"Weapon:\n{EquippedWeapon}\n" +
                $"Block: {Block}\n" +
                $"Description:\n{description}"); 
        }


        public override int CalcDamage()
        {
            //return base.CalcDamage(); This just gives us 0. 

            //Create a random object
            Random rand = new Random();

            //determine damage
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);

            return damage; 
        }


        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }
    }
}
