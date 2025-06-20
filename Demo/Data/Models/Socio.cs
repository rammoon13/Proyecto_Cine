using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Data.Models
{
    public class Socio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ciudad { get; set; }
        public string Telefono { get; set; }
        [Column("pelicula_favorita")]
        public string PeliculaFavorita { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
