// See https://aka.ms/new-console-template for more information
using Customer.Orders.Food.Simple_Factory;

Console.WriteLine("Simple factory pattern!");


IFood Order1 = FoodFactory.GetFood(FoodType.Pizza);
Order1.PerpareFood("Pepperoni");

IFood Order2 = FoodFactory.GetFood(FoodType.Burger);
Order2.PerpareFood("Cheese");

IFood Order3 = FoodFactory.GetFood(FoodType.Pasta);
Order3.PerpareFood("Alfredo");
