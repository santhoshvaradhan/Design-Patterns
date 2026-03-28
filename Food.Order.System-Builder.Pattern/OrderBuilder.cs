using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Order.System_Builder.Pattern
{
     public class OrderBuilder
    {
        private Order _order = new Order();

        public OrderBuilder SetCustomerName(string name)
        {
            _order.CustomerName = name;
            return this;
        }

        public OrderBuilder AddItem(string item)
        {
            _order.Items.Add(item);
            return this;
        }

        public OrderBuilder SetAddress(string address)
        {
            _order.Address = address;
            return this;
        }
        public OrderBuilder SetExpressDelivery(bool isExpress)
        {
            _order.IsExpressDelivery = isExpress;
            return this;
        }

        public Order Build()
        {
            return _order;
        }
    }
}
