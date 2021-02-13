using Microsoft.EntityFrameworkCore;
using UluGidaGroup.Models.Entity;

namespace UluGidaGroup.Models.Context
{
    public class UluContext : DbContext
    {
        public UluContext(DbContextOptions<UluContext> options)
            : base(options) { }

        public DbSet<AppDetail> AppDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<Dealer> Dealers { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Customer>()
        //        .Property(p => p.IsActive)
        //        .HasDefaultValue(true); //default value = true
        //}
    }
}
