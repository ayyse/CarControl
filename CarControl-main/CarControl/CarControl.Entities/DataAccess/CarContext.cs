using Microsoft.EntityFrameworkCore;

namespace CarControl.Entities.DataAccess
{
    public class CarContext : DbContext
    {
        public CarContext()
        {
        }

        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {
        }


        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
