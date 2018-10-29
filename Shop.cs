using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Shop
    {
        public int lemonsToBuy;
        public int ice;
        public int sugar;
        public int cups;

        public void BuyLemons(Player player)
        {
            Console.WriteLine("How many lemons would you like to buy? $3.5/each");
            bool test = Int32.TryParse(Console.ReadLine(), out lemonsToBuy);
            while (test == false)
            {
                Console.WriteLine("How many lemons would you like to buy? $3.5/each");
                test = Int32.TryParse(Console.ReadLine(), out lemonsToBuy);
            }
            player.whatIGots.lemons += lemonsToBuy;
            player.money -= (lemonsToBuy * 3.5);

        }

        public void BuyIce(Player player)
        {
            Console.WriteLine("How many Ice cubes would you like to buy? $5/100 Ice cubes");
            bool test = Int32.TryParse(Console.ReadLine(), out ice);
            while (test == false)
            {
                Console.WriteLine("How many Ice cubes would you like to buy? $5/100 Ice cubes");
                test = Int32.TryParse(Console.ReadLine(), out ice);
            }
            player.whatIGots.icePerPitcher += ice;
            player.money -= (ice * .05);
        }
        public void BuyCups(Player player)
        {
            Console.WriteLine("How many cups would you like to buy? $4/25 cups");
            bool test = Int32.TryParse(Console.ReadLine(), out cups);
            while (test == false)
            {
                Console.WriteLine("How many cups would you like to buy? $4/25 cups");
                test = Int32.TryParse(Console.ReadLine(), out cups);
            }
            player.whatIGots.cups += cups;
            player.money -= (cups * .16);
        }
        public void BuySugar(Player player)
        {
            Console.WriteLine("How much sugar would you like to buy? $1.5/2 cups of sugar");
            bool test = Int32.TryParse(Console.ReadLine(), out sugar);
            while (test == false)
            {
                Console.WriteLine("How much sugar would you like to buy? $1.5/2 cups");
                test = Int32.TryParse(Console.ReadLine(), out sugar);
            }
            player.whatIGots.sugar += sugar;
            player.money -= (sugar * .75);
        }
    }

}

