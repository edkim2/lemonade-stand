using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lemonade_Stand;
namespace LemonadeStandTests
{
    [TestClass]
    public class WeatherTests
    {
        [TestMethod]
        public void Weather_WithinRangeIndex_SetsCondition()
        {
            Weather weather = new Weather();
            // arrange
            string expected = "Blazing Hot";
            string actual = weather.weatherTemperature;

            // act
            weather.SetWeatherTemperature(1);
            actual = weather.weatherTemperature;

            // assert
            Assert.AreEqual(expected, actual);
        }
        
        //public void Weather_WithinRangeIndex_SetsCondition()
        //{
        //    Weather weather = new Weather();
        //    // arrange
        //    string expected = "Hot";
        //    string actual = 
        //}
    }
}
