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
            this.SuspendLayout();
            // 
            // btnQuartos
            // 
            this.btnQuartos.Location = new System.Drawing.Point(56, 60);
            this.btnQuartos.Name = "btnQuartos";
            this.btnQuartos.Size = new System.Drawing.Size(75, 23);
            this.btnQuartos.TabIndex = 0;
            this.btnQuartos.Text = "Quartos";
            this.btnQuartos.UseVisualStyleBackColor = true;
            this.btnQuartos.Click += new System.EventHandler(this.btnQuartos_Click);
            // 
            // btnHoteis
            // 
            this.btnHoteis.Location = new System.Drawing.Point(56, 106);
            this.btnHoteis.Name = "btnHoteis";
            this.btnHoteis.Size = new System.Drawing.Size(75, 23);
            this.btnHoteis.TabIndex = 1;
            this.btnHoteis.Text = "Hoteis";
            this.btnHoteis.UseVisualStyleBackColor = true;
            this.btnHoteis.Click += new System.EventHandler(this.btnHoteis_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHoteis);
            this.Controls.Add(this.btnQuartos);
            this.Name = "FormInicial";
            this.Text = "FormInicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuartos;
        private System.Windows.Forms.Button btnHoteis;
    }
}