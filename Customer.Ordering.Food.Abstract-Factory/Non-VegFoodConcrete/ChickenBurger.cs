using Customer.Ordering.Food.Abstract_Factory.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Ordering.Food.Abstract_Factory.Non_VegFoodConcrete
{
    internal class ChickenBurger : IBurger
    {
        void IBurger.Prepare()
        {
            Console.WriteLine("Preparing Chicken Burger");
        }
    }
}
