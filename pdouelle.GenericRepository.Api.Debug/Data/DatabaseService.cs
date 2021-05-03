using Microsoft.EntityFrameworkCore;
using pdouelle.GenericRepository.Api.Debug.Entities;

namespace pdouelle.GenericRepository.Api.Debug.Data
{
    public class DatabaseService : DbContext
    {
        public DatabaseService(DbContextOptions<DatabaseService> options) : base(options)
        {
        }

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}