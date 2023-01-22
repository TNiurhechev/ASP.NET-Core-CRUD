using Microsoft.EntityFrameworkCore;
using Chita309KP.Models;
namespace Chita309KP.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<Phone> Phone { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Worker> Worker { get; set; }
    }
}
