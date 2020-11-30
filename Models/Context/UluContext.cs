using Microsoft.EntityFrameworkCore;
using QonaqWebApp.Models.Entity;

namespace UluGida.Models.Context
{
    public class UluContext : DbContext
    {
        public UluContext(DbContextOptions<UluContext> options)
            : base(options) { }

        public DbSet<AppDetail> AppDetails { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Customer>()
        //        .Property(p => p.IsActive)
        //        .HasDefaultValue(true); //default value = true
        //}
    }
}
