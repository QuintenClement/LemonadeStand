using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        public Game game;
        public int moneyToSpend;
        public int chanceToBuyLemonade;
        public Customer()
        {
            Customer customer = new Customer();
        }
        
        //chance to buy = 50%
        //add or subtract based on weather or temp or recipe
        public void BuyLemonade()
        {
            
        }
        public void AmountToSpend()
        {
            Random rnd = new Random();
            int moneyToSpend = rnd.Next(3, 15);

        }
        public void TempEffectsOnSales()
        {
            Random rnd = new Random();
            int highChanceToBuy = rnd.Next(30, 100);
            int medChanceToBuy = rnd.Next(50, 100);
            int lowChanceToBuy = rnd.Next(1, 20);
            if (game.temperature > 85)
            {
                chanceToBuyLemonade = highChanceToBuy;
            }
            else if (game.temperature > 70 && game.temperature < 85)
            {
                chanceToBuyLemonade = medChanceToBuy;
            }
            else if (game.temperature < 70)
            {
                chanceToBuyLemonade = lowChanceToBuy;
            }
        }
    }
}
