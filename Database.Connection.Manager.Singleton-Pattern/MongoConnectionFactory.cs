using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Connection.Manager.Singleton_Pattern
{
    internal class MongoConnectionFactory : IMongoConnectionFactory
    {
        private readonly string _connectionString;
        private readonly IMongoDatabase _database;
        public MongoConnectionFactory(IConfiguration config)
        {
            // Initialize MongoDB connection string from configuration

            _connectionString = config.GetConnectionString("MongoConnection") ?? throw new Exception("Database Connection string missing");
            var client = new MongoClient(_connectionString);
            _database = client.GetDatabase("YourDatabaseName");
        }

        public IMongoDatabase CreateConnection()
        {
            // Return the existing MongoDB database instance
            return _database;
        }
    }
}
