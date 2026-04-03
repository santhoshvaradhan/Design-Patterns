namespace Customer.Ordering.Food.Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRestaurantFactory factory;

            factory = new VegRestaurant();

            var burger = factory.CreateBurger();
            var pizza = factory.CreatePizza();

            burger.Prepare();
            pizza.Prepare();

            factory = new NonVegRestaurant();

            var burger1 = factory.CreateBurger();
            var pizza1 = factory.CreatePizza();

            burger1.Prepare();
            pizza1.Prepare();
        }
    }
}
