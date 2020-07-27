using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
    public class Store
    {
        public List<Order> Orders { get; }
        public string Name { get; }

        public Store(int selection)
        {
            switch(selection)
            {
                case 1:
                    Orders = new List<Order>();
                    Name = "Pizza Zone on 10th";
                    break;
                case 2:
                    Orders = new List<Order>();
                    Name = "Pizza Zone on 5th";
                    break;
            }

        }

        // public Order CreateOrder()
        // {
        //     return new Order();
        // }
    }
}