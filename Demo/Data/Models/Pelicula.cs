using System.Collections.Generic;

namespace Demo.Data.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string ImagenUrl { get; set; }
        public List<Sesion> Sesiones { get; set; } = new();
    }
}
