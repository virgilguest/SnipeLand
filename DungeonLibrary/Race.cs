using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //We cannot add an ENUM directly using VS. 
    //We have to make a class and then change the word class below to "enum"
    //Remember to make it public
    public enum Race
    {
        //enum is a list of constant values
        //single values, no spaces in the value, comma separated
        MachinistMate,
        BoilerTechnician,
        EngineMan,
        HullTechnician
    }
}
