using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Data.Models
{
    public class Dia
    {
        public int Id { get; set; }
        [Column("dia_semana")]
        public string DiaSemana { get; set; }

        // Relación con Sesion
        public List<Sesion> Sesiones { get; set; } = new List<Sesion>();
    }
}
