using Data;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Diagnostics;

namespace Database
{
    public class DataBaseContext : DbContext
    {
        private readonly string _connectionString;

        public DataBaseContext()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_connectionString);
        }

        public DbSet<User> Users { get; set; }
    }
}
