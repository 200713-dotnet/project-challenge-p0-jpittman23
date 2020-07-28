using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
    public class Pizza
    {
        public string Name { get; set; }
        public List<Toppings> toppings { get; set;}
        public Crust crust { get; set; }
        public Size size { get; set; }

        public override string ToString()
        {
            return $"{Name} {crust.Name} {size.Name}";
        }


        public Pizza(Crust c, Size s, List<Toppings> t)
        {
            crust = c;
            size = s;
            toppings.AddRange(t);
        }

        public Pizza()
        {
        }
    }
}