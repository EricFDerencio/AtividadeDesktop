using Reserva_Hotel.Models;
using Reserva_Hotel.Repositories;
using System;
using System.Windows.Forms;

namespace Reserva_Hotel
{
    public partial class FormEditarReserva : Form
    {
        private Reserva _reserva;
        private ReservaRepository _reservaRepository;
        private HospedeRepository _hospedeRepository;
        private QuartoRepository _quartoRepository;
        private bool _modoEdicao;

        public FormEditarReserva(Reserva reserva, ReservaRepository reservaRepository)
        {
            InitializeComponent();
            _reserva = reserva;
            _reservaRepository = reservaRepository;
            _hospedeRepository = new HospedeRepository();
            _quartoRepository = new QuartoRepository();
            _modoEdicao = reserva != null;
        }

        private void FormEditarReserva_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarCombos();

                if (_modoEdicao)
                {
                    lblTitulo.Text = "Editar Reserva";
                    this.Text = "Editar Reserva";
                    PreencherCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar formulário: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarCombos()
        {
            // Carregar hóspedes
            cboHospede.Items.Clear();
            var hospedes = _hospedeRepository.ObterTodos();
            foreach (var h in hospedes)
            {
                cboHospede.Items.Add(h);
            }
            cboHospede.DisplayMember = "Nome";

            // Carregar quartos
            cboQuarto.Items.Clear();
            var quartos = _quartoRepository.ObterTodos();
            foreach (var q in quartos)
            {
                cboQuarto.Items.Add(q);
            }

            // Carregar status
            cboStatus.Items.Clear();
            foreach (string s in Reserva.StatusDisponiveis)
            {
                cboStatus.Items.Add(s);
            }
            cboStatus.SelectedIndex = 0;
        }

        private void PreencherCampos()
        {
            // Selecionar hóspede
            foreach (Hospede h in cboHospede.Items)
            {
                if (h.Id == _reserva.HospedeId)
                {
                    cboHospede.SelectedItem = h;
                    break;
                }
            }

            // Selecionar quarto
            foreach (Quarto q in cboQuarto.Items)
            {
                if (q.Id == _reserva.QuartoId)
                {
                    cboQuarto.SelectedItem = q;
                    break;
                }
            }

            dtpDataEntrada.Value = _reserva.DataEntrada;
            dtpDataSaida.Value = _reserva.DataSaida;
            cboStatus.SelectedItem = _reserva.Status;
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

            if (cboQuarto.SelectedItem == null)
            {
                MessageBox.Show("Selecione um quarto.", "Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboQuarto.Focus();
                return false;
            }

            if (dtpDataSaida.Value.Date <= dtpDataEntrada.Value.Date)
            {
                MessageBox.Show("A data de saída deve ser posterior à data de entrada.", "Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDataSaida.Focus();
                return false;
            }

            if (cboStatus.SelectedItem == null)
            {
                MessageBox.Show("Selecione um status.", "Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboStatus.Focus();
                return false;
            }

            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                Hospede hospedeSelecionado = (Hospede)cboHospede.SelectedItem;
                Quarto quartoSelecionado = (Quarto)cboQuarto.SelectedItem;

                if (_modoEdicao)
                {
                    _reserva.HospedeId = hospedeSelecionado.Id;
                    _reserva.QuartoId = quartoSelecionado.Id;
                    _reserva.DataEntrada = dtpDataEntrada.Value.Date;
                    _reserva.DataSaida = dtpDataSaida.Value.Date;
                    _reserva.Status = cboStatus.SelectedItem.ToString();

                    _reservaRepository.Editar(_reserva);
                    MessageBox.Show("Reserva atualizada com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Reserva novaReserva = new Reserva
                    {
                        HospedeId = hospedeSelecionado.Id,
                        QuartoId = quartoSelecionado.Id,
                        DataEntrada = dtpDataEntrada.Value.Date,
                        DataSaida = dtpDataSaida.Value.Date,
                        Status = cboStatus.SelectedItem.ToString()
                    };

                    _reservaRepository.Inserir(novaReserva);
                    MessageBox.Show("Reserva cadastrada com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar reserva: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
