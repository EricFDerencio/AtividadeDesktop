using System;

namespace Reserva_Hotel.Models
{
    public class Hospede
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }


        public override string ToString()
        {
            return base.ToString();
        }

        public string PrintMessage()
        {
            return $"Hospede {this.Id}" +
                $"\nNome: {this.Nome} {this.Sobrenome}" +
                $"\nCPF: {this.Cpf}" +
                $"\nData de Nascimento: {this.DataNascimento}" +
                $"\nEmail: {this.Email}" +
                $"\nTelefone: {this.Telefone}";
        }

    }
}
