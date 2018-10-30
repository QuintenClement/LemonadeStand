using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        public Customer customer;
        public Shop shop;
        public Player player;
        public int temperature;
        public string weatherForecast;
        public int gameLength;
        public Day day;
        public string playAgain;
        
        
        public void RunGame()
        {
            Console.WriteLine("Hello! Welcome to Lemonade stand! The objective of the game is simple.");
            Console.WriteLine("Check the weather, buy ingredients, set a recipe and price, and MAKE MONEY!!!!");
            Console.ReadLine();
            Console.WriteLine("So lets get to it");
            for (int i = 0; i < gameLength; i++)
            {
                day.StartDay();
            }
            Console.WriteLine("Well lets see how you did!");
            Console.WriteLine("You started with $50 and you now have $" + player.money);
            EndGame();
            PlayAgain();
            

        }
        public void RandomTemp()
        {
            Random rnd = new Random();
            int hot = rnd.Next(85, 100);
            int warm = rnd.Next(74, 85);
            int cool = rnd.Next(50, 70);
            if (weatherForecast == "Sunny and Cool")
            {
                temperature = cool;
            }
            else if (weatherForecast == "Overcast and Cool")
            {
                temperature = cool;
            }
            else if (weatherForecast == "Stormy and Muggy")
            {
                temperature = warm;
            }
            else if (weatherForecast == "Sunny and Hot")
            {
                temperature = hot;
            }

        }
        public void SetGameLength()
        {
            Console.WriteLine("How many days would you like to play for?");
            bool test = Int32.TryParse(Console.ReadLine(), out gameLength);
            while (test == false)
            {
                Console.WriteLine("How many days would you like to play for?");
                test = Int32.TryParse(Console.ReadLine(), out gameLength);
            }


        }
        public void EndGame()
        {
            if (player.money < 50)
            {
                Console.WriteLine("Yikes!! You lost money! You should really become a better lemonade seller.");
            }
            else if (player.money > 50)
            {
                Console.WriteLine("Yay!! You made money! Good job, you should look into a career in sales!");
                Console.WriteLine("You made: $" + (player.money - 50));
            }
        }

        public void RandomWeather()
        {
            List<string> Weather = new List<string>();
            Weather.Add("Sunny and Cool");
            Weather.Add("Overcast and Cool");
            Weather.Add("Stormy and Muggy");
            Weather.Add("Sunny and Hot");

            Random rnd = new Random();
            int randomWeatherChoice = rnd.Next(Weather.Count);

            switch(randomWeatherChoice)
            {
                case 1:
                    weatherForecast = Weather[0];
                    break;
                case 2:
                    weatherForecast = Weather[1];
                    break;
                case 3:
                    weatherForecast = Weather[2];
                    break;
                case 4:
                    weatherForecast = Weather[3];
                    break;
            }
        }
        public void PlayAgain()
        {
            Console.WriteLine("Would you like to play again? (yes/no)");
            playAgain = Console.ReadLine().ToLower();
            if (playAgain == "yes")
            {
                RunGame();
            }
            else
                break;
        }

    }
}
