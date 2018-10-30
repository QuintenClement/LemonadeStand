using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        public int cupsSold;
        public int cost;
        public int grossSales;
        public int netSales;
        public Customer customer;
        public Game game;
        public Player player;
        public Shop shop;
        public bool positive;
        public bool negative;
        public Inventory inventory;
        public int potentialCustomers;
        public int customerCount;


        public Day()
        {
        
        }

        public void StartDay()
        {
            Console.WriteLine("Todays Weather: ");
            Console.WriteLine("Temp: " + game.temperature);
            Console.WriteLine("Forecast: " + game.weatherForecast);
            Console.WriteLine("You have $" + player.money); 
            shop.BuyCups(player);
            shop.BuyLemons(player);
            shop.BuySugar(player);
            shop.BuyIce(player);
            player.SetLemonsInRecipe();
            player.SetSugarInRecipe();
            player.SetIceInRecipe();
            player.SetPrice();
            NumOfCustomers();
            DaySales(player);
            DayEnd();
        }
        public void CalculateGrossSales()
        {
            grossSales = player.pricePerCup * cupsSold;
        }
        public void CalculateNetSales()
        {
            netSales = grossSales - cost;
        }
        public void DayEnd()
        {
            Console.WriteLine("Your day has come to an end!");
            Console.WriteLine("You had " + customerCount + " customers today!");
            Console.WriteLine("You sold: " + cupsSold + " cups of lemonade");
            Console.WriteLine("Your gross sales were: " + grossSales);
            Console.WriteLine("Your costs were: " + cost);
            Console.WriteLine("You made: $" + netSales);
            Console.ReadLine();
            Console.WriteLine("The rest of your ice has melted.");
            inventory.ice = 0;

        }
        public void NumOfCustomers()
        {
            Random rnd = new Random();
            int highCustomerCount = rnd.Next(75, 130);
            int medCustomerCount = rnd.Next(40, 80);
            int lowCustomerCount = rnd.Next(1, 40);

            if (game.temperature > 85)
            {
                potentialCustomers = highCustomerCount;
            }
            else if (game.temperature < 85 && game.temperature > 70)
            {
                potentialCustomers = medCustomerCount;
            }
            else if (game.temperature < 70)
            {
                potentialCustomers = lowCustomerCount;
            }
        }
        public void DaySales(Player player)
        {
            bool stillHasLemonade = true;
            for (int i = 0; i < potentialCustomers && stillHasLemonade; i ++)
            {
                Customer customer = new Customer();
                customer.BuyLemonade(player);
            }
        }
    }
}
