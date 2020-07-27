using System;
using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
    public class Order
    {
        public List<Pizza> Pizzalist { get; }
        public DateTime DateOrdered { get; set; }

        public void CreatePizza(Size s, Crust c, List<Toppings> t)
        {
            var pizza = new Pizza(c,s,t);
            Pizzalist.Add(pizza);
        }
        public Order()
        {
            Pizzalist = new List<Pizza>();
        }
    }
}