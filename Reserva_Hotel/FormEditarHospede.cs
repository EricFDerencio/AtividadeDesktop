using Reserva_Hotel.Models;
using Reserva_Hotel.Repositories;
using System;
using System.Windows.Forms;

namespace Reserva_Hotel
{
    public partial class FormEditarHospede : Form
    {
        private Hospede _hospede;
        private HospedeRepository _hospedeRepository;

        public FormEditarHospede(Hospede hospede, HospedeRepository repository)
        {
            InitializeComponent();
            _hospede = hospede;
            _hospedeRepository = repository;
        }

        private void FormEditarHospede_Load(object sender, EventArgs e)
        {
            try
            {
                if (_hospede is null)
                {
                    this.Text = "Cadastrar Hóspede";
                    LimparCampos();
                }
                else
                {
                    this.Text = "Editar Dados do Hóspede";
                    PreencherDados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }

        private void LimparCampos()
        {
            txtBxNome.Clear();
            txtBxSobrenome.Clear();
            txtBxCPF.Clear();
            dtpDataNascimento.Value = DateTime.Now;
            txtBxEmail.Clear();
            txtBxTelefone.Clear();
            txtBxNome.Focus();
        }

        private void PreencherDados()
        {
            txtBxNome.Text = _hospede.Nome;
            txtBxSobrenome.Text = _hospede.Sobrenome;
            txtBxCPF.Text = _hospede.Cpf;
            dtpDataNascimento.Value = _hospede.DataNascimento;
            txtBxEmail.Text = _hospede.Email;
            txtBxTelefone.Text = _hospede.Telefone;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtBxNome.Text))
            {
                MessageBox.Show("Nome é obrigatório");
                txtBxNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBxSobrenome.Text))
            {
                MessageBox.Show("Sobrenome é obrigatório");
                txtBxSobrenome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBxCPF.Text))
            {
                MessageBox.Show("CPF é obrigatório");
                txtBxCPF.Focus();
                return false;
            }

            if (txtBxCPF.Text.Length != 11)
            {
                MessageBox.Show("CPF precisa ser composto por 11 dígitos");
                txtBxCPF.Focus();
                return false;
            }

            if (dtpDataNascimento.Value.AddYears(18) <= DateTime.Now) 
            {
                MessageBox.Show("Não pode ter menos que 18 anos de idade");
                dtpDataNascimento.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBxEmail.Text))
            {
                MessageBox.Show("Email é obrigatório");
                txtBxEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBxTelefone.Text))
            {
                MessageBox.Show("Telefone é obrigatório");
                txtBxTelefone.Focus();
                return false;
            }

            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == false)
            {
                return;
            }

            try
            {
                if (_hospede is null)
                {
                    var novoHospede = new Hospede
                    {
                        Nome = txtBxNome.Text.Trim(),
                        Sobrenome = txtBxSobrenome.Text.Trim(),
                        Cpf = txtBxCPF.Text.Trim(),
                        DataNascimento = dtpDataNascimento.Value,
                        Email = txtBxEmail.Text.Trim(),
                        Telefone = txtBxTelefone.Text.Trim()
                    };

                    _hospedeRepository.Inserir(novoHospede);
                    MessageBox.Show("Cadastrado com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _hospede.Nome = txtBxNome.Text.Trim();
                    _hospede.Sobrenome = txtBxSobrenome.Text.Trim();
                    _hospede.Cpf = txtBxCPF.Text.Trim();
                    _hospede.DataNascimento = dtpDataNascimento.Value;
                    _hospede.Email = txtBxEmail.Text.Trim();
                    _hospede.Telefone = txtBxTelefone.Text.Trim();

                    _hospedeRepository.Editar(_hospede);
                    MessageBox.Show("Atualizado com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar dados: {ex.Message}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
