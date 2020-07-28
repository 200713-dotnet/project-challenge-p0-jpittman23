using System;
using System.Collections.Generic;
using System.Linq;
using domain = PizzaStore.Domain.Models;
namespace PizzaStore.Storing.Repositories
{
    public class PizzaRepository
    {
        private PizzadbContext db = new PizzadbContext();
        public void Create(domain.Pizza pizza)
        {

            var newPizza = new Pizza();

            newPizza.Crust = new Crust();
            newPizza.Size = new Size();
            newPizza.Name = pizza.Name;

            foreach (var t in pizza.toppings)
            {
                var toppings = new Topping() {Name = t.Name};
                var pizzaTopping = new PizzaTopping() {Pizza = newPizza, Topping = toppings};
            }
            

            db.Pizza.Add(newPizza);
            db.SaveChanges();
        }

        public List<domain.Pizza> ReadAll()
        {
            var domainPizzaList = new List<domain.Pizza>();

            var query = from p in db.Pizza
                        select p;
            
            foreach(var item in db.Pizza.ToList())
            {
                domainPizzaList.Add(new domain.Pizza()
                {
                    crust = new domain.Crust("Regular") { Name = item.Crust.Name},
                    size = new domain.Size("Medium") {Name = item.Size.Name},
                });
            };

            return domainPizzaList;
        }

       public void Update(){}

       public void Delete(){}
    }
}