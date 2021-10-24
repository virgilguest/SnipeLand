using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
using DungeonMonstersLibrary;



namespace SnipeLand
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
             Snipe - Crew members in the engineering rates; someone who works in the engineering spaces and seldom is seen topside when underway. MM's (Machinist's Mates) and BT's (Boiler Technicians) are ultimate snipes. In today's modern gas turbine fleet, also includes GSM (Gas Turbine Specialist, Mechanic), GSE (Gas Turbine Specialist, Electrician), and EN (Engineman). It is believed that true snipes cannot stand direct sunlight or fresh air, must have machine oil in their coffee in order to survive, and get nosebleeds at altitudes above the waterline. It is also firmly believed that fresh-air sailors who venture into SNIPE COUNTRY are never seen again. Aka BLACK-HAND GANG (RN), BLACK GANG. See STOKER (RN).

            Snipe Country - The engineering spaces, bilges, and voids where the snipes dwell. Considered to be extremely dangerous territory for non-snipes. "The snipes will get you" is commonly used to deter sailors from going too far below decks.

            Twidget - Any of the electronics/computer/communications technicians.
             
             https://www.hazegray.org/faq/slang2.htm
             
             */
            Console.Title = "SnipeLand";
            Console.WriteLine("Snipe Country - The engineering spaces, bilges, and voids where the snipes dwell.\nConsidered to be extremely dangerous territory for non-snipes.\n'The snipes will get you' is commonly used to deter sailors from going too far below decks.");
            Console.WriteLine("The snipes are going to get you.\n");
            int score = 0;

            //2. Create a weapon for the player
            Weapon multimeter = new Weapon(8, "Multimeter", 10, false, 1);


            // 1. Create a player
            // give them the ability to choose a player.
            Console.WriteLine("\nPlease choose a Player:\n" +
   "A) E-1 Seaman Recruit\n" +
   "B) E-2 Seaman Apprentice\n" +
   "C) E-3 Seaman\n" +
   "D) E-4 Third Class Petty Officer\n" +
   "E) E-5 Second Class Petty Officer\n" +
   "F) E-6 First Class Petty Officer\n" +
   "G) E-7 Chief Petty Officer\n" +
   "H) E-8 Senior Chief Petty Officer\n" +
   "I) E-9 Master Chief Petty Officer\n");
            //9. Capture user choice
            ConsoleKey playerChoice = Console.ReadKey(true).Key;
            Console.Clear();

            bool pexit = false;
            string choice1 = "";
            int choice2 = 1;
            int choice3 = 1;
            int choice4 = 1;
            int choice5 = 1;
            //string choice6;
            //10, do something based on users input

            do
            {
                switch (playerChoice)

                {
                    case ConsoleKey.A:
                        //MaxLife = maxLife;
                        //Name = name;
                        //HitChance = hitChance;
                        //Block = block;
                        //Life = life;
                        //CharacterRace = characterRace;
                        //EquippedWeapon = equippedWeapon;
                        choice1 = "E-1 Electronics Technician";
                        choice2 = 1;
                        choice3 = 1;
                        choice4 = 1;
                        choice5 = 1;
                        pexit = true;
                        break;
                    case ConsoleKey.B:
                        choice1 = "E-2 Electronics Technician";
                        choice2 = 2;
                        choice3 = 2;
                        choice4 = 2;
                        choice5 = 2;
                        pexit = true;
                        break;

                    case ConsoleKey.C:
                        choice1 = "E-3 Electronics Technician";
                        choice2 = 3;
                        choice3 = 3;
                        choice4 = 3;
                        choice5 = 3;
                        pexit = true;
                        break;

                    case ConsoleKey.D:
                        choice1 = "E-4 Electronics Technician";
                        choice2 = 4;
                        choice3 = 4;
                        choice4 = 4;
                        choice5 = 4;
                        pexit = true;
                        break;

                    case ConsoleKey.E:
                        choice1 = "E-5 Electronics Technician";
                        choice2 = 5;
                        choice3 = 5;
                        choice4 = 5;
                        choice5 = 5;
                        pexit = true;
                        break;

                    case ConsoleKey.F:
                        choice1 = "E-6 Electronics Technician";
                        choice2 = 6;
                        choice3 = 6;
                        choice4 = 6;
                        choice5 = 6;
                        pexit = true;
                        break;

                    case ConsoleKey.G:
                        choice1 = "E-7 Electronics Technician";
                        choice2 = 7;
                        choice3 = 7;
                        choice4 = 7;
                        choice5 = 7;
                        pexit = true;
                        break;

                    case ConsoleKey.H:
                        choice1 = "E-8 Electronics Technician";
                        choice2 = 8;
                        choice3 = 8;
                        choice4 = 8;
                        choice5 = 8;
                        pexit = true;
                        
                        break;

                    case ConsoleKey.I:
                        choice1 = "E-9 Electronics Technician";
                        choice2 = 9;
                        choice3 = 9;
                        choice4 = 9;
                        choice5 = 9;
                        pexit = true;
                        break;
                }

            } while (!pexit);
            //build it now
            Player player = new Player(choice1,  choice2 , choice3, choice4, choice5, PlayerRace.ElectronicsTechnician, multimeter);





            //Player player = new Player("E-1 Electronics Technician", 1, 1, 1, 1, PlayerRace.ElectronicsTechnician, multimeter);


            //3. Add customization based on player

            //4. Create a loop for the room

            bool exit = false;
            do
            {

                //5. get a room description
                Console.WriteLine(GetRoom());

                //6. create a monster in the room for the player to battle.
                Rabbit r1 = new Rabbit(); //default ctor that sets some values by default
                Rabbit r2 = new Rabbit("E2 Hull Tech", 2, 2, 2, 2, 2, 2, "Barely out of boot camp and inexperienced.", false);
                Rabbit r3 = new Rabbit("E3 Hull Tech", 3, 3, 3, 3, 3, 3, "Almost a petty officer but inexperienced.", false);
                Rabbit r4 = new Rabbit("PO3 Hull Tech", 4, 4, 4, 4, 4, 4, "A freshly minted 3rd class petty officer.", false);
                Rabbit r5 = new Rabbit("PO2 Hull Tech", 5, 5, 5, 5, 5, 5, "A 2nd class petty officer, be careful.", false);
                Rabbit r6 = new Rabbit("PO1 Hull Tech", 6, 6, 6, 6, 6, 6, "A 1st class petty officer, Watch Out.", false);
                Rabbit r7 = new Rabbit("Chief Hull Tech", 7, 7, 7, 7, 7, 7, "A Chief petty officer, Move Out Of The Way.", false);
                Rabbit r8 = new Rabbit("Senior Chief Hull Tech", 8, 8, 8, 8, 8, 8, "A Senior Chief petty officer, Stand Aside.", false);
                Rabbit r9 = new Rabbit("Master Chief Hull Tech", 8, 8, 8, 8, 8, 8, "A Master Chief petty officer, Run.", false);
                Rabbit r10 = new Rabbit(); //default ctor that sets some values by default
                Rabbit r11 = new Rabbit("E2 Machinist Mate", 2, 2, 2, 2, 2, 2, "Barely out of boot camp and inexperienced.", false);
                Rabbit r12 = new Rabbit("E3 Machinist Mate", 3, 3, 3, 3, 3, 3, "Almost a petty officer but inexperienced.", false);
                Rabbit r13 = new Rabbit("PO3 Machinist Mate", 4, 4, 4, 4, 4, 4, "A freshly minted 3rd class petty officer.", false);
                Rabbit r14 = new Rabbit("PO2 Machinist Mate", 5, 5, 5, 5, 5, 5, "A 2nd class petty officer, be careful.", false);
                Rabbit r15 = new Rabbit("PO1 Machinist Mate", 6, 6, 6, 6, 6, 6, "A 1st class petty officer, Watch Out.", false);
                Rabbit r16 = new Rabbit("Chief Machinist Mate", 7, 7, 7, 7, 7, 7, "A Chief petty officer, Move Out Of The Way.", false);
                Rabbit r17 = new Rabbit("Senior Chief Machinist Mate", 8, 8, 8, 8, 8, 8, "A Senior Chief petty officer, Stand Aside.", false);
                Rabbit r18 = new Rabbit("Master Chief Machinist Mate", 8, 8, 8, 8, 8, 8, "A Master Chief petty officer, Run.", false);
                Rabbit r19 = new Rabbit(); //default ctor that sets some values by default
                Rabbit r20 = new Rabbit("E2 Boiler Tech", 2, 2, 2, 2, 2, 2, "Barely out of boot camp and inexperienced.", false);
                Rabbit r21 = new Rabbit("E3 Boiler Tech", 3, 3, 3, 3, 3, 3, "Almost a petty officer but inexperienced.", false);
                Rabbit r22 = new Rabbit("PO3 Boiler Tech", 4, 4, 4, 4, 4, 4, "A freshly minted 3rd class petty officer.", false);
                Rabbit r23 = new Rabbit("PO2 Boiler Tech", 5, 5, 5, 5, 5, 5, "A 2nd class petty officer, be careful.", false);
                Rabbit r24 = new Rabbit("PO1 Boiler Tech", 6, 6, 6, 6, 6, 6, "A 1st class petty officer, Watch Out.", false);
                Rabbit r25 = new Rabbit("Chief Boiler Tech", 7, 7, 7, 7, 7, 7, "A Chief petty officer, Move Out Of The Way.", false);
                Rabbit r26 = new Rabbit("Senior Chief Boiler Tech", 8, 8, 8, 8, 8, 8, "A Senior Chief petty officer, Stand Aside.", false);
                Rabbit r27 = new Rabbit("Master Chief Boiler Tech", 8, 8, 8, 8, 8, 8, "A Master Chief petty officer, Run.", false);
                Rabbit r28 = new Rabbit(); //default ctor that sets some values by default
                Rabbit r29 = new Rabbit("E2 Engineman", 2, 2, 2, 2, 2, 2, "Barely out of boot camp and inexperienced.", false);
                Rabbit r30 = new Rabbit("E3 Engineman", 3, 3, 3, 3, 3, 3, "Almost a petty officer but inexperienced.", false);
                Rabbit r31 = new Rabbit("PO3 Engineman", 4, 4, 4, 4, 4, 4, "A freshly minted 3rd class petty officer.", false);
                Rabbit r32 = new Rabbit("PO2 Engineman", 5, 5, 5, 5, 5, 5, "A 2nd class petty officer, be careful.", false);
                Rabbit r33 = new Rabbit("PO1 Engineman", 6, 6, 6, 6, 6, 6, "A 1st class petty officer, Watch Out.", false);
                Rabbit r34 = new Rabbit("Chief Engineman", 7, 7, 7, 7, 7, 7, "A Chief petty officer, Move Out Of The Way.", false);
                Rabbit r35 = new Rabbit("Senior Chief Engineman", 8, 8, 8, 8, 8, 8, "A Senior Chief petty officer, Stand Aside.", false);
                Rabbit r36 = new Rabbit("Master Chief Engineman", 8, 8, 8, 8, 8, 8, "A Master Chief petty officer, Run.", false);


                Monster[] monsters = { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27, r28, r29, r30, r31, r32, r33, r34, r35, r36 }; //since all monster types will be a child of type monster, I can store them in

                //randomly selecting a monster for the room
                Random rand = new Random();
                int randomNbr = rand.Next(monsters.Length);
                Monster monster = monsters[randomNbr];

                Console.WriteLine("\nIn this room: " + monster.Name);

                //7. create a loop for the user choice menu.
                bool reload = false;
                do
                {
                    //8. create a menu of options
                    Console.WriteLine("\nPlease choose an action:\n" +
                       "A) Attack\n" +
                       "R) Run Away\n" +
                       "P) Player Info\n" +
                       "M) Monster Info\n" +
                       "X) Exit\n");
                    //9. Capture user choice
                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    Console.Clear();
                    //10, do something based on users input
                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            Combat.DoBattle(player, monster);
                            if (monster.Life <= 0)
                            {
                                //its dead!
                                //POssible Customization: here you could have logic for the player to collect items like loot
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nYou killed {0}!\n", monster.Name);
                                Console.ResetColor();
                                reload = true; //breaks us out of the loop to get a new room and new monster
                                score++;
                            }

                            break;
                        case ConsoleKey.R:
                            Console.WriteLine($"{monster.Name} attacks you as you flee!");
                            Combat.DoAttack(monster, player); //free attack
                            Console.WriteLine();
                            reload = true; //load a new room

                            break;
                        case ConsoleKey.P:
                            Console.WriteLine("Player Info");
                            //14. Write out player info to screen
                            Console.WriteLine(player);

                            break;
                        case ConsoleKey.M:
                            Console.WriteLine("Monster Info");
                            //15. Write out monster info to screen
                            Console.WriteLine(monster);

                            break;
                        case ConsoleKey.X:
                            Console.WriteLine("Try again Twidget!");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("You can't get there from here.");
                            break;

                    }
                    //TODO 16. Check the players life
                    if (player.Life <= 0)
                    {
                        Console.WriteLine("Dude.... you died!");
                        exit = true; //breaks out of both loops
                    }

                } while (!exit && !reload);
            } while (!exit);
            Console.WriteLine("You defeated " + score + " monster" + (score == 1 ? "." : "s."));

        }

        private static string GetRoom()
        {
            string[] rooms =
            {
                "Storerooms; issue rooms; refrigerated compartments.",
                "Cargo holds and cargo refrigerated compartments.",
                "CIC room; plotting rooms, communication centers; radio, radar, and sonar operating spaces; pilot house.",
                "Main propulsion spaces; boiler rooms; evaporator rooms; steering gear rooms; auxiliary machinery spaces; pumprooms; generator rooms; switchboard rooms; windlass rooms.",
                "Fuel-oil, diesel-oil, lubricating-oil, and fog-oil compartments.",
                "Compartments carrying various types of oil as cargo.",
                "Gasoline tanks, cofferdams, trunks, and pumprooms.",
                "Gasoline compartments for carrying gasoline as cargo.",
                "Chemicals, semisafe materials, and dangerous materials carried for ship's use or as cargo.",
                "Berthing and messing spaces; staterooms, washrooms, heads, brigs; sickbays, hospital spaces; and passageways.",
                "Magazines; handling rooms; turrets; gun mounts; shell rooms; ready service rooms ; clipping rooms.",
                "Shops; offices; laundry;. galley; pantries; unmanned engineering, electrical, and electronic spaces.",
                "Escape trunks or tubes.",
                "Cofferdam compartments (other than gasoline); void wing compartments; wiring trunks.",
                "Drainage tanks; fresh water tanks; peak tanks; reserve feed tanks."

            };

            Random rand = new Random();
            int indexNbr = rand.Next(rooms.Length);

            string room = rooms[indexNbr];

            return room;
        }
    }
}

