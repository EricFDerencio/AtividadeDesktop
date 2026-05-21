using Dapper;
using MySql.Data.MySqlClient;
using Reserva_Hotel.Models;
using System;
using System.Collections.Generic;

namespace Reserva_Hotel.Repositories
{
    public class PagamentoRepository : IRepository<Pagamento>
    {
        private readonly string _connectionString = "Server=localhost;Database=app_db;Uid=app_user;Pwd=app_pass;";

        public void Inserir(Pagamento pagamento)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"INSERT INTO Pagamento (hospedeId, reservaId, valorTotal, dataPagamento, formaPagamento, status, observacao)
                                   VALUES (@HospedeId, @ReservaId, @ValorTotal, @DataPagamento, @FormaPagamento, @Status, @Observacao);";

                    conn.Execute(sql, pagamento);
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erro com o banco de dados: {ex.Message}");
            }
        }

        public IEnumerable<Pagamento> ObterTodos()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"SELECT p.*, CONCAT(h.nome, ' ', h.sobrenome) AS NomeHospede
                                   FROM Pagamento p
                                   LEFT JOIN hospedes h ON p.hospedeId = h.id
                                   ORDER BY p.dataPagamento DESC;";

                    return conn.Query<Pagamento>(sql);
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erro com o banco de dados: {ex.Message}");
            }
        }

        public Pagamento ObterUm(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"SELECT p.*, CONCAT(h.nome, ' ', h.sobrenome) AS NomeHospede
                                   FROM Pagamento p
                                   LEFT JOIN hospedes h ON p.hospedeId = h.id
                                   WHERE p.id = @Id;";

                    return conn.QueryFirstOrDefault<Pagamento>(sql, new { Id = id });
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erro com o banco de dados: {ex.Message}");
            }
        }

        public void Editar(Pagamento pagamento)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"UPDATE Pagamento
                                   SET hospedeId = @HospedeId,
                                       reservaId = @ReservaId,
                                       valorTotal = @ValorTotal,
                                       dataPagamento = @DataPagamento,
                                       formaPagamento = @FormaPagamento,
                                       status = @Status,
                                       observacao = @Observacao
                                   WHERE id = @Id;";

                    conn.Execute(sql, pagamento);
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erro com o banco de dados: {ex.Message}");
            }
        }

        public void Deletar(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = "DELETE FROM Pagamento WHERE id = @Id;";

                    conn.Execute(sql, new { Id = id });
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erro com o banco de dados: {ex.Message}");
            }
        }

        public IEnumerable<Pagamento> ObterPorHospede(int hospedeId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"SELECT p.*, CONCAT(h.nome, ' ', h.sobrenome) AS NomeHospede
                                   FROM Pagamento p
                                   LEFT JOIN hospedes h ON p.hospedeId = h.id
                                   WHERE p.hospedeId = @HospedeId
                                   ORDER BY p.dataPagamento DESC;";

                    return conn.Query<Pagamento>(sql, new { HospedeId = hospedeId });
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erro com o banco de dados: {ex.Message}");
            }
        }

        public IEnumerable<Pagamento> ObterPorStatus(string status)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"SELECT p.*, CONCAT(h.nome, ' ', h.sobrenome) AS NomeHospede
                                   FROM Pagamento p
                                   LEFT JOIN hospedes h ON p.hospedeId = h.id
                                   WHERE p.status = @Status
                                   ORDER BY p.dataPagamento DESC;";

                    return conn.Query<Pagamento>(sql, new { Status = status });
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erro com o banco de dados: {ex.Message}");
            }
        }

        public IEnumerable<Pagamento> ObterPorReserva(int reservaId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"SELECT p.*, CONCAT(h.nome, ' ', h.sobrenome) AS NomeHospede
                                   FROM Pagamento p
                                   LEFT JOIN hospedes h ON p.hospedeId = h.id
                                   WHERE p.reservaId = @ReservaId
                                   ORDER BY p.dataPagamento DESC;";

                    return conn.Query<Pagamento>(sql, new { ReservaId = reservaId });
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erro com o banco de dados: {ex.Message}");
            }
        }

        public IEnumerable<dynamic> ObterResumoPorFormaPagamento()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"SELECT formaPagamento,
                                          SUM(valorTotal) AS totalValor,
                                          COUNT(*) AS quantidade
                                   FROM Pagamento
                                   WHERE status = 'Pago'
                                   GROUP BY formaPagamento
                                   ORDER BY totalValor DESC;";

                    return conn.Query(sql);
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erro com o banco de dados: {ex.Message}");
            }
        }
    }
}
