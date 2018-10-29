using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {

        public Shop shop;
        public Player player;
        public int temperature;
        public string weatherForecast;
        
        public void RunGame()
        {
            shop.BuyLemons(player);
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


    }
}
