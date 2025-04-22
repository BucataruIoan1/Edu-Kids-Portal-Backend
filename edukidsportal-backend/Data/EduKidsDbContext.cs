using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace edukidsportal_backend.Data
{
    public class EdukidsDbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public EdukidsDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
