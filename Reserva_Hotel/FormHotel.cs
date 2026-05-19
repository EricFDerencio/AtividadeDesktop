using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reserva_Hotel.Models;
using Reserva_Hotel.Repositories;

namespace Reserva_Hotel {
    public partial class FormHotel : Form {
        private HotelRepository _hotelRepository = new HotelRepository();
        private int idHotelSelecionado = 0;
        public FormHotel() {
            InitializeComponent();
        }

        private void FormHotel_Load(object sender, EventArgs e) {
            CarregarHoteis();
        }

        private void CarregarHoteis() {
            List<Hotel> lista = _hotelRepository.ObterTodos();

            listBox1.Items.Clear();

            foreach (Hotel hotel in lista) {
                listBox1.Items.Add(hotel);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

            if (listBox1.SelectedItem is Hotel hotelSelecionado) {
                idHotelSelecionado = hotelSelecionado.Id;
                txtNomeHotel.Text = hotelSelecionado.Nome.ToString();
                txtEnderecoHotel.Text = hotelSelecionado.Endereco.ToString();
                txtCidadeHotel.Text = hotelSelecionado.Cidade.ToString();
                txtTelefoneHotel.Text = hotelSelecionado.Telefone.ToString();
                cmbBxEstrelasHotel.SelectedItem = hotelSelecionado.Estrelas.ToString();
            }

        }

        private void btnSalvarHotel_Click(object sender, EventArgs e) {
            try {
                if (!ValidarCampos()) {
                    return;
                }

                Hotel novoHotel = new Hotel {
                    Nome = txtNomeHotel.Text,
                    Endereco = txtEnderecoHotel.Text,
                    Cidade = txtCidadeHotel.Text,
                    Telefone = txtTelefoneHotel.Text,
                    Estrelas = int.Parse(cmbBxEstrelasHotel.Text.Trim()),
                    Id = 1

                };


                _hotelRepository.Inserir(novoHotel);

                MessageBox.Show("Hotel cadastrado com sucesso no banco de dados!",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
                CarregarHoteis();
            }
            catch (Exception ex) {
                MessageBox.Show($"Ocorreu um erro inesperado no banco de dados: {ex.Message}",
                    "Erro do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private bool ValidarCampos() {
            if (string.IsNullOrWhiteSpace(txtNomeHotel.Text)) {
                MessageBox.Show("'Nome do hotel' é obrigatório.",
                    "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeHotel.Focus();
                return false;
            }            

            if (string.IsNullOrWhiteSpace(txtEnderecoHotel.Text)) {
                MessageBox.Show("'Endereço do hotel' é obrigatório.",
                    "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnderecoHotel.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCidadeHotel.Text)) {
                MessageBox.Show("'Cidade do hotel' é obrigatório.",
                    "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCidadeHotel.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefoneHotel.Text)) {
                MessageBox.Show("'Telefone do hotel' é obrigatório.",
                    "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefoneHotel.Focus();
                return false;
            }

            if (cmbBxEstrelasHotel.SelectedItem == null) {
                MessageBox.Show("'Estrelas do hotel' é obrigatório.",
                    "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbBxEstrelasHotel.Focus();
                return false;
            }

            return true;
        }

        private void LimparCampos() {
            txtNomeHotel.Clear();
            txtEnderecoHotel.Clear();
            txtCidadeHotel.Clear();
            txtTelefoneHotel.Clear();
            cmbBxEstrelasHotel.SelectedIndex = -1;
        }

        private void btnEditarHotel_Click(object sender, EventArgs e) {
            try {
                if (idHotelSelecionado == 0) {
                    MessageBox.Show("Selecione um hotel na lista antes de editar!",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidarCampos()) {
                    return;
                }

                Hotel hotelEditado = new Hotel {
                    Id = idHotelSelecionado,
                    Nome = txtNomeHotel.Text,
                    Endereco = txtEnderecoHotel.Text,
                    Cidade = txtCidadeHotel.Text,
                    Telefone = txtTelefoneHotel.Text,
                    Estrelas = int.Parse(cmbBxEstrelasHotel.Text.Trim()),
                };

                _hotelRepository.Editar(hotelEditado);
                MessageBox.Show("Hotel atualizado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                idHotelSelecionado = 0;
                LimparCampos();
                CarregarHoteis();
            }
            catch (Exception ex) {
                MessageBox.Show($"Erro ao editar: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluirHotel_Click(object sender, EventArgs e) {
            try {
                if (idHotelSelecionado == 0) {
                    MessageBox.Show("Selecione um hotel na lista antes de excluir!",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir este hotel?",
                    "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes) {
                    _hotelRepository.Deletar(idHotelSelecionado);
                    MessageBox.Show("hotel removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    idHotelSelecionado = 0; // Reseta o ID
                    LimparCampos();
                    CarregarHoteis();
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Erro ao excluir: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
