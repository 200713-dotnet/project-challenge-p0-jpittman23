namespace PizzaStore.Domain.Models
{
    public class Size : Acomp
    {
        public double Price;
        public string _size;
        public Size(string size)
        {
            int choice;
            int.TryParse(size, out choice);
            if (choice == 1)
            {
                _size = "Small";
                Price = 2.50;
            }
            else if (choice == 2)
            {
                _size = "Medium";
                Price = 5.00;
            }
            else if (choice == 3)
            {
                _size = "Large";
                Price = 10.00;
            }
            else
            {
                System.Console.WriteLine("Please make a valid selection");
            }
        }
    }
}