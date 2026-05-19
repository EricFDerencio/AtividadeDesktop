using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
