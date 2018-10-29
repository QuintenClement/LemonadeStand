using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        public int moneyToSpend;
        public int chanceToBuyLemonade;

        public Customer customer = new Customer();
        //chance to buy = 50%
        //add or subtract based on weather or temp or recipe
        public void BuyLemonade()
        {

        }
        public void AmountToSpend()
        {
            Random rnd = new Random();
            int moneyToSpend = rnd.Next(0, 15);

        }
        public void WantForLemonade()
        {
            Random rnd = new Random();
            int lowChanceToBuy = rnd.Next(1, 12);
            int medChanceToBuy = rnd.Next(1, 6);
            int highChanceToBuy = rnd.Next(1, 2);
            if (moneyToSpend > 0 && moneyToSpend < 5)
            {
                if (lowChanceToBuy == 4 || lowChanceToBuy == 7)
                {
                    BuyLemonade(); 
                }
            }
            else if (moneyToSpend > 5 && moneyToSpend < 11)
            {
                if (medChanceToBuy == 2 || medChanceToBuy == 5)
                {
                    BuyLemonade();
                }
            }
            else if (moneyToSpend > 11 && moneyToSpend < 15)
            {
                if (highChanceToBuy == 1)
                {
                    BuyLemonade();
                }
            }
        }
    }
}
