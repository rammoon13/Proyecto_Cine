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
        public DbSet<Socio> Socios { get; set; }
        public DbSet<Butaca> Butacas { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

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

            modelBuilder.Entity<Butaca>()
                .HasOne(b => b.Sala)
                .WithMany(s => s.Butacas)
                .HasForeignKey(b => b.IdSala);

            modelBuilder.Entity<Reserva>()
                .HasOne(r => r.Sesion)
                .WithMany()
                .HasForeignKey(r => r.IdSesion);

            modelBuilder.Entity<Reserva>()
                .HasOne(r => r.Butaca)
                .WithMany(b => b.Reservas)
                .HasForeignKey(r => r.IdButaca);

            modelBuilder.Entity<Reserva>()
                .HasOne(r => r.Usuario)
                .WithMany()
                .HasForeignKey(r => r.IdUsuario);

            modelBuilder.Entity<Reserva>()
                .HasIndex(r => new { r.IdSesion, r.IdButaca })
                .IsUnique();

            modelBuilder.Entity<Socio>()
                .HasOne(s => s.Usuario)
                .WithOne()
                .HasForeignKey<Socio>(s => s.IdUsuario);
        }
    }
}
