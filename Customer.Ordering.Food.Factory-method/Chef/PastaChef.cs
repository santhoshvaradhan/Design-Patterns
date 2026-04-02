using Customer.Ordering.Food.Factory_method.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Ordering.Food.Factory_method.Chef
{
    internal class PastaChef : Chef
    {
        public override IFood CreateFood()
        {
            return new Pasta();
        }
    }
}
