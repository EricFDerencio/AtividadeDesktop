namespace Reserva_Hotel
{
    partial class FormEditarReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblHospede = new System.Windows.Forms.Label();
            this.cboHospede = new System.Windows.Forms.ComboBox();
            this.lblQuarto = new System.Windows.Forms.Label();
            this.cboQuarto = new System.Windows.Forms.ComboBox();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.dtpDataSaida = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(200, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nova Reserva";
            //
            // lblHospede
            //
            this.lblHospede.AutoSize = true;
            this.lblHospede.Location = new System.Drawing.Point(20, 80);
            this.lblHospede.Name = "lblHospede";
            this.lblHospede.Size = new System.Drawing.Size(95, 25);
            this.lblHospede.TabIndex = 1;
            this.lblHospede.Text = "Hóspede:";
            //
            // cboHospede
            //
            this.cboHospede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHospede.Location = new System.Drawing.Point(160, 76);
            this.cboHospede.Name = "cboHospede";
            this.cboHospede.Size = new System.Drawing.Size(350, 33);
            this.cboHospede.TabIndex = 2;
            //
            // lblQuarto
            //
            this.lblQuarto.AutoSize = true;
            this.lblQuarto.Location = new System.Drawing.Point(20, 130);
            this.lblQuarto.Name = "lblQuarto";
            this.lblQuarto.Size = new System.Drawing.Size(77, 25);
            this.lblQuarto.TabIndex = 3;
            this.lblQuarto.Text = "Quarto:";
            //
            // cboQuarto
            //
            this.cboQuarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuarto.Location = new System.Drawing.Point(160, 126);
            this.cboQuarto.Name = "cboQuarto";
            this.cboQuarto.Size = new System.Drawing.Size(350, 33);
            this.cboQuarto.TabIndex = 4;
            //
            // lblDataEntrada
            //
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Location = new System.Drawing.Point(20, 180);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(130, 25);
            this.lblDataEntrada.TabIndex = 5;
            this.lblDataEntrada.Text = "Data Entrada:";
            //
            // dtpDataEntrada
            //
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(160, 176);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(200, 31);
            this.dtpDataEntrada.TabIndex = 6;
            //
            // lblDataSaida
            //
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Location = new System.Drawing.Point(20, 230);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(113, 25);
            this.lblDataSaida.TabIndex = 7;
            this.lblDataSaida.Text = "Data Saída:";
            //
            // dtpDataSaida
            //
            this.dtpDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataSaida.Location = new System.Drawing.Point(160, 226);
            this.dtpDataSaida.Name = "dtpDataSaida";
            this.dtpDataSaida.Size = new System.Drawing.Size(200, 31);
            this.dtpDataSaida.TabIndex = 8;
            //
            // lblStatus
            //
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 280);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(74, 25);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status:";
            //
            // cboStatus
            //
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Location = new System.Drawing.Point(160, 276);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(200, 33);
            this.cboStatus.TabIndex = 10;
            //
            // btnSalvar
            //
            this.btnSalvar.Location = new System.Drawing.Point(160, 340);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(133, 50);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            //
            // btnCancelar
            //
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(310, 340);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 50);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            //
            // FormEditarReserva
            //
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(540, 420);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dtpDataSaida);
            this.Controls.Add(this.lblDataSaida);
            this.Controls.Add(this.dtpDataEntrada);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.cboQuarto);
            this.Controls.Add(this.lblQuarto);
            this.Controls.Add(this.cboHospede);
            this.Controls.Add(this.lblHospede);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nova Reserva";
            this.Load += new System.EventHandler(this.FormEditarReserva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblHospede;
        private System.Windows.Forms.ComboBox cboHospede;
        private System.Windows.Forms.Label lblQuarto;
        private System.Windows.Forms.ComboBox cboQuarto;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.DateTimePicker dtpDataSaida;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
