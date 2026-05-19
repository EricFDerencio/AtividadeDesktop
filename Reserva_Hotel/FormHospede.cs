using Reserva_Hotel.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                var alunos = _hospedeRepository.ObterTodos();
                gridHospedes.DataSource = alunos;
                lblTotalHospedes.Text =
                    $"Total: {alunos.ToList().Count} alunos";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
