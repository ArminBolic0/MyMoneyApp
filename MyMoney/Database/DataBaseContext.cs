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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expense>()
                .HasOne(e => e.expenseCategory)
                .WithMany()
                .HasForeignKey(e => e.expenseCategory_id);

            modelBuilder.Entity<Expense>()
                .HasOne(e => e.user)
                .WithMany()
                .HasForeignKey(e => e.user_id);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        public DbSet<Expense> Expenses { get; set; }
    }
}
