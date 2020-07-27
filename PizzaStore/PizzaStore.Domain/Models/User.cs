using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
    public class User
    {
        public List<Order> Orders { get; }
        public Name name { get; set; }

        public User()
        {
            Orders = new List<Order>();
        }
    }
}