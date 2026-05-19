using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva_Hotel.Models {
    public class Hotel {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }

        public string Cidade { get; set; }

        public string Telefone { get; set; }

        public int Estrelas { get; set; }

        public override string ToString() {
            return Nome + " - " + Cidade;
        }
    }
}
