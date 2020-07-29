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

            newPizza.Crust = new Crust(){Name = pizza.crust._crust};
            newPizza.Size = new Size(){Name = pizza.size._size};
            newPizza.Name = pizza.Name;

            
            db.Pizza.Add(newPizza);
            db.SaveChanges();
        }

        public List<domain.Pizza> ReadAll(string answer, string Answer)
        {
            var domainPizzaList = new List<domain.Pizza>();
            
            foreach(var item in db.Pizza.ToList())
            {
                domainPizzaList.Add(new domain.Pizza()
                {
                    crust = new domain.Crust(answer) { Name = item.Crust.Name},
                    size = new domain.Size(Answer) {Name = item.Size.Name},
                });
            };

            return domainPizzaList;
        }

       public void Update(){}

       public void Delete(){}
    }
}