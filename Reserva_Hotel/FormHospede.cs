using Reserva_Hotel.Repositories;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Reserva_Hotel
{
    public partial class FormHospede : Form
    {
        private HospedeRepository _hospedeRepository;

        public FormHospede()
        {
            InitializeComponent();
            _hospedeRepository = new HospedeRepository();
        }

        private void FormHospede_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar grid: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarGrid()
        {
            try
            {
                var hospedes = _hospedeRepository.ObterTodos();
                gridHospedes.DataSource = hospedes;
                lblTotalHospedes.Text =
                    $"Total: {hospedes.ToList().Count} cadastros";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                FormEditarHospede formNovoCadastro = new FormEditarHospede(null, _hospedeRepository);

                if (formNovoCadastro.ShowDialog() == DialogResult.OK)
                {
                    CarregarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir cadastro: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridHospedes.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Seleciona um hospede para editar seus dados");
                    return;
                }

                int id = (int)gridHospedes.SelectedRows[0].Cells["id"].Value;
                var hospede = _hospedeRepository.ObterUm(id);

                if (hospede != null)
                {
                    FormEditarHospede formEditarHospede = new FormEditarHospede(hospede, _hospedeRepository);
                    
                    if (formEditarHospede.ShowDialog() == DialogResult.OK)
                    {
                        CarregarGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar cadastro: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridHospedes.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Seleciona um hospede para apagar seus dados");
                    return;
                }

                int id = (int)gridHospedes.SelectedRows[0].Cells["Id"].Value;
                string nome = gridHospedes.SelectedRows[0].Cells["Nome"].Value.ToString() + 
                    " " + 
                    gridHospedes.SelectedRows[0].Cells["Sobrenome"].Value.ToString();

                DialogResult resultado = MessageBox.Show(
                    $"Deseja mesmo deletar '{nome}' e seus dados?",
                    "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    _hospedeRepository.Deletar(id);
                    MessageBox.Show("Deletado com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    CarregarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao deletar cadastro: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBxBuscaNome.Text) && 
                string.IsNullOrWhiteSpace(txtBxBuscaSobrenome.Text))
                CarregarGrid();
            else
            {
                var hospedes = _hospedeRepository.ObterPorNome(txtBxBuscaNome.Text, txtBxBuscaSobrenome.Text).ToList();
                gridHospedes.DataSource = hospedes;
                lblTotalHospedes.Text = $"Total: {hospedes.Count} cadastros";
            }
        }
    }
}
