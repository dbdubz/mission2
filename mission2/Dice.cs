using System;
using System.Collections.Generic;
using System.Text;

namespace mission2
{
    class Dice
    {
        private static int Die()
        {
            var rand = new Random();

            int die = rand.Next(1, 7);

            return die;
        }

        public static int Roll()
        {
            int roll;
            int dieA;
            int dieB;

            dieA = Die();
            dieB = Die();

            roll = dieA + dieB;

            return roll;
        }
    }
}
