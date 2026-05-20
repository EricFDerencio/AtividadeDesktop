namespace Reserva_Hotel {
    partial class FormInicial {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnQuartos = new System.Windows.Forms.Button();
            this.btnHoteis = new System.Windows.Forms.Button();
            this.btnHospedes = new System.Windows.Forms.Button();
            this.btnPagamentos = new System.Windows.Forms.Button();
            this.lblNomeProjeto = new System.Windows.Forms.Label();
            this.btnReserva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuartos
            // 
            this.btnQuartos.Location = new System.Drawing.Point(302, 299);
            this.btnQuartos.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuartos.Name = "btnQuartos";
            this.btnQuartos.Size = new System.Drawing.Size(133, 39);
            this.btnQuartos.TabIndex = 0;
            this.btnQuartos.Text = "Quartos";
            this.btnQuartos.UseVisualStyleBackColor = true;
            this.btnQuartos.Click += new System.EventHandler(this.btnQuartos_Click);
            // 
            // btnHoteis
            // 
            this.btnHoteis.Location = new System.Drawing.Point(161, 299);
            this.btnHoteis.Margin = new System.Windows.Forms.Padding(4);
            this.btnHoteis.Name = "btnHoteis";
            this.btnHoteis.Size = new System.Drawing.Size(133, 39);
            this.btnHoteis.TabIndex = 1;
            this.btnHoteis.Text = "Hoteis";
            this.btnHoteis.UseVisualStyleBackColor = true;
            this.btnHoteis.Click += new System.EventHandler(this.btnHoteis_Click);
            // 
            // btnHospedes
            // 
            this.btnHospedes.Location = new System.Drawing.Point(584, 299);
            this.btnHospedes.Margin = new System.Windows.Forms.Padding(4);
            this.btnHospedes.Name = "btnHospedes";
            this.btnHospedes.Size = new System.Drawing.Size(133, 39);
            this.btnHospedes.TabIndex = 2;
            this.btnHospedes.Text = "Hóspedes";
            this.btnHospedes.UseVisualStyleBackColor = true;
            this.btnHospedes.Click += new System.EventHandler(this.btnHospedes_Click);
            // 
            // btnPagamentos
            // 
            this.btnPagamentos.Location = new System.Drawing.Point(725, 299);
            this.btnPagamentos.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagamentos.Name = "btnPagamentos";
            this.btnPagamentos.Size = new System.Drawing.Size(133, 39);
            this.btnPagamentos.TabIndex = 3;
            this.btnPagamentos.Text = "Pagamentos";
            this.btnPagamentos.UseVisualStyleBackColor = true;
            this.btnPagamentos.Click += new System.EventHandler(this.btnPagamentos_Click);
            // 
            // lblNomeProjeto
            // 
            this.lblNomeProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProjeto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNomeProjeto.Location = new System.Drawing.Point(362, 102);
            this.lblNomeProjeto.Name = "lblNomeProjeto";
            this.lblNomeProjeto.Size = new System.Drawing.Size(280, 144);
            this.lblNomeProjeto.TabIndex = 4;
            this.lblNomeProjeto.Text = "Key-In";
            this.lblNomeProjeto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReserva
            // 
            this.btnReserva.Location = new System.Drawing.Point(443, 299);
            this.btnReserva.Margin = new System.Windows.Forms.Padding(4);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(133, 39);
            this.btnReserva.TabIndex = 5;
            this.btnReserva.Text = "Reserva";
            this.btnReserva.UseVisualStyleBackColor = true;
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnReserva);
            this.Controls.Add(this.lblNomeProjeto);
            this.Controls.Add(this.btnPagamentos);
            this.Controls.Add(this.btnHospedes);
            this.Controls.Add(this.btnHoteis);
            this.Controls.Add(this.btnQuartos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInicial";
            this.Text = "FormInicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuartos;
        private System.Windows.Forms.Button btnHoteis;
        private System.Windows.Forms.Button btnHospedes;
        private System.Windows.Forms.Button btnPagamentos;
        private System.Windows.Forms.Label lblNomeProjeto;
        private System.Windows.Forms.Button btnReserva;
    }
}