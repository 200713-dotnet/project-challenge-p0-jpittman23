using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
    public class Pizza
    {
        public Toppings toppings { get; }
        public Crust crust { get; }
        public Size size { get; }


        public Pizza(string c, string s, string t)
        {
            crust._crust = c;
            size._size = s;
            toppings._toppings = t;
        }

        public Pizza()
        {
            
        }
    }
}