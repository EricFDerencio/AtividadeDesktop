using System;
using System.Collections.Generic;

namespace Reserva_Hotel.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        public int HospedeId { get; set; }

        // Nullable pois a tabela Reserva ainda será implementada separadamente
        public int? ReservaId { get; set; }

        public decimal ValorTotal { get; set; }
        public DateTime DataPagamento { get; set; }
        public string FormaPagamento { get; set; }
        public string Status { get; set; }
        public string Observacao { get; set; }

        // Preenchido via JOIN com hospedes — não é coluna do banco de dados
        public string NomeHospede { get; set; }

        public static readonly List<string> FormasDePagamento = new List<string>
        {
            "Dinheiro",
            "Cartão de Crédito",
            "Cartão de Débito",
            "PIX"
        };

        public static readonly List<string> StatusDisponiveis = new List<string>
        {
            "Pendente",
            "Pago",
            "Cancelado"
        };

        public override string ToString()
        {
            return $"Pagamento #{Id} | {FormaPagamento} | R$ {ValorTotal:N2} | {Status} | {DataPagamento:dd/MM/yyyy}";
        }
    }
}
