using Dapper;
using MySql.Data.MySqlClient;
using Reserva_Hotel.Models;
using System;
using System.Collections.Generic;

namespace Reserva_Hotel.Repositories
{
    public class ReservaRepository : IRepository<Reserva>
    {
        private readonly string _connectionString = "Server=localhost;Database=app_db;Uid=app_user;Pwd=app_pass;";

        public void Inserir(Reserva reserva)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"INSERT INTO Reserva (hospedeId, quartoId, dataEntrada, dataSaida, status)
                                   VALUES (@HospedeId, @QuartoId, @DataEntrada, @DataSaida, @Status);";

                    conn.Execute(sql, reserva);
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erro com o banco de dados: {ex.Message}");
            }
        }

        public IEnumerable<Reserva> ObterTodos()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"SELECT r.id AS Id,
                                          r.hospedeId AS HospedeId,
                                          r.quartoId AS QuartoId,
                                          r.dataEntrada AS DataEntrada,
                                          r.dataSaida AS DataSaida,
                                          r.status AS Status,
                                          CONCAT(h.nome, ' ', h.sobrenome) AS NomeHospede,
                                          q.numero AS NumeroQuarto,
                                          ht.nome AS NomeHotel
                                   FROM Reserva r
                                   LEFT JOIN hospedes h ON r.hospedeId = h.id
                                   LEFT JOIN Quarto q ON r.quartoId = q.id
                                   LEFT JOIN Hotel ht ON q.hotelId = ht.id
                                   ORDER BY r.dataEntrada DESC;";

                    return conn.Query<Reserva>(sql);
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erro com o banco de dados: {ex.Message}");
            }
        }

        public Reserva ObterUm(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"SELECT r.id AS Id,
                                          r.hospedeId AS HospedeId,
                                          r.quartoId AS QuartoId,
                                          r.dataEntrada AS DataEntrada,
                                          r.dataSaida AS DataSaida,
                                          r.status AS Status,
                                          CONCAT(h.nome, ' ', h.sobrenome) AS NomeHospede,
                                          q.numero AS NumeroQuarto,
                                          ht.nome AS NomeHotel
                                   FROM Reserva r
                                   LEFT JOIN hospedes h ON r.hospedeId = h.id
                                   LEFT JOIN Quarto q ON r.quartoId = q.id
                                   LEFT JOIN Hotel ht ON q.hotelId = ht.id
                                   WHERE r.id = @Id;";

                    return conn.QueryFirstOrDefault<Reserva>(sql, new { Id = id });
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erro com o banco de dados: {ex.Message}");
            }
        }

        public void Editar(Reserva reserva)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"UPDATE Reserva
                                   SET hospedeId = @HospedeId,
                                       quartoId = @QuartoId,
                                       dataEntrada = @DataEntrada,
                                       dataSaida = @DataSaida,
                                       status = @Status
                                   WHERE id = @Id;";

                    conn.Execute(sql, reserva);
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

                    string sql = "DELETE FROM Reserva WHERE id = @Id;";

                    conn.Execute(sql, new { Id = id });
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erro com o banco de dados: {ex.Message}");
            }
        }

        public IEnumerable<Reserva> ObterPorStatus(string status)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"SELECT r.id AS Id,
                                          r.hospedeId AS HospedeId,
                                          r.quartoId AS QuartoId,
                                          r.dataEntrada AS DataEntrada,
                                          r.dataSaida AS DataSaida,
                                          r.status AS Status,
                                          CONCAT(h.nome, ' ', h.sobrenome) AS NomeHospede,
                                          q.numero AS NumeroQuarto,
                                          ht.nome AS NomeHotel
                                   FROM Reserva r
                                   LEFT JOIN hospedes h ON r.hospedeId = h.id
                                   LEFT JOIN Quarto q ON r.quartoId = q.id
                                   LEFT JOIN Hotel ht ON q.hotelId = ht.id
                                   WHERE r.status = @Status
                                   ORDER BY r.dataEntrada DESC;";

                    return conn.Query<Reserva>(sql, new { Status = status });
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erro com o banco de dados: {ex.Message}");
            }
        }
    }
}
