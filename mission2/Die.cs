using System;
using System.Collections.Generic;
using System.Text;

namespace mission2
{
    class Die
    {

    // Elements of an individual Die
        public int GetVal()
        {

        // Random number from 1 to 6 for the value and return
            var rand = new Random();
            int die = rand.Next(1, 7);
            return die;
        }
    }
}
