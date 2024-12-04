using LocationMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace LocationMVC.Services
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Appartement> Appartements { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appartement>()
                .Property(a => a.Price)
                .HasPrecision(18, 2); // Précision totale de 18 chiffres, avec 2 décimales

            base.OnModelCreating(modelBuilder);
        }
    }
}