
using MongoDB.Driver;

namespace Database.Connection.Manager.Singleton_Pattern
{
    internal interface IMongoConnectionFactory
    {
        IMongoDatabase CreateConnection();
    }
}
