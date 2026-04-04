namespace Notification.Service.Adapter_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adapter, Pattern!");

            INotificationService notification = new EmailAdapter(new EmailLibrary());

            notification.SendNotification("san@gmail.com", "san@gmail.com", "Notification", "Hello San!");
        }
    }
}
