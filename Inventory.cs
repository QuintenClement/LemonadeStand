using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public int lemons = 0;
        public int icePerPitcher = 0;
        public int cups = 0;
        public int sugar = 0;
        public int ice = 0;
        public int lemonsPerPitcher;
        public int sugarPerPitcher;
        public int pitchers = 0;

        public Inventory()
        {

        }

        public bool NeedNewPitcher()
        {
            if (lemons > lemonsPerPitcher && sugar > sugarPerPitcher && ice > icePerPitcher && cups % 10 == 0)
            {
                lemons -= lemonsPerPitcher;
                sugar -= sugarPerPitcher;
                ice -= icePerPitcher;
                return true;
            }
            else
            {
                return false;
            }
        }







    }


}
