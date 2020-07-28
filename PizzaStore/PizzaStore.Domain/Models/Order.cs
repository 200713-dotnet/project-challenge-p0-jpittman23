using System;
using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
    public class Order
    {
        public List<Pizza> Pizza { get; set; }
        //public DateTime DateOrdered { get; set; }

        public Order()
        {
            Pizza = new List<Pizza>();
        }
    }
}