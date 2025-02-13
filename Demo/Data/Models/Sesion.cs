using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;

namespace Demo.Data.Models
{
    public class Sesion
    {
        public int Id { get; set; }
        [Column("id_pelicula")]
        public int IdPelicula { get; set; }
        public Pelicula Pelicula { get; set; }
        [Column("id_sala")]
        public int IdSala { get; set; }
        public Sala Sala { get; set; }
        public TimeSpan Hora { get; set; }
        [Column("id_dia")]
        public int IdDia { get; set; }
        public Dia Dia { get; set; }
    }
}
