using System.Collections.Generic;

namespace Demo.Data.Models
{
    public class Butaca
    {
        public int Id { get; set; }
        public int IdSala { get; set; }
        public Sala Sala { get; set; }
        public int Fila { get; set; }
        public int Numero { get; set; }
        public List<Reserva> Reservas { get; set; } = new();
    }
}
