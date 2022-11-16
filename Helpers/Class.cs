using DBQuery.Model;
using Microsoft.EntityFrameworkCore;

namespace DBQuery.Helpers
{
    public class Class
    {
        protected readonly IConfiguration Configuration;
        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<ActionMonitor> ActionMonitor { get; set; }
    }
}
