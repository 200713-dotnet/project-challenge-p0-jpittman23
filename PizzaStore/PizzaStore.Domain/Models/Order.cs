using System;
using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
    public class Order
    {
        public List<Pizza> Pizza { get; }
        //public DateTime DateOrdered { get; set; }

        public void CreatePizza(Size s, Crust c, List<Toppings> t)
        {
            var pizza = new Pizza(c,s,t);
            Pizza.Add(pizza);
        }
        public Order()
        {
            Pizza = new List<Pizza>();
        }
    }
}