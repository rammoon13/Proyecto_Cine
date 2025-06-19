using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Data.Models
{
    public class Socio
    {
        public int Id { get; set; }

        [Column("id_usuario")]
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        [Column("fecha_nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        public string Ciudad { get; set; }

        [Column("pelicula_favorita")]
        public string PeliculaFavorita { get; set; }
        public string Telefono { get; set; }
    }
}
