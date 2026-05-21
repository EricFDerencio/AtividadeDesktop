using System;

namespace Reserva_Hotel.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public int HospedeId { get; set; }
        public int QuartoId { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public string Status { get; set; }

        // Preenchidos via JOIN — não são colunas do banco de dados
        public string NomeHospede { get; set; }
        public int NumeroQuarto { get; set; }
        public string NomeHotel { get; set; }

        public static readonly System.Collections.Generic.List<string> StatusDisponiveis = new System.Collections.Generic.List<string>
        {
            "Confirmada",
            "Check-in",
            "Check-out",
            "Cancelada"
        };

        public override string ToString()
        {
            return $"Reserva #{Id} | {NomeHospede} | Quarto {NumeroQuarto} | {DataEntrada:dd/MM/yyyy} - {DataSaida:dd/MM/yyyy} | {Status}";
        }
    }
}
