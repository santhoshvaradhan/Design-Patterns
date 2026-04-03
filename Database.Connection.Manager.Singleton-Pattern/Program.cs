
using System.Net;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Database.Connection.Manager.Singleton_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            using IHost host = Host.CreateDefaultBuilder(args)
.ConfigureServices(services =>
{
    services.AddSingleton<IMongoConnectionFactory, MongoConnectionFactory>();  
    services.AddSingleton<ISqlConnectionFactory,SqlConnectionFactory>(); // Register the main application class


    services.AddSingleton<UserService>(); // Register the main application class

})
.Build();

            var app = host.Services.GetRequiredService<UserService>();
             host.RunAsync();
        }
    }
}
