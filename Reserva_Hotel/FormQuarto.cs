using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reserva_Hotel.Properties;


namespace Reserva_Hotel
{
    public partial class FormQuarto : Form
    {
        private readonly QuartoRepository _quartoRepository = new QuartoRepository();
        private int idQuartoSelecionado = 0;
        public FormQuarto()
        {
            InitializeComponent();
        }

        private void FormQuarto_Load(object sender, EventArgs e)
        {
            AtualizarListBox();
        }

        private void AtualizarListBox()
        {
            try
            {
                lstBxQuartos.Items.Clear();

                var todosOsQuartos = _quartoRepository.ObterTodos();

                foreach (var quartos in todosOsQuartos)
                {
                    lstBxQuartos.Items.Add(quartos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível carregar a listagem de quartos: {ex.Message}", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                {
                    return;
                }

                Quarto novoQuarto = new Quarto
                {
                    Numero = int.Parse(txtBxNumero.Text.Trim()),
                    Tipo = cmbBxTipo.SelectedItem.ToString(),
                    PrecoDiaria = decimal.Parse(txtBxPreco.Text.Trim()),
                    Status = cmbBxStatus.SelectedItem.ToString(),
                    HotelId = 1
                };


                _quartoRepository.Inserir(novoQuarto);

                MessageBox.Show("Quarto cadastrado com sucesso no banco de dados!",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
                AtualizarListBox();
            }
            catch (FormatException)
            {

                MessageBox.Show("Os campos 'Número', 'Preço' e 'ID do Hotel' aceitam apenas valores numéricos.",
                    "Falha no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado no banco de dados: {ex.Message}",
                    "Erro do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtBxNumero.Text))
            {
                MessageBox.Show("'Número do Quarto' é obrigatório.",
                    "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBxNumero.Focus();
                return false;
            }

            if (cmbBxTipo.SelectedItem == null)
            {
                MessageBox.Show("Selecione um Valor no ComboBox",
                    "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbBxTipo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBxPreco.Text))
            {
                MessageBox.Show("'Preço da Diária' é obrigatório.",
                    "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBxPreco.Focus();
                return false;
            }

            if (cmbBxStatus.SelectedItem == null)
            {
                MessageBox.Show("Selecione o Status atual do quarto.",
                    "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbBxStatus.Focus();
                return false;
            }

            return true;
        }

        private void LimparCampos()
        {
            txtBxNumero.Clear();
            txtBxPreco.Clear();
            cmbBxTipo.SelectedIndex = -1;
            cmbBxStatus.SelectedIndex = -1;
            txtBxNumero.Focus();
        }



        private void lstBxQuartos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBxQuartos.SelectedItem is Quarto quartoSelecionado)
            {
                idQuartoSelecionado = quartoSelecionado.Id;
                txtBxNumero.Text = quartoSelecionado.Numero.ToString();
                txtBxPreco.Text = quartoSelecionado.PrecoDiaria.ToString();
                cmbBxTipo.SelectedItem = quartoSelecionado.Tipo;
                cmbBxStatus.SelectedItem = quartoSelecionado.Status;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idQuartoSelecionado == 0)
                {
                    MessageBox.Show("Selecione um quarto na lista antes de editar!",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidarCampos())
                {
                    return;
                }

                Quarto quartoEditado = new Quarto
                {
                    Id = idQuartoSelecionado,
                    Numero = int.Parse(txtBxNumero.Text.Trim()),
                    Tipo = cmbBxTipo.SelectedItem.ToString(),
                    PrecoDiaria = decimal.Parse(txtBxPreco.Text.Trim()),
                    Status = cmbBxStatus.SelectedItem.ToString(),
                    HotelId = 1
                };

                _quartoRepository.Editar(quartoEditado);
                MessageBox.Show("Quarto atualizado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                idQuartoSelecionado = 0;
                LimparCampos();
                AtualizarListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (idQuartoSelecionado == 0)
                {
                    MessageBox.Show("Selecione um quarto na lista antes de excluir!",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir este quarto?",
                    "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    _quartoRepository.Deletar(idQuartoSelecionado);
                    MessageBox.Show("Quarto removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    idQuartoSelecionado = 0; // Reseta o ID
                    LimparCampos();
                    AtualizarListBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
