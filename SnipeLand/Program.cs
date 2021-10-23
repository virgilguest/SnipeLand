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
            Weapon pipewrench = new Weapon(8, "Pipe Wrench", 10, false, 1);

            // 1. Create a player
            Player player = new Player("Jenkins PO3", 70, 5, 40, 40, Race.MachinistMate, pipewrench);


            //3. Add customization based on player

            //4. Create a loop for the room

            bool exit = false;
            do
            {

                //5. get a room description
                Console.WriteLine(GetRoom());

                //6. create a monster in the room for the player to battle.
                Rabbit r1 = new Rabbit(); //default ctor that sets some values by default
                Rabbit r2 = new Rabbit("Hull Technician", 25, 25, 50, 20, 2, 8, "Thats no ordinary Hull Tech..look at the stripes!", true);

                Monster[] monsters = { r1, r2, r2, r1, r1 }; //since all monster types will be a child of type monster, I can store them in

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
                            Console.WriteLine("Thou hast chosen an improper option. Triest thou again....");
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
                "The room is dark and musty with the smell of lost souls.",
                "You enter a pretty pink powder room and instantly get glitter on you.",
                "You arrive in a room filled with chairs and a ticket stub machine...DMV",
                "You enter a quiet library... silence... nothing but silence....",
                "As you enter the room, you realize you are standing on a platform surrounded by sharks",
                "Oh my.... what is that smell? You appear to be standing in a compost pile",
                "You enter a dark room and all you can hear is hair band music blaring.... This is going to be bad!",
                "Oh no.... the worst of them all... Oprah's bedroom....",
                "The room looks just like the room you are sitting in right now... or does it?"
            };

            Random rand = new Random();
            int indexNbr = rand.Next(rooms.Length);

            string room = rooms[indexNbr];

            return room;
        }
    }
}

