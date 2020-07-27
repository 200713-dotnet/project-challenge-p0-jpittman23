using System;
using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client
{
    public class Startup
    {
        public Order CreateOrder(User user, Store store)
        {
            try
            {
                var order = new Order();

                user.Orders.Add(order);
                store.Orders.Add(order);

                return order;
            }
            catch
            {
                throw new System.Exception("We are experiencing some technical difficulties right now, please try again later");
            }
            finally
            {
                //GC.GetGeneration(user);
                GC.Collect();
            }
        }

        internal static void PrintMenu()
        {
            System.Console.WriteLine("Select 1 for Cheese");
            System.Console.WriteLine("Select 2 for pepperoni");
            System.Console.WriteLine("Select 3 for Hawaiian");
            System.Console.WriteLine("Select 4 for Custom options");
            System.Console.WriteLine("Select 5 for show cart");
            System.Console.WriteLine("Select 6 for exit");
            System.Console.WriteLine();
        }
    }
}