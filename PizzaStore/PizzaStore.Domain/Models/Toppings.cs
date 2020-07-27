namespace PizzaStore.Domain.Models
{
    public class Toppings
    {
        public string _toppings;
        public Toppings(int choice)
        {
            if (choice == 1)
            {
                _toppings = "Cheese";
            }
            else if (choice == 2)
            {
                _toppings = "Pepperoni";
            }
            else if (choice == 3)
            {
                _toppings = "Hawiian";
            }
            else
            {
                System.Console.WriteLine("Please make a valid selection");
            }
        }
    }
}