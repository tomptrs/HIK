using BusinessFacade;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ArchitectDbContext : DbContext
    {
        public ArchitectDbContext(DbContextOptions<ArchitectDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Customer>().ToTable("Customer");
        }
    }
}
