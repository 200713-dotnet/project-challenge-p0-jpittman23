using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
    public class Store
    {
        public List<Order> Orders { get; }
        public string Name { get; set; }

        public Store()
        {
            Orders = new List<Order>();
        }

        // public Order CreateOrder()
        // {
        //     return new Order();
        // }
    }
}