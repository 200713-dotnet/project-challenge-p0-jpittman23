using PizzaStore.Domain.Models;
using System.Collections.Generic;
using Xunit;

namespace PizzaStore.Testing.tests
{
    public class OrderTest
    {
        [Fact]
        public void Test_CreatePizza()
        {
            // arrange
            var sut = new Order();
            string size = "Small";
            string crust = "thin";
            List<string> toppings = new List<string>{"topping"};

            //action
            sut.CreatePizza(size, crust, toppings);

            //assert
            Assert.True(sut.Pizza.Count > 0);
        }
    }
}