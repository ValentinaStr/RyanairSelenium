using Microsoft.EntityFrameworkCore;

namespace LoggerDb
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<LogDbModel> dataDbModel { get; set; } = null;
        
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
