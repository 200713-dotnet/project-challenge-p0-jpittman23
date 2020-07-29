use Pizzadb;
go

select * from Pizzas.Pizza

delete pp
from Pizzas.Pizza as pp
where Name = 'Pepperoni Pizza'