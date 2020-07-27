namespace PizzaStore.Domain.Models
{
    public class Size
    {
        public string _size;
        public Size(string size)
        {
            int choice;
            int.TryParse(size, out choice);
            if (choice == 1)
            {
                _size = "Small";
            }
            else if (choice == 2)
            {
                _size = "Medium";
            }
            else if (choice == 3)
            {
                _size = "Large";
            }
            else
            {
                System.Console.WriteLine("Please make a valid selection");
            }
        }
    }
}