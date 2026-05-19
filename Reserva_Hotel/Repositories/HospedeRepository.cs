using Dapper;
using MySql.Data.MySqlClient;
using Reserva_Hotel.Models;
using System.Collections.Generic;

namespace Reserva_Hotel.Repositories
{
    public class HospedeRepository : IRepository<Hospede>
    {
        private readonly string conexao = "Server=localhost;Database=Hotel;Uid=root;Pwd=root;";

        public void Inserir(Hospede hospede)
        {
            using (MySqlConnection banco = new MySqlConnection(conexao))
            {
                string sql = @"INSERT INTO hospedes (nome, sobrenome, cpf, dataNascimento, email, telefone) 
                               VALUES (@Nome, @Sobrenome, @Cpf, @DataNascimento, @Email, @Telefone);";

                banco.Execute(sql, hospede);
            }
        }

        public IEnumerable<Hospede> ObterTodos()
        {
            using (MySqlConnection banco = new MySqlConnection(conexao))
            {
                string sql = "SELECT * FROM hospedes;";

                return banco.Query<Hospede>(sql);
            }
        }

        public void Editar(Hospede hospede)
        {
            using (MySqlConnection banco = new MySqlConnection(conexao))
            {
                string sql = @"UPDATE hospedes
                               SET nome = @Nome, sobrenome = @Sobrenome, cpf = @Cpf, dataNascimento = @DataNascimento
                                   email = @Email, telefone = @Telefone
                               WHERE id = @Id;";

                banco.Execute(sql, hospede);
            }
        }

        public void Deletar(int id)
        {
            using (MySqlConnection banco = new MySqlConnection(conexao))
            {
                string sql = "DELETE FROM hospedes WHERE id = @Id;";

                banco.Execute(sql, new { Id = id });
            }
        }
    }
}
