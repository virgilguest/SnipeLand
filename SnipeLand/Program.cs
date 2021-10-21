using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myUtilities;


namespace SnipeLand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SnipeLand";
            Console.WriteLine("No Twidget Ever Survives.\n");
            int myScore = 0;
            myWeapons screwdriver = new myWeapons(8, "Screw Driver", 10, false, 1);
            myPlayer player = new myPlayer("Jenkins PO3", 70, 5, 40, 40, 0);

        }
    }
}
