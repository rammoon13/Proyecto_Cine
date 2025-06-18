namespace Demo.Data.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public int IdSesion { get; set; }
        public Sesion Sesion { get; set; }
        public int IdButaca { get; set; }
        public Butaca Butaca { get; set; }
    }
}
