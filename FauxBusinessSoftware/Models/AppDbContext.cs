using Microsoft.EntityFrameworkCore;


namespace FauxBusinessSoftware.Models
{
    public class AppDbContext : DbContext 
    {
        //public DbSet<Employee> Employees { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }
}
