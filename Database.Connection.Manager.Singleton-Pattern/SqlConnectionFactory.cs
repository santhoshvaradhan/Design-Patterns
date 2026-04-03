using Database.Connection.Manager.Singleton_Pattern;
using Microsoft.Data.SqlClient;

using System.Data;
using Microsoft.Extensions.Configuration;

public class SqlConnectionFactory : ISqlConnectionFactory
{
    private readonly string _connectionString;

    public SqlConnectionFactory(IConfiguration config)
    {
        _connectionString = config.GetConnectionString("SqlConnection") ?? throw new Exception("Database Connection string missing");
    }

    public IDbConnection CreateConnection()
    {
        return new SqlConnection(_connectionString);
    }
}