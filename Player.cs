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
        public int lemonsUsed;
        public int sugarUsed;
        public int icePerCup;
        public int pricePerCup;
        
        

        public Player()
        {
            money = 50;
            whatIGots = new Inventory();
        }







        public void SetLemonsInRecipe()
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
                SetLemonsInRecipe();
            }
            if (lemonsUsed < 1)
            {
                Console.WriteLine("What is lemonade with out any lemons? Aids!? Enter more lemons.");
                SetLemonsInRecipe();
            }
            if (lemonsUsed >= 1 && lemonsUsed <= 9)
            {
                Console.WriteLine("You will use " + lemonsUsed + " lemons for every pitcher of lemonade you need");
                whatIGots.lemonsPerPitcher = lemonsUsed;
            }
        }

        public void SetSugarInRecipe()
        { 
            Console.WriteLine("How many cups of sugar would you like to add to 1 pitcher of lemonade?");
            bool sugar = Int32.TryParse(Console.ReadLine(), out sugarUsed);
            while (sugar == false)
            {
                Console.WriteLine("How many cups of sugar would you like to add to 1 pitcher of lemonade?");
                sugar = Int32.TryParse(Console.ReadLine(), out sugarUsed);
            }
            if (sugarUsed > 10)
            {
                Console.WriteLine("These are people you are selling to not bees. Use less sugar!");
                SetSugarInRecipe();
            }
            if (sugarUsed < 1)
            {
                Console.WriteLine("Who makes lemonade without sugar? .... What are you? A savage? Enter more sugar! ");
                SetSugarInRecipe();
            }
            if (sugarUsed >= 1 && sugarUsed <= 9)
            {
                Console.WriteLine("You will use " + sugarUsed + " cups of sugar for every pitcher of lemonade you need.");
                whatIGots.sugarPerPitcher = sugarUsed;
            }
        }
        public void SetIceInRecipe()
        {
            Console.WriteLine("How much ice would you like to add to each cup of lemonade?");
            bool ice = Int32.TryParse(Console.ReadLine(), out icePerCup);
            while (ice == false)
            {
                Console.WriteLine("How much ice would you like to add to each cup of lemonade?");
                ice = Int32.TryParse(Console.ReadLine(), out icePerCup);
            }
            if (icePerCup > 15)
            {
                Console.WriteLine("How much ice would you like to add to each cup of lemonade?");
                SetIceInRecipe();
            }
            if (icePerCup < 1)
            {
                Console.WriteLine("How much ice would you like to add to each cup of lemonade?");
                SetSugarInRecipe();
            }
            if (icePerCup >= 1 && icePerCup <= 14)
            {
                Console.WriteLine("You will use " + icePerCup + " ice cubes for every cup of lemonade made.");
                whatIGots.icePerPitcher -= icePerCup * 10;
            }
        }
        public void SetPrice()
        {
            Console.WriteLine("How much would you like to sell each cup of lemonade for?");
            bool price = Int32.TryParse(Console.ReadLine(), out pricePerCup);
            while (price == false)
            {
                Console.WriteLine("How much would you like to sell each cup of lemonade for?");
                price = Int32.TryParse(Console.ReadLine(), out pricePerCup);
            }
        }
    }
}
