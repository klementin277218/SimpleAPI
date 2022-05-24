using System;
using Xunit;
using WebApp1.Controllers;

namespace SimpleAPI.Tests
{
    public class UnitTest1 
    {
            ValuesController controller = new ValuesController();
            
            [Fact]
            public void GetReturnsCorrectNumber()
            {
                var returnValue = controller.Get(1);
                Assert.Equal("Les Jackson", returnValue.Value);
            }
             [Fact]
            public void Test1()
            {


            }
    }
}