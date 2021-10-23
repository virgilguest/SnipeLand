using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using myUtilities;


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
            int myScore = 0;

            // 1. Create a player

            //2. Create a weapon for the player

            //3. Add customization based on player

            //4. Create a loop for the room

            bool exit =false;
            do
            {
                //5. get a room description

                //6. create a monster in the room for the player to battle.

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
                            break;
                        case ConsoleKey.R:
                            break;
                        case ConsoleKey.P:
                            break;
                        case ConsoleKey.M:
                            break;
                        case ConsoleKey.X:
                            Console.WriteLine("Try again Twidget!");
                            exit = true;
                            break;
                        default:
                            break;

                    }
                } while (!exit && !reload);
            } while (!exit);

        }
    }
}
