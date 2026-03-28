What is Builder Pattern?

The Builder Pattern is used to construct complex objects step-by-step.
Instead of creating an object in one big constructor, we build it gradually.
The Builder Pattern allows us to create different representations of an object using the same construction process.
In the Builder Pattern, we have a Director that controls the construction process and a Builder that defines the steps to create the object.
The Director is responsible for managing the construction process and ensuring that the steps are executed in the correct order. 
The Builder, on the other hand, defines the specific steps to create the object and can be implemented in different ways to create different representations of the object.

In summary, the Builder Pattern is a design pattern that allows us to construct complex objects step-by-step,providing flexibility and separation of concerns in the construction process. 
It is particularly useful when we want to create different representations of an object using the same construction process.

Why Builder Pattern?

When:
Object has many properties
Constructor becomes too large / confusing
Need step-by-step object creation

Problem Without Builder

var order = new Order("Santhosh", "Pizza", "Coke", "IceCream", true, "Address", "Phone");

Problems:

Hard to read
Hard to maintain
Order of parameters matters
Optional fields confusing

Solution With Builder :

var order = new OrderBuilder()
                .SetCustomerName("Santhosh")
                .AddItem("Pizza")
                .AddItem("Coke")
                .SetDeliveryAddress("Chennai")
                .Build();

✔ Clean
✔ Readable
✔ Flexible

When to Use

Use Builder when:

Object has many optional fields
Complex object creation
Need readable code