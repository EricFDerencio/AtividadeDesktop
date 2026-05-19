using Dapper;                
using MySql.Data.MySqlClient;    
using System.Collections.Generic;

namespace Reserva_Hotel
{
    public class QuartoRepository : IRepository<Quarto>
    {
       
        private readonly string conexao = "Server=localhost;Database=Hotel;Uid=root;Pwd=root;";

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
            using (MySqlConnection banco = new MySqlConnection(conexao))
            {
                string sql = "SELECT * FROM Quarto";
                return banco.Query<Quarto>(sql); 
            }
        }
    }
}