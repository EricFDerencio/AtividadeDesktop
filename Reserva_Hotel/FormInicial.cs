using System;
using System.Windows.Forms;

namespace Reserva_Hotel {
    public partial class FormInicial : Form {
        public FormInicial() {
            InitializeComponent();
        }

        private void btnQuartos_Click(object sender, EventArgs e) {
            FormQuarto formQuarto = new FormQuarto();
            formQuarto.ShowDialog();
        }

        private void btnHoteis_Click(object sender, EventArgs e) {
            FormHotel formHotel = new FormHotel();
            formHotel.ShowDialog();
        }

        private void btnHospedes_Click(object sender, EventArgs e)
        {
            FormHospede formHospede = new FormHospede();
            formHospede.ShowDialog();
        }
    }
}
