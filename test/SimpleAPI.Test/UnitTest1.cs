using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controler = new WeatherForecastController(null);
        [Fact]
        public void GetReturnsMyName()
        {
            var id = 1;
            var returnValue = controler.Get(id);
            Assert.Equal("WeatherForecast " + id.ToString(), returnValue.Value);
        }


        [Fact]
        public void Test1()
        {

        }
    }
}
