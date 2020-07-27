using System;
using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client
{
    class Program
    {
        static void Main()
        {
            Welcome();
        }

        static void Welcome()
        {
            System.Console.WriteLine("Welcome to the Pizza Zone - Home of the best pizza ever made");
            System.Console.WriteLine("Please selet which store to use:");
            System.Console.WriteLine("1 for Pizza Zone on 10th");
            System.Console.WriteLine("2 for Pizza Zone on 5th");
            int selection;
            int.TryParse(System.Console.ReadLine(), out selection);
            var store = new Store(selection);
            System.Console.WriteLine(store.Name);
            System.Console.WriteLine();
            List<Pizza> cart = new List<Pizza>();
            var startup = new PizzaStore.Client.Startup();
            var u = new User();
            
            try
            {
                Menu(startup.CreateOrder(u , store));
            }
            catch(Exception ex)
            {
               System.Console.WriteLine(ex.Message);
            }
        }
        static void Menu(Order cart)
        {
            var exit = false;

            System.Console.WriteLine("Please select which size you would like:");
            System.Console.WriteLine("1 for small");
            System.Console.WriteLine("2 for medium");
            System.Console.WriteLine("3 for large");
            System.Console.WriteLine("");
            var s = new Size(Console.ReadLine());
            System.Console.WriteLine(s._size);
            System.Console.WriteLine("");

            System.Console.WriteLine("Please select which crust you would like:");
            System.Console.WriteLine("1 for regular");
            System.Console.WriteLine("2 for stuffed crust");
            System.Console.WriteLine("3 for thin crust");
            System.Console.WriteLine("");
            var c = new Crust(Console.ReadLine());
            System.Console.WriteLine(c._crust);
            System.Console.WriteLine("");

            do
            {
                Startup.PrintMenu();

                int select;

                int.TryParse(Console.ReadLine(), out select);

                switch (select)
                {
                    case 1:
                        var t = new Toppings(select);
                        cart.CreatePizza(s, c, new List<Toppings>{t});
                        System.Console.WriteLine("Cheese pizza added to cart");
                        System.Console.WriteLine();
                        break;
                    case 2:
                        t = new Toppings(select);
                        cart.CreatePizza(s, c, new List<Toppings>{t});
                        System.Console.WriteLine("Pepperoni pizza added to cart");
                        System.Console.WriteLine();
                        break;
                    case 3:
                        t = new Toppings(select);
                        cart.CreatePizza(s, c, new List<Toppings>{t});
                        System.Console.WriteLine("Hawaiian pizza added to cart");
                        System.Console.WriteLine();
                        break;
                    case 4:
                        t = new Toppings(select);
                        cart.CreatePizza(s, c, new List<Toppings>{t});
                        System.Console.WriteLine("Custom pizza added to cart");
                        System.Console.WriteLine();
                        break;
                    case 5:
                        var fmr = new FileManager();
                        System.Console.WriteLine("Here are the items in your cart:");
                        DisplayCart(fmr.Read());
                        System.Console.WriteLine();
                        break;
                    case 6:
                        var fmw = new FileManager();
                        fmw.Write(cart);
                        System.Console.WriteLine("Proceed to checkout");
                        System.Console.WriteLine();
                        exit = true;
                        break;
                }
                System.Console.WriteLine();
            } while (!exit);
        }
        static void DisplayCart(Order cart)
        {
            foreach (var pizza in cart.Pizzalist)
            {
                System.Console.WriteLine(pizza);
            }
        }
    }
}
