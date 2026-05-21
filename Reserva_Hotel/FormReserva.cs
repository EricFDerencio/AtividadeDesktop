using Reserva_Hotel.Models;
using Reserva_Hotel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Reserva_Hotel
{
    public partial class FormReserva : Form
    {
        private ReservaRepository _reservaRepository;

        public FormReserva()
        {
            InitializeComponent();
            _reservaRepository = new ReservaRepository();
        }

        private void FormReserva_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarComboStatus();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar tela: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarComboStatus()
        {
            cboBuscaStatus.Items.Clear();
            cboBuscaStatus.Items.Add("Todos");

            foreach (string s in Reserva.StatusDisponiveis)
                cboBuscaStatus.Items.Add(s);

            cboBuscaStatus.SelectedIndex = 0;
        }

        private void CarregarGrid()
        {
            try
            {
                List<Reserva> reservas;

                string statusFiltro = cboBuscaStatus.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(statusFiltro) || statusFiltro == "Todos")
                    reservas = _reservaRepository.ObterTodos().ToList();
                else
                    reservas = _reservaRepository.ObterPorStatus(statusFiltro).ToList();

                gridReservas.DataSource = reservas;
                lblTotalReservas.Text = $"Total: {reservas.Count} reservas";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cboBuscaStatus.SelectedIndex = 0;
            CarregarGrid();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                FormEditarReserva formNova = new FormEditarReserva(null, _reservaRepository);

                if (formNova.ShowDialog() == DialogResult.OK)
                {
                    CarregarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir cadastro: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridReservas.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Selecione uma reserva para editar.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = (int)gridReservas.SelectedRows[0].Cells["Id"].Value;
                Reserva reserva = _reservaRepository.ObterUm(id);

                if (reserva != null)
                {
                    FormEditarReserva formEditar = new FormEditarReserva(reserva, _reservaRepository);

                    if (formEditar.ShowDialog() == DialogResult.OK)
                    {
                        CarregarGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar reserva: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridReservas.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Selecione uma reserva para excluir.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = (int)gridReservas.SelectedRows[0].Cells["Id"].Value;
                string info = gridReservas.SelectedRows[0].Cells["NomeHospede"].Value?.ToString() ?? $"ID {id}";

                DialogResult resultado = MessageBox.Show(
                    $"Deseja mesmo excluir a reserva de '{info}'?",
                    "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    _reservaRepository.Deletar(id);
                    MessageBox.Show("Reserva excluída com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CarregarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir reserva: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
