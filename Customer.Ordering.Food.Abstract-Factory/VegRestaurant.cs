using Customer.Ordering.Food.Abstract_Factory.Food;
using Customer.Ordering.Food.Abstract_Factory.VegFoodConcrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Ordering.Food.Abstract_Factory
{
    internal class VegRestaurant : IRestaurantFactory
    {
        public IBurger CreateBurger()
        {
            return new VegBurger();
        }

        public IPizza CreatePizza()
        {
            return new VegPizza();
        }
    }
}
