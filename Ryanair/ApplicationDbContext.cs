using Ryanair.Flight;
using Microsoft.EntityFrameworkCore;

namespace Ryanair
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<DataFlight> dataFlights { get; set; } = null;

        public DbSet<FlightDetails> flightsDetails { get; set; } = null;

        private static ApplicationDbContext? _instance;
       
        private ApplicationDbContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public static ApplicationDbContext GetApplicationContext()
        {
            _instance ??= new ApplicationDbContext();
            return _instance;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RyanairAppdb;Trusted_Connection=True;");
        }
    }
}
