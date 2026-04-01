using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Orders.Food.Simple_Factory
{

    enum FoodType
    {
        Pizza,
        Burger,
        Pasta
    }
    internal class FoodFactory
    {
        public static IFood GetFood(FoodType type)
        {
            return type switch
            {
                FoodType.Pizza => new Pizza(),
                FoodType.Burger => new Burger(),
                FoodType.Pasta => new Pasta(),
                _ => throw new ArgumentException("Invalid food type")
            };
        }
    }
}
