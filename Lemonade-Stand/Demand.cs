using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Demand
    {
        // member variables (HAS A)
        public int demandBasedOnPrice;
        public int demandBasedOnWeather;

        // constructor (SPAWNER)
        public Demand(Recipe recipe, Weather weather)
        {
            SetDemandBasedOnPrice(recipe);
            SetDemandBasedOnWeather(weather);
        }

        // member methods (CAN DO)
        public int SetDemandBasedOnWeather(Weather weather)
        {
            if (weather.weatherTemperature == "Blazing Hot" && weather.weatherCondition == "& Clear")
            {
                demandBasedOnWeather = 1;
            }
            else if (weather.weatherTemperature == "Blazing Hot" && weather.weatherCondition == "& Cloudy")
            {
                demandBasedOnWeather = 2;
            }
            else if (weather.weatherTemperature == "Blazing Hot" && weather.weatherCondition == "& Rainy")
            {
                demandBasedOnWeather = 3;
            }
            else if (weather.weatherTemperature == "Hot" && weather.weatherCondition == "& Clear")
            {
                demandBasedOnWeather = 2;
            }
            else if (weather.weatherTemperature == "Hot" && weather.weatherCondition == "& Cloudy")
            {
                demandBasedOnWeather = 3;
            }
            else if (weather.weatherTemperature == "Hot" && weather.weatherCondition == "& Rainy")
            {
                demandBasedOnWeather = 4;
            }
            else if (weather.weatherTemperature == "Cold" && weather.weatherCondition == "& Clear")
            {
                demandBasedOnWeather = 3;
            }
            else if (weather.weatherTemperature == "Cold" && weather.weatherCondition == "& Cloudy")
            {
                demandBasedOnWeather = 4;
            }
            else if (weather.weatherTemperature == "Cold" && weather.weatherCondition == "& Rainy")
            {
                demandBasedOnWeather = 5;
            }
            return demandBasedOnWeather;
        }
        public int SetDemandBasedOnPrice(Recipe recipe)
        {
            if (recipe.priceOfLemonade <= .30)
            {
                demandBasedOnPrice = 1;
            }
            else if (recipe.priceOfLemonade >= .31 && recipe.priceOfLemonade <= .50)
            {
                demandBasedOnPrice = 2;
            }
            else if (recipe.priceOfLemonade >= .51 && recipe.priceOfLemonade <= .80)
            {
                demandBasedOnPrice = 3;
            }
            else if (recipe.priceOfLemonade >= .81)
            {
                demandBasedOnPrice = 4;
            }
            return demandBasedOnPrice;
        }


    }
}
