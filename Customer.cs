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
        public Day day;
        public Player player;
        public Customer()
        {
            Customer customer = new Customer();
        }
        
        //chance to buy = 50%
        //add or subtract based on weather or temp or recipe
        public void BuyLemonade(Player player)
        {
            Random random = new Random();
            int buyOrNot = random.Next(1, 100);
            if (buyOrNot > chanceToBuyLemonade)
            {
                day.cupsSold++;
                player.money += player.pricePerCup;
                day.customerCount++;
                player.whatIGots.cups--;
            }
        }
        public void TemperatureEffectsOnSales()
        {
            Random rnd = new Random();
            int highChanceToBuy = rnd.Next(1, 33);
            int medChanceToBuy = rnd.Next(1, 58);
            int lowChanceToBuy = rnd.Next(1, 80);
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
