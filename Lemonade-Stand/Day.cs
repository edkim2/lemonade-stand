using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Day
    {
        // member variables (HAS A)
        public int day;
        public Weather weather;

        // constructor (SPAWNER)
        public Day()
        {
            day = 1;
            weather = new Weather();
        }

        // member methods (CAN DO)
        public void GetActualWeather(Random random)
        {
            weather.SetWeatherTemperature(random);
            weather.SetWeatherCondition(random);
            weather.DisplayActualWeather();
        }

        public void GetForecastWeather(Random random)
        {
            weather.SetWeatherTemperature(random);
            weather.SetWeatherCondition(random);
            weather.DisplayForecastWeather();
        }
    }
}
