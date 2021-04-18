using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
    //
    // Interface used by Npc and Item. Polymorphism allows different logic depending on what class uses the interface.
    // In general, the logic will determine if your lost a life based on a set of hard-coded percentages. 
    //
    interface ILifeIsRandom
    {
        int CheckForLifeLost();
    }
}
