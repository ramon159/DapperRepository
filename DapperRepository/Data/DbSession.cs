using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DapperRepository.Data
{
    public class DbSession : IDisposable
    {
        public IDbConnection Connection { get; }
        public DbSession(IConfiguration configuration)
        {
            Connection = new NpgsqlConnection(configuration.GetConnectionString("DBConnection"));
            Connection.Open();
        }
        public void Dispose() => Connection?.Dispose();
    }
}
