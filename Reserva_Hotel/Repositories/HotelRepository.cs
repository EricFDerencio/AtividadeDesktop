using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;
using MySql.Data.MySqlClient;
using Reserva_Hotel.Models;

namespace Reserva_Hotel.Repositories {
    public class HotelRepository {
        private readonly string conexao = "Server=localhost;Database=Hotel;Uid=root;Pwd=Quantoe381-672;";


        public List<Hotel> ObterTodos() {
            List<Hotel> lista = new List<Hotel>();

            MySqlConnection conn = new MySqlConnection(conexao);

            try {
                conn.Open();

                string sql = "SELECT * FROM hotel";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    Hotel hotel = new Hotel();

                    hotel.Id = Convert.ToInt32(reader["id"]);

                    hotel.Nome = reader["nome"].ToString();

                    hotel.Endereco = reader["endereco"].ToString();

                    hotel.Cidade = reader["cidade"].ToString();

                    hotel.Telefone = reader["telefone"].ToString();

                    hotel.Estrelas = Convert.ToInt32(reader["estrelas"]);

                    lista.Add(hotel);
                }

                reader.Close();
            }
            finally {
                conn.Close();
            }

            return lista;
        }

        public void Inserir(Hotel hotel) {
            using (MySqlConnection banco = new MySqlConnection(conexao)) {

                banco.Open();

                string sql = "INSERT INTO hotel (nome, endereco, cidade, telefone, estrelas) " +
                    "VALUES (@Nome, @Endereco, @Cidade, @Telefone, @Estrelas)";
                banco.Execute(sql, hotel);
            }
        }

        public void Editar(Hotel hotel) {
            using (MySqlConnection banco = new MySqlConnection(conexao)) {
                string sql = @"UPDATE hotel 
                       SET nome = @Nome, endereco = @Endereco, cidade = @Cidade, telefone = @Telefone, estrelas = @Estrelas 
                       WHERE id = @Id";
                banco.Execute(sql, hotel);
            }
        }

        public void Deletar(int id) {
            using (MySqlConnection banco = new MySqlConnection(conexao)) {
                string sql = "DELETE FROM hotel WHERE id = @Id";
                banco.Execute(sql, new { Id = id });
            }
        }
    }
}
