using BmsRestApi.Models.Product;
using Microsoft.EntityFrameworkCore;
namespace BmsRestApi.Database
{
    public class BmsDbContext : DbContext 
    {
        public BmsDbContext(DbContextOptions<BmsDsbContext> options) : base(options){ }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
