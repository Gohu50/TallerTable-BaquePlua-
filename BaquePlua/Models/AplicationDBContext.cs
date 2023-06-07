using BaquePlua.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace BaquePlua.Models
{
    public class AplicationDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // El connectionString debe venir de un archivo de configuraciones
            optionsBuilder.UseSqlServer("Server=DESKTOP-OI0V6HT\\SQLEXPRESS;Database=BaquePlua;Trusted_Connection=True")
                .EnableSensitiveDataLogging(true)
                .UseLoggerFactory(LoggerFactory.Create(builder =>
                {
                    builder.AddConsole().SetMinimumLevel(LogLevel.Information);
                }));
        }
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Genero> generos { get; set; }

    }
}
