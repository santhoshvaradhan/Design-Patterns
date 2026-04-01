using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Orders.Food.Simple_Factory
{
    internal interface IFood
    {
        void PerpareFood(string foodType);
    }
}
