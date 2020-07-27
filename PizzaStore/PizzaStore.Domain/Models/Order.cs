using System;
using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
    public class Order
    {
        public List<Pizza> Pizzalist { get; }
        public DateTime DateOrdered { get; set; }

        public void CreatePizza(string s, string c, List<Toppings> t)
        {
            var pizza = new Pizza(c,s,t);
            Pizzalist.Add(pizza);
            System.Console.WriteLine("Pizza added to your order");
        }
        public Order()
        {
            Pizzalist = new List<Pizza>();
        }
    }
}