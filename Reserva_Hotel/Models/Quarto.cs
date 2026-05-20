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
        public string NomeHotel { get; set; }

        public override string ToString()
        {
            string identificadorHotel = string.IsNullOrWhiteSpace(NomeHotel) ? null : NomeHotel;
            return $"[{identificadorHotel}] Quarto: {Numero} | {Tipo} | Diária: R$ {PrecoDiaria:N2} | Status: {Status}";
        }
    }
}