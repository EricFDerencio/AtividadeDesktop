using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Reserva_Hotel
{
    public class QuartoRepository : IRepository<Quarto>
    {

        private readonly string conexao = "Server=localhost;Database=app_db;Uid=app_user;Pwd=app_pass;";

        public void Inserir(Quarto quarto)
        {
            using (MySqlConnection banco = new MySqlConnection(conexao))
            {

                string sql = "INSERT INTO Quarto (numero, tipo, precoDiaria, status, hotelId) " +
                    "VALUES (@Numero, @Tipo, @PrecoDiaria, @Status, @HotelId)";
                banco.Execute(sql, quarto);
            }
        }

        public void Editar(Quarto quarto)
        {
            using (MySqlConnection banco = new MySqlConnection(conexao))
            {
                string sql = @"UPDATE Quarto 
                       SET numero = @Numero, tipo = @Tipo, precoDiaria = @PrecoDiaria, status = @Status
                       WHERE id = @Id";
                banco.Execute(sql, quarto);
            }
        }

        public void Deletar(int id)
        {
            using (MySqlConnection banco = new MySqlConnection(conexao))
            {
                string sql = "DELETE FROM Quarto WHERE id = @Id";
                banco.Execute(sql, new { Id = id });
            }
        }

        public IEnumerable<Quarto> ObterTodos()
        {
            using (MySqlConnection banco = new MySqlConnection(conexao)) { 

                string sql = @"SELECT 
                                q.id AS Id, 
                                q.numero AS Numero, 
                                q.tipo AS Tipo, 
                                q.precoDiaria AS PrecoDiaria, 
                                q.status AS Status, 
                                q.hotelId AS HotelId,
                                h.nome AS NomeHotel
                               FROM Quarto q
                               INNER JOIN Hotel h ON q.hotelId = h.id";

                return banco.Query<Quarto>(sql);
            }
        }
    }
}