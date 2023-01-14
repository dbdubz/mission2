using System;
using System.Collections.Generic;
using System.Text;

namespace mission2
{
    class Die
    {
        // Elements of an individual Die
        // Random number from 1 to 6 for the value
        public int GetVal()
        {
            var rand = new Random();
            int die = rand.Next(1, 7);
            return die;
        }
    }
}
