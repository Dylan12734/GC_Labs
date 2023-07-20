using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_roll_lab
{
    public class TheGuts
    {
        public static int rng(int i)
        {
            Random random = new Random();
            return random.Next(1, i + 1);
        }

    }
}
