using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ShipIt.Models.DataModels;

namespace ShipIt
{
    public class ShipItContext : DbContext
    {
        public DbSet<EmployeeDataModel> Employees { get; set; }
        public DbSet<CompanyDataModel> Companies { get; set; }
        public DbSet<ProductDataModel> Products { get; set; }
        public DbSet<StockDataModel> Stock { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Shipit;Username=Shipit;Password=Shipit;");
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        public List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}