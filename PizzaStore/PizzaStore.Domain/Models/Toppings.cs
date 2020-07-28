namespace PizzaStore.Domain.Models
{
    public class Toppings : Acomp
    {
        public string _toppings;
        public Toppings(int choice)
        {
            switch (choice)
            {
                case 1:
                    _toppings = "Cheese";
                    break;
            
                case 2:
                    _toppings = "Pepperoni";
                    break;
            
                case 3:
                    _toppings = "Hawiian";
                    break;
                default:
                    System.Console.WriteLine("Please make a valid selection");
                    break;
            }
        }
    }
}