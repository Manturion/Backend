using Backend.Entities;
using Microsoft.EntityFrameworkCore;

namespace Backend.Services
{
    public class DatabaseContext: DbContext
    {
        public DbSet<Conflict> Conflicts { get; set; }

        public DbSet<NaturalGas> NaturalGas { get; set; }

        public DbSet<Gold> Gold { get; set; }

        public DbSet<Grain> Grain { get; set; }

        public DbSet<BrentOil> BrentOil { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseMySQL("server=db;database=integracja;user=root;password=")
                .UseSnakeCaseNamingConvention();
        }
    }
}
