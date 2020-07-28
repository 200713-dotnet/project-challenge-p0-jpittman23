using System;
using System.Collections.Generic;
using PizzaStore.Domain.Models;
using PizzaStore.Storing.Repositories;

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
                Menu(startup.CreateOrder(u, store));
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
        static void Menu(Order cart)
        {
            var exit = false;
            var pr = new PizzaRepository();


            do
            {
             System.Console.WriteLine("Please select which size you would like:");
            System.Console.WriteLine("1 for small");
            System.Console.WriteLine("2 for medium");
            System.Console.WriteLine("3 for large");
            System.Console.WriteLine("");
            var Answer = Console.ReadLine();
            var s = new Size(Answer);
            System.Console.WriteLine(s._size);
            System.Console.WriteLine("");

            System.Console.WriteLine("Please select which crust you would like:");
            System.Console.WriteLine("1 for regular");
            System.Console.WriteLine("2 for stuffed crust");
            System.Console.WriteLine("3 for thin crust");
            System.Console.WriteLine("");
            var answer = Console.ReadLine();
            var c = new Crust(answer);
            System.Console.WriteLine(c._crust);
            System.Console.WriteLine("");

                Startup.PrintMenu();

                int select;

                int.TryParse(Console.ReadLine(), out select);

                switch (select)
                {
                    case 1:
                        var pizzas = new Pizza()
                        {
                            Name = "Extra Cheese Pizza",
                            crust = new Crust(answer) { Name = c._crust },
                            size = new Size(Answer) { Name = s._size },
                            // toppings = new List<Toppings>() {new Toppings(select) {Name = "Cheese"}}
                        };
                        pr.Create(pizzas);
                        System.Console.WriteLine("Cheese pizza added to cart");
                        System.Console.WriteLine();
                        break;
                    case 2:
                        var pizza = new Pizza()
                        {
                            Name = "Pepperoni Pizza",
                            crust = new Crust(answer) { Name = c._crust },
                            size = new Size(Answer) { Name = s._size },
                            //toppings = new List<Toppings>() {new Toppings(select) {Name = "Pepperoni"}}
                        };
                        System.Console.WriteLine("Pepperoni pizza added to cart");
                        System.Console.WriteLine();
                        break;
                    case 3:
                        pizza = new Pizza()
                        {
                            Name = "Hawaiian Pizza",
                            crust = new Crust(answer) { Name = c._crust },
                            size = new Size(Answer) { Name = s._size },
                            toppings = new List<Toppings>() { new Toppings(select) { Name = "Ham,Pineapple" } }
                        };
                        System.Console.WriteLine("Hawaiian pizza added to cart");
                        System.Console.WriteLine();
                        break;
                    case 4:
                        pizza = new Pizza()
                        {
                            Name = "Sausage Pizza",
                            crust = new Crust(answer) { Name = c._crust },
                            size = new Size(Answer) { Name = s._size },
                            toppings = new List<Toppings>() { new Toppings(select) { Name = "Sausage" } }
                        };
                        System.Console.WriteLine("Sausage pizza added to cart");
                        System.Console.WriteLine();
                        break;
                    case 5:
                        foreach (var item in pr.ReadAll(answer,Answer))
                        {
                            System.Console.WriteLine(item);
                        }
                        break;
                    case 6:
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
            foreach (var pizza in cart.Pizza)
            {
                System.Console.WriteLine(pizza);
            }
        }
    }
}
