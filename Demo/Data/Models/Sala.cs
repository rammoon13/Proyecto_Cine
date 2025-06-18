using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Data.Models
{
    public class Sala
    {
        public int Id { get; set; }
        [Column("numero_sala")]
        public int NumeroSala { get; set; }
        public List<Sesion> Sesiones { get; set; } = new();
        public List<Butaca> Butacas { get; set; } = new();
    }
}
