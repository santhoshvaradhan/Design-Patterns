
What is Factory Pattern?

The Factory Pattern is a design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.
In the Factory Pattern, we have a Factory class that is responsible for creating objects. 
The Factory class defines a method that returns an instance of a specific type of object based on some input parameters. 
The subclasses of the Factory class can override this method to create different types of objects.
The Factory Pattern is useful when we want to create objects without exposing the creation logic to the client. 
It allows us to decouple the client code from the specific classes that are being instantiated, making our code more flexible and easier to maintain.

In summary, the Factory Pattern is a design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.

Why Factory Pattern?
When:
Need to create objects without exposing creation logic
Need to decouple client code from specific classes

Problem Without Factory
var pizzaOrder = new PizzaOrder("Santhosh", "Pepperoni", "Large");
var cokeOrder = new CokeOrder("Santhosh", "Coke", "Medium");

Problems:
Tight coupling between client and specific classes : Client code is directly dependent on the concrete classes (PizzaOrder, CokeOrder). If we want to add a new type of order (e.g., IceCreamOrder), we would need to modify the client code to create an instance of the new class.
example: If we want to add a new type of order (e.g., IceCreamOrder), we would need to modify the client code to create an instance of the new class.
example client code modification:
var iceCreamOrder = new IceCreamOrder("Santhosh", "Vanilla", "Medium");

Hard to maintain : If we have many different types of orders, the client code can become cluttered and difficult to maintain. Each time we want to add a new type of order, we would need to modify the client code, which can lead to bugs and errors.

Solution With Factory:
var orderFactory = new OrderFactory();
var pizzaOrder = orderFactory.Create("Pizza", "Santhosh", "Pepperoni", "Large");
var cokeOrder = orderFactory.Create("Coke", "Santhosh", "Coke", "Medium");

✔ Decoupled
✔ Flexible

When to Use
Use Factory when:
Need to create objects without exposing creation logic
Need to decouple client code from specific classes

EXAMPLE:

// Factory Interface
public interface IOrderFactory
{
	IOrder Create(string orderType, string customerName, string item, string size);
}

// Concrete Factory

public class OrderFactory : IOrderFactory
{
	public IOrder Create(string orderType, string customerName, string item, string size)
	{
		switch (orderType)
		{
			case "Pizza":
				return new PizzaOrder(customerName, item, size);
			case "Coke":
				return new CokeOrder(customerName, item, size);
			default:
				throw new ArgumentException("Invalid order type");
		}
	}
}

WITHOUT FACTORY

var pizzaOrder = new PizzaOrder("Santhosh", "Pepperoni", "Large");

var cokeOrder = new CokeOrder("Santhosh", "Coke", "Medium");

Then Why we Using Interface?

Using an interface (IOrderFactory) allows us to define a contract for creating orders without specifying the concrete implementation.
This means that we can have multiple implementations of the IOrderFactory interface, each responsible for creating different types of orders (e.g., PizzaOrderFactory, CokeOrderFactory, etc.).
By using an interface, we can decouple the client code from the specific classes that are being instantiated.
This allows for greater flexibility and maintainability, as we can easily add new types of orders by creating new factory implementations without modifying the existing client code.

Without using an interface, we would be tightly coupled to a specific implementation of the factory, which would make it difficult to change or extend the functionality in the future.

how Can it is Flexible?

The Factory Pattern is flexible because it allows us to create objects without exposing the creation logic to the client.
This means that we can easily add new types of orders by creating new factory implementations without modifying the existing client code.
For example, if we want to add a new type of order (e.g., IceCreamOrder), we can simply create a new factory implementation (IceCreamOrderFactory) that implements the IOrderFactory interface and handles the creation of IceCreamOrder objects.
public class IceCreamOrderFactory : IOrderFactory
{
	public IOrder Create(string orderType, string customerName, string item, string size)
	{
		if (orderType == "IceCream")
		{
			return new IceCreamOrder(customerName, item, size);
		}
		throw new ArgumentException("Invalid order type");
	}
}

Then Why often factory pattern is used in payment system?

The Factory Pattern is often used in payment systems because it allows for flexibility and extensibility when dealing with different payment methods.
In a payment system, there may be multiple payment methods (e.g., CreditCardPayment, PayPalPayment, BankTransferPayment, etc.), each with its own specific implementation and requirements.
By using the Factory Pattern, we can create a PaymentFactory that is responsible for creating instances of different payment methods based on some input parameters (e.g., payment type).

This allows us to decouple the client code from the specific payment method implementations, making it easier to maintain and extend the payment system in the future.

For example, if we want to add a new payment method (e.g., ApplePayPayment), we can simply create a new factory implementation (ApplePayPaymentFactory) that implements the IPaymentFactory interface and handles the creation of ApplePayPayment objects, without modifying the existing client code.

public interface IPaymentFactory
{
	IPayment Create(string paymentType, decimal amount);
}

public class PaymentFactory : IPaymentFactory
{
	public IPayment Create(string paymentType, decimal amount)
	{
		switch (paymentType)
		{
			case "CreditCard":
				return new CreditCardPayment(amount);
			case "PayPal":
				return new PayPalPayment(amount);
			case "BankTransfer":
				return new BankTransferPayment(amount);
			default:
				throw new ArgumentException("Invalid payment type");
		}
	}
}

