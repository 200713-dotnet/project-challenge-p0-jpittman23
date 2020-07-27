using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
    public class Pizza
    {

        private List<Toppings> _toppings = new List<Toppings>();
        public List<Toppings> toppings
        {
            get
            {
                return _toppings;
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