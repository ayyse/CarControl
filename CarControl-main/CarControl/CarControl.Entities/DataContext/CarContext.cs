using CarControl.Entities.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace CarControl.Entities.DataContext
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
