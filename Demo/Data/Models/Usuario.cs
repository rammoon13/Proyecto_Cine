using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Data.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Column("nombre_usuario")]
        public string NombreUsuario { get; set; }
        [Column("correo_electronico")]
        public string CorreoElectronico { get; set; }

        [Column("contrasena")]
        public string Contrasena { get; set; }

        [Column("rol")]
        public Rol Rol { get; set; } = Rol.Cliente;

        [Column("es_socio")]
        public bool EsSocio { get; set; } = false;

        public Socio? Socio { get; set; }
    }
}
