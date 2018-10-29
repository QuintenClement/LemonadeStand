using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public double money;
        public Inventory whatIGots;
        public int pitcher;
        public int cups = 10;
        public int lemonsUsed;

        public Player()
        {
            money = 20;
            whatIGots = new Inventory();
        }







        public void SetRecipe()
        {
            Console.WriteLine("How many lemons would you like to add to 1 pitcher of lemonade?");
            bool lemons = Int32.TryParse(Console.ReadLine(), out lemonsUsed);
            while (lemons == false)
            {
                Console.WriteLine("How many lemons would you like to add to 1 pitcher of lemonade?");
                lemons = Int32.TryParse(Console.ReadLine(), out lemonsUsed);
            }
            if (lemonsUsed > 10)
            {
                Console.WriteLine("Are you trying to make lemonade or lemon juice? Enter less lemons.");
                SetRecipe();
            }
            if (lemonsUsed >= 1 && lemonsUsed <= 9)
            {
                Console.WriteLine("You will use " + lemonsUsed + " for every pitcher of lemonade you need");
                whatIGots.lemons -= lemonsUsed;
            }
        }
    }
}
