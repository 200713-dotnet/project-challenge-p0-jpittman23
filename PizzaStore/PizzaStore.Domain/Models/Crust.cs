namespace PizzaStore.Domain.Models
{
    public class Crust
    {
        public string _crust;
        public Crust(string curst)
        {
            int choice;
            int.TryParse(curst, out choice);
            if(choice == 1)
            {
                _crust = "regular crust";
            }
            else if(choice == 2)
            {
                _crust = "stuffed crust";
            }
            else if(choice == 3)
            {
                _crust = "thin crust";
            }
            else
            {
                System.Console.WriteLine("Please make a valid selection");
            }
        }
    }
}