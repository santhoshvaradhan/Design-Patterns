using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Connection.Manager.Singleton_Pattern
{
    internal class UserService
    {
        private readonly ISqlConnectionFactory _sqlFactory;
        private readonly IMongoConnectionFactory _mongoFactory;

        public UserService(ISqlConnectionFactory sqlFactory, IMongoConnectionFactory mongoFactory)
        {
            _sqlFactory = sqlFactory;
            _mongoFactory = mongoFactory;
        }

    }
}
