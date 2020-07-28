using PizzaStore.Client;
using PizzaStore.Domain.Models;
using Xunit;

namespace PizzaStore.Testing.tests
{
    public class StartupTest
    {
        [Fact]
        public void test_CreateOrder()
        {
            var sut = new Startup();
            var user = new User();
            var store = new Store(1);
            
            var actual = sut.CreateOrder(user, store);

            Assert.NotNull(actual);

        }
    }
}