using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ProductEntity> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProductEntity>().HasQueryFilter(p => p.DeletedAt == null);
        }
    }
}