using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.test
{
    public class UnitTest1
    {

        WeatherForecastController wfc = new WeatherForecastController();

[Fact]
public void getReturnsName()
{
    var result = wfc.Sumne(1);
    Assert.Equal("Anand",result);
}

        [Fact]
        public void Test1()
        {

        }
    }
}
