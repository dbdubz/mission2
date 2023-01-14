using System;
using System.Collections.Generic;
using System.Text;

namespace mission2
{
    class Roll
    {
        // Defines what a roll is
        // Creates an instace of 2 dice (a and b), adds them together and return the roll total
        public int Total()
        {
            int roll;

            Die dieA = new Die();     // Instance of die A
            Die dieB = new Die();     // Instance of die B

            roll = dieA.GetVal() + dieB.GetVal();

            return roll;
        }
    }
}
