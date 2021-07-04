using Microsoft.EntityFrameworkCore;
using SampleProjects.EntityFrameworkApp.V1.WeatherForecast;
using Xtz.StronglyTyped.EntityFramework;

namespace SampleProjects.EntityFrameworkApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // NOTE: Register all supported strong types (this is the only thing you have to do)
            // NOTE: It scans the actual model and configures each single strongly-typed property
            modelBuilder.RegisterStronglyTypedConverters();

            base.OnModelCreating(modelBuilder);
        }
    }
}
