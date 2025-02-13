using Demo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.Data
{
    public class CinemaDbContext : DbContext
    {
        public CinemaDbContext(DbContextOptions<CinemaDbContext> options) : base(options) { }

        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Dia> Dia { get; set; }
        public DbSet<Sesion> Sesion { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurar relaciones
            modelBuilder.Entity<Sesion>()
                .HasOne(s => s.Pelicula)
                .WithMany(p => p.Sesiones)
                .HasForeignKey(s => s.IdPelicula);

            modelBuilder.Entity<Sesion>()
                .HasOne(s => s.Sala)
                .WithMany(s => s.Sesiones)
                .HasForeignKey(s => s.IdSala);

            modelBuilder.Entity<Sesion>()
                .HasOne(s => s.Dia)
                .WithMany(d => d.Sesiones)
                .HasForeignKey(s => s.IdDia);
        }
    }
}
