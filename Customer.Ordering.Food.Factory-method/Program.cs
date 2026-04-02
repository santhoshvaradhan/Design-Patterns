
namespace Customer.Ordering.Food.Factory_method.Chef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory, Method!");

            Chef chef;

            chef  = new PizzaChef();
            chef.PrepareFood();

            chef = new PastaChef();
            chef.PrepareFood();

            chef = new BurgerChef();
            chef.PrepareFood();

        }
    }
}
