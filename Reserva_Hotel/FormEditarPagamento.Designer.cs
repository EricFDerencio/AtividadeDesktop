namespace Reserva_Hotel
{
    partial class FormEditarPagamento
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
            this.lblHospede = new System.Windows.Forms.Label();
            this.cboHospede = new System.Windows.Forms.ComboBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtBxValorTotal = new System.Windows.Forms.TextBox();
            this.lblDataPagamento = new System.Windows.Forms.Label();
            this.dtpDataPagamento = new System.Windows.Forms.DateTimePicker();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.cboFormaPagamento = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblReservaId = new System.Windows.Forms.Label();
            this.txtBxReservaId = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtBxObservacao = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblHospede
            //
            this.lblHospede.AutoSize = true;
            this.lblHospede.Location = new System.Drawing.Point(9, 29);
            this.lblHospede.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHospede.Name = "lblHospede";
            this.lblHospede.Size = new System.Drawing.Size(100, 25);
            this.lblHospede.TabIndex = 0;
            this.lblHospede.Text = "Hóspede:";
            //
            // cboHospede
            //
            this.cboHospede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHospede.Location = new System.Drawing.Point(15, 59);
            this.cboHospede.Margin = new System.Windows.Forms.Padding(6);
            this.cboHospede.Name = "cboHospede";
            this.cboHospede.Size = new System.Drawing.Size(522, 33);
            this.cboHospede.TabIndex = 1;
            //
            // lblValorTotal
            //
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(9, 110);
            this.lblValorTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(160, 25);
            this.lblValorTotal.TabIndex = 2;
            this.lblValorTotal.Text = "Valor Total (R$):";
            //
            // txtBxValorTotal
            //
            this.txtBxValorTotal.Location = new System.Drawing.Point(15, 140);
            this.txtBxValorTotal.Margin = new System.Windows.Forms.Padding(6);
            this.txtBxValorTotal.Name = "txtBxValorTotal";
            this.txtBxValorTotal.Size = new System.Drawing.Size(522, 31);
            this.txtBxValorTotal.TabIndex = 3;
            //
            // lblDataPagamento
            //
            this.lblDataPagamento.AutoSize = true;
            this.lblDataPagamento.Location = new System.Drawing.Point(9, 188);
            this.lblDataPagamento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDataPagamento.Name = "lblDataPagamento";
            this.lblDataPagamento.Size = new System.Drawing.Size(210, 25);
            this.lblDataPagamento.TabIndex = 4;
            this.lblDataPagamento.Text = "Data do Pagamento:";
            //
            // dtpDataPagamento
            //
            this.dtpDataPagamento.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDataPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataPagamento.Location = new System.Drawing.Point(15, 218);
            this.dtpDataPagamento.Margin = new System.Windows.Forms.Padding(6);
            this.dtpDataPagamento.Name = "dtpDataPagamento";
            this.dtpDataPagamento.Size = new System.Drawing.Size(522, 31);
            this.dtpDataPagamento.TabIndex = 5;
            //
            // lblFormaPagamento
            //
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.Location = new System.Drawing.Point(9, 266);
            this.lblFormaPagamento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(220, 25);
            this.lblFormaPagamento.TabIndex = 6;
            this.lblFormaPagamento.Text = "Forma de Pagamento:";
            //
            // cboFormaPagamento
            //
            this.cboFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormaPagamento.Location = new System.Drawing.Point(15, 296);
            this.cboFormaPagamento.Margin = new System.Windows.Forms.Padding(6);
            this.cboFormaPagamento.Name = "cboFormaPagamento";
            this.cboFormaPagamento.Size = new System.Drawing.Size(522, 33);
            this.cboFormaPagamento.TabIndex = 7;
            //
            // lblStatus
            //
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(9, 346);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(80, 25);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status:";
            //
            // cboStatus
            //
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Location = new System.Drawing.Point(15, 376);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(6);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(522, 33);
            this.cboStatus.TabIndex = 9;
            //
            // lblReservaId
            //
            this.lblReservaId.AutoSize = true;
            this.lblReservaId.Location = new System.Drawing.Point(9, 426);
            this.lblReservaId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblReservaId.Name = "lblReservaId";
            this.lblReservaId.Size = new System.Drawing.Size(370, 25);
            this.lblReservaId.TabIndex = 10;
            this.lblReservaId.Text = "ID da Reserva (opcional — integrar com Eric):";
            //
            // txtBxReservaId
            //
            this.txtBxReservaId.Location = new System.Drawing.Point(15, 456);
            this.txtBxReservaId.Margin = new System.Windows.Forms.Padding(6);
            this.txtBxReservaId.Name = "txtBxReservaId";
            this.txtBxReservaId.Size = new System.Drawing.Size(522, 31);
            this.txtBxReservaId.TabIndex = 11;
            //
            // lblObservacao
            //
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(9, 504);
            this.lblObservacao.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(130, 25);
            this.lblObservacao.TabIndex = 12;
            this.lblObservacao.Text = "Observação:";
            //
            // txtBxObservacao
            //
            this.txtBxObservacao.Location = new System.Drawing.Point(15, 534);
            this.txtBxObservacao.Margin = new System.Windows.Forms.Padding(6);
            this.txtBxObservacao.Multiline = true;
            this.txtBxObservacao.Name = "txtBxObservacao";
            this.txtBxObservacao.Size = new System.Drawing.Size(522, 70);
            this.txtBxObservacao.TabIndex = 13;
            //
            // btnSalvar
            //
            this.btnSalvar.Location = new System.Drawing.Point(89, 635);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(137, 59);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            //
            // btnCancelar
            //
            this.btnCancelar.Location = new System.Drawing.Point(335, 635);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 59);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            //
            // FormEditarPagamento
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 720);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtBxObservacao);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.txtBxReservaId);
            this.Controls.Add(this.lblReservaId);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cboFormaPagamento);
            this.Controls.Add(this.lblFormaPagamento);
            this.Controls.Add(this.dtpDataPagamento);
            this.Controls.Add(this.lblDataPagamento);
            this.Controls.Add(this.txtBxValorTotal);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.cboHospede);
            this.Controls.Add(this.lblHospede);
            this.Name = "FormEditarPagamento";
            this.Text = "Pagamento";
            this.Load += new System.EventHandler(this.FormEditarPagamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHospede;
        private System.Windows.Forms.ComboBox cboHospede;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txtBxValorTotal;
        private System.Windows.Forms.Label lblDataPagamento;
        private System.Windows.Forms.DateTimePicker dtpDataPagamento;
        private System.Windows.Forms.Label lblFormaPagamento;
        private System.Windows.Forms.ComboBox cboFormaPagamento;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblReservaId;
        private System.Windows.Forms.TextBox txtBxReservaId;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtBxObservacao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
