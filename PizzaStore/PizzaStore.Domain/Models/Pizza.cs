using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
    public class Pizza
    {
        public List<Toppings> toppings
        {
            get
            {
                return toppings;
            }
        }
        public Crust crust { get; }
        public Size size { get; }

        void AddToppings(Toppings topping)
        {
            toppings.Add(topping);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach(var t in toppings)
            {
                sb.Append(t);
            }

             return $"{size} {crust} {sb}";
        }


        public Pizza(string c, string s, List<Toppings> t)
        {
            crust._crust = c;
            size._size = s;
            toppings.AddRange(t);
        }

        public Pizza()
        {
            
        }
    }
}