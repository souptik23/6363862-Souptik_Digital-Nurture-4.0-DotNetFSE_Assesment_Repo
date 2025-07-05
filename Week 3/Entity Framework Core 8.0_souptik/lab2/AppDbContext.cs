using Microsoft.EntityFrameworkCore;
using MyFirstConsoleApp_6363862.Models;

namespace MyFirstConsoleApp_6363862
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var connectionString = "Server=localhost;Database=RetailDb;Trusted_Connection=True;";
        //    optionsBuilder.UseSqlServer(connectionString);
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;Database=RetailDb;Trusted_Connection=True;Encrypt=False;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
