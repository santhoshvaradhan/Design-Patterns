using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Connection.Manager.Singleton_Pattern
{
    internal interface ISqlConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
