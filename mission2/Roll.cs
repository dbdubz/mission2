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

        // Instance of die A
            Die dieA = new Die();

        // Instance of die B
            Die dieB = new Die();

        // Calculate roll value and return
            roll = dieA.GetVal() + dieB.GetVal();
            return roll;
        }
    }
}
