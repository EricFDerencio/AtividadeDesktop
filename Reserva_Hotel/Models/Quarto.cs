using System;

namespace Reserva_Hotel
{
    public class Quarto
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public decimal PrecoDiaria { get; set; }
        public string Status { get; set; }
        public int HotelId { get; set; }

        public override string ToString()
        {
            return $"Quarto: {Numero} | {Tipo} | Diária: R$ {PrecoDiaria:N2} | Status: {Status}";
        }
    }
}