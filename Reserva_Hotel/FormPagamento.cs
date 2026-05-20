using Reserva_Hotel.Models;
using Reserva_Hotel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Reserva_Hotel
{
    public partial class FormPagamento : Form
    {
        private PagamentoRepository _pagamentoRepository;

        public FormPagamento()
        {
            InitializeComponent();
            _pagamentoRepository = new PagamentoRepository();
        }

        private void FormPagamento_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarComboStatus();
                CarregarGrid();
                CarregarResumoListBox();
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

            foreach (string s in Pagamento.StatusDisponiveis)
                cboBuscaStatus.Items.Add(s);

            cboBuscaStatus.SelectedIndex = 0;
        }

        private void CarregarGrid()
        {
            try
            {
                List<Pagamento> pagamentos;

                string statusFiltro = cboBuscaStatus.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(statusFiltro) || statusFiltro == "Todos")
                    pagamentos = _pagamentoRepository.ObterTodos().ToList();
                else
                    pagamentos = _pagamentoRepository.ObterPorStatus(statusFiltro).ToList();

                gridPagamentos.DataSource = pagamentos;

                decimal totalValor = pagamentos.Sum(p => p.ValorTotal);
                lblTotalRegistros.Text = $"Total: {pagamentos.Count} registros";
                lblTotalValor.Text = $"Soma: R$ {totalValor:N2}";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void CarregarResumoListBox()
        {
            try
            {
                lstbResumo.Items.Clear();
                lstbResumo.Items.Add("=== Pagamentos Recebidos ===");
                lstbResumo.Items.Add("");

                var resumo = _pagamentoRepository.ObterResumoPorFormaPagamento();

                decimal totalGeral = 0;
                int qtdGeral = 0;

                foreach (dynamic item in resumo)
                {
                    string forma = item.formaPagamento;
                    decimal total = (decimal)item.totalValor;
                    int qtd = Convert.ToInt32(item.quantidade);

                    lstbResumo.Items.Add($"{forma}:");
                    lstbResumo.Items.Add($"  R$ {total:N2} ({qtd} pag.)");
                    lstbResumo.Items.Add("");

                    totalGeral += total;
                    qtdGeral += qtd;
                }

                lstbResumo.Items.Add("──────────────────");
                lstbResumo.Items.Add($"Total recebido:");
                lstbResumo.Items.Add($"  R$ {totalGeral:N2} ({qtdGeral} pag.)");
            }
            catch (Exception ex)
            {
                lstbResumo.Items.Clear();
                lstbResumo.Items.Add($"Erro: {ex.Message}");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CarregarGrid();
                CarregarResumoListBox();
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
            CarregarResumoListBox();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                FormEditarPagamento formNovo = new FormEditarPagamento(null, _pagamentoRepository);

                if (formNovo.ShowDialog() == DialogResult.OK)
                {
                    CarregarGrid();
                    CarregarResumoListBox();
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
                if (gridPagamentos.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Selecione um pagamento para editar.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = (int)gridPagamentos.SelectedRows[0].Cells["Id"].Value;
                Pagamento pagamento = _pagamentoRepository.ObterUm(id);

                if (pagamento != null)
                {
                    FormEditarPagamento formEditar = new FormEditarPagamento(pagamento, _pagamentoRepository);

                    if (formEditar.ShowDialog() == DialogResult.OK)
                    {
                        CarregarGrid();
                        CarregarResumoListBox();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar pagamento: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridPagamentos.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Selecione um pagamento para excluir.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = (int)gridPagamentos.SelectedRows[0].Cells["Id"].Value;
                string info = gridPagamentos.SelectedRows[0].Cells["NomeHospede"].Value?.ToString() ?? $"ID {id}";

                DialogResult resultado = MessageBox.Show(
                    $"Deseja mesmo excluir o pagamento de '{info}'?",
                    "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    _pagamentoRepository.Deletar(id);
                    MessageBox.Show("Pagamento excluído com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CarregarGrid();
                    CarregarResumoListBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir pagamento: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
