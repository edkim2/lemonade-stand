using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Weather
    {
        // member variables (HAS A)
        public string weatherCondition;
        public string weatherTemperature;
        // constructor (SPAWNER)
        public Weather()
        {
           
        }

        // member methods (CAN DO)
        public int SetWeatherTemperature(Random random)
        {
            int weatherTemperature = random.Next(1, 4);

            switch (weatherTemperature)
            {
                case 1:
                    this.weatherTemperature = "Blazing Hot";
                    break;
                case 2:
                    this.weatherTemperature = "Hot";
                    break;
                case 3:
                    this.weatherTemperature = "Cold";
                    break;
            }
            return weatherTemperature;
        }

        public int SetWeatherCondition(Random random)
        {
            int weatherCondition = random.Next(1, 4);
            switch (weatherCondition)
            {
                case 1:
                    this.weatherCondition = " & Clear";
                    break;
                case 2:
                    this.weatherCondition = " & Cloudy";
                    break;
                case 3:
                    this.weatherCondition = "& Rainy";
                    break;
            }
            return weatherCondition;
        }


        public void DisplayActualWeather()
        {
            Console.WriteLine("The weather today is: " + weatherTemperature + weatherCondition + "." );
        }

        public void DisplayForecastWeather()
        {
            Console.WriteLine("THe weather tomorrow is: " + weatherTemperature + weatherCondition + ".");
        }
    }
}
