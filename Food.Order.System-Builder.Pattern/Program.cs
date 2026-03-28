// See https://aka.ms/new-console-template for more information
using Food.Order.System_Builder.Pattern;

var order = new OrderBuilder()
                .SetCustomerName("Santhosh")
                .AddItem("Pizza")
                .AddItem("Burger")
                .SetAddress("Tamil Nadu")
                .SetExpressDelivery(true)
                .Build(); 

Console.WriteLine($"Customer: {order.CustomerName}"); Console.WriteLine($"Items: {string.Join(", ", order.Items)}"); 
Console.WriteLine($"Address: {order.Address}"); Console.WriteLine($"Express: {order.IsExpressDelivery}");
