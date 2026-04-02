using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Ordering.Food.Factory_method.Food
{
    internal class Burger : IFood
    {
            public void Prepare()
            {
                Console.WriteLine("Preparing Burger...");
            }
    }
}
