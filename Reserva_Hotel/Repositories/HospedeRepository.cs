using Dapper;
using MySql.Data.MySqlClient;
using Reserva_Hotel.Models;
using System;
using System.Collections.Generic;

namespace Reserva_Hotel.Repositories
{
    public class HospedeRepository : IRepository<Hospede>
    {
        private readonly string _connectionString = "Server=localhost;Database=Hotel;Uid=root;Pwd=root;";

        public void Inserir(Hospede hospede)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"INSERT INTO hospedes (nome, sobrenome, cpf, dataNascimento, email, telefone) 
                                   VALUES (@Nome, @Sobrenome, @Cpf, @DataNascimento, @Email, @Telefone);";

                    conn.Execute(sql, hospede);
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erro com o banco de dados: {ex.Message}");
            }
        }

        public IEnumerable<Hospede> ObterTodos()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = "SELECT * FROM hospedes;";

                    return conn.Query<Hospede>(sql);
                }
            }
            catch (MySqlException ex) 
            {
                throw new Exception($"Erro com o banco de dados: {ex.Message}");
            }

        }

        public void Editar(Hospede hospede)
        {
            try
            {

                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"UPDATE hospedes
                               SET nome = @Nome, sobrenome = @Sobrenome, cpf = @Cpf, dataNascimento = @DataNascimento
                                   email = @Email, telefone = @Telefone
                               WHERE id = @Id;";

                    conn.Execute(sql, hospede);
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

                    string sql = "DELETE FROM hospedes WHERE id = @Id;";

                    conn.Execute(sql, new { Id = id });
                }
            }
            catch (MySqlException ex) 
            {
                throw new Exception($"Erro com o banco de dados: {ex.Message}");
            }
        }
    }
}
