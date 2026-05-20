using Reserva_Hotel.Models;
using Reserva_Hotel.Repositories;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Reserva_Hotel
{
    public partial class FormEditarPagamento : Form
    {
        private Pagamento _pagamento;
        private PagamentoRepository _pagamentoRepository;
        private HospedeRepository _hospedeRepository;

        public FormEditarPagamento(Pagamento pagamento, PagamentoRepository repository)
        {
            InitializeComponent();
            _pagamento = pagamento;
            _pagamentoRepository = repository;
            _hospedeRepository = new HospedeRepository();
        }

        private void FormEditarPagamento_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarCombos();

                if (_pagamento is null)
                {
                    this.Text = "Cadastrar Pagamento";
                    LimparCampos();
                }
                else
                {
                    this.Text = "Editar Pagamento";
                    PreencherDados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao carregar o formulário: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarCombos()
        {
            cboFormaPagamento.Items.Clear();
            foreach (string forma in Pagamento.FormasDePagamento)
                cboFormaPagamento.Items.Add(forma);
            cboFormaPagamento.SelectedIndex = 0;

            cboStatus.Items.Clear();
            foreach (string status in Pagamento.StatusDisponiveis)
                cboStatus.Items.Add(status);
            cboStatus.SelectedIndex = 0;

            // Usa DisplayMember para exibir "Nome Sobrenome" sem depender do ToString() da classe Hospede
            var hospedes = _hospedeRepository.ObterTodos()
                .Select(h => new { h.Id, NomeCompleto = $"{h.Nome} {h.Sobrenome}" })
                .ToList();

            cboHospede.DataSource = hospedes;
            cboHospede.DisplayMember = "NomeCompleto";
            cboHospede.ValueMember = "Id";
        }

        private void LimparCampos()
        {
            if (cboHospede.Items.Count > 0)
                cboHospede.SelectedIndex = 0;

            txtBxValorTotal.Text = "0,00";
            dtpDataPagamento.Value = DateTime.Now;
            cboFormaPagamento.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            txtBxReservaId.Clear();
            txtBxObservacao.Clear();
            cboHospede.Focus();
        }

        private void PreencherDados()
        {
            cboHospede.SelectedValue = _pagamento.HospedeId;
            txtBxValorTotal.Text = _pagamento.ValorTotal.ToString("N2");
            dtpDataPagamento.Value = _pagamento.DataPagamento;
            cboFormaPagamento.SelectedItem = _pagamento.FormaPagamento;
            cboStatus.SelectedItem = _pagamento.Status;
            txtBxReservaId.Text = _pagamento.ReservaId.HasValue ? _pagamento.ReservaId.Value.ToString() : "";
            txtBxObservacao.Text = _pagamento.Observacao ?? "";
        }

        private bool ValidarCampos()
        {
            if (cboHospede.SelectedItem == null)
            {
                MessageBox.Show("Selecione um hóspede.", "Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboHospede.Focus();
                return false;
            }

            string valorTexto = txtBxValorTotal.Text.Replace(",", ".").Trim();
            if (!decimal.TryParse(valorTexto,
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out decimal valor) || valor <= 0)
            {
                MessageBox.Show("Informe um valor total válido e maior que zero.", "Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBxValorTotal.Focus();
                return false;
            }

            if (cboFormaPagamento.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma forma de pagamento.", "Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboFormaPagamento.Focus();
                return false;
            }

            if (cboStatus.SelectedItem == null)
            {
                MessageBox.Show("Selecione o status do pagamento.", "Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboStatus.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtBxReservaId.Text) &&
                !int.TryParse(txtBxReservaId.Text.Trim(), out _))
            {
                MessageBox.Show("O ID da reserva deve ser um número inteiro.", "Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBxReservaId.Focus();
                return false;
            }

            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {
                int hospedeId = (int)cboHospede.SelectedValue;

                string valorTexto = txtBxValorTotal.Text.Replace(",", ".").Trim();
                decimal valor = decimal.Parse(valorTexto,
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture);

                int? reservaId = null;
                if (!string.IsNullOrWhiteSpace(txtBxReservaId.Text))
                    reservaId = int.Parse(txtBxReservaId.Text.Trim());

                if (_pagamento is null)
                {
                    Pagamento novoPagamento = new Pagamento
                    {
                        HospedeId = hospedeId,
                        ReservaId = reservaId,
                        ValorTotal = valor,
                        DataPagamento = dtpDataPagamento.Value,
                        FormaPagamento = cboFormaPagamento.SelectedItem.ToString(),
                        Status = cboStatus.SelectedItem.ToString(),
                        Observacao = txtBxObservacao.Text.Trim()
                    };

                    _pagamentoRepository.Inserir(novoPagamento);
                    MessageBox.Show("Pagamento cadastrado com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _pagamento.HospedeId = hospedeId;
                    _pagamento.ReservaId = reservaId;
                    _pagamento.ValorTotal = valor;
                    _pagamento.DataPagamento = dtpDataPagamento.Value;
                    _pagamento.FormaPagamento = cboFormaPagamento.SelectedItem.ToString();
                    _pagamento.Status = cboStatus.SelectedItem.ToString();
                    _pagamento.Observacao = txtBxObservacao.Text.Trim();

                    _pagamentoRepository.Editar(_pagamento);
                    MessageBox.Show("Pagamento atualizado com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar pagamento: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
