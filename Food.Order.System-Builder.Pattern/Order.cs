using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Order.System_Builder.Pattern
{
    public class Order { 
        public string CustomerName { get; set; }
        public List<string> Items { get; set; } = new List<string>(); 
        public string? Address { get; set; } 
        public bool IsExpressDelivery { get; set; } }
}
