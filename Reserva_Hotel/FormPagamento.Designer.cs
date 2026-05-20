namespace Reserva_Hotel
{
    partial class FormPagamento
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
            this.gridPagamentos = new System.Windows.Forms.DataGridView();
            this.cboBuscaStatus = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblFiltroStatus = new System.Windows.Forms.Label();
            this.lstbResumo = new System.Windows.Forms.ListBox();
            this.lblResumo = new System.Windows.Forms.Label();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.lblTotalValor = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPagamentos)).BeginInit();
            this.SuspendLayout();
            //
            // lblFiltroStatus
            //
            this.lblFiltroStatus.AutoSize = true;
            this.lblFiltroStatus.Location = new System.Drawing.Point(12, 23);
            this.lblFiltroStatus.Name = "lblFiltroStatus";
            this.lblFiltroStatus.Size = new System.Drawing.Size(74, 25);
            this.lblFiltroStatus.TabIndex = 0;
            this.lblFiltroStatus.Text = "Status:";
            //
            // cboBuscaStatus
            //
            this.cboBuscaStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscaStatus.Location = new System.Drawing.Point(90, 19);
            this.cboBuscaStatus.Name = "cboBuscaStatus";
            this.cboBuscaStatus.Size = new System.Drawing.Size(180, 33);
            this.cboBuscaStatus.TabIndex = 1;
            //
            // btnBuscar
            //
            this.btnBuscar.Location = new System.Drawing.Point(285, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 44);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Filtrar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            //
            // btnLimpar
            //
            this.btnLimpar.Location = new System.Drawing.Point(415, 13);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(120, 44);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar Filtro";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            //
            // gridPagamentos
            //
            this.gridPagamentos.AllowUserToAddRows = false;
            this.gridPagamentos.AllowUserToDeleteRows = false;
            this.gridPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPagamentos.Location = new System.Drawing.Point(12, 75);
            this.gridPagamentos.MultiSelect = false;
            this.gridPagamentos.Name = "gridPagamentos";
            this.gridPagamentos.ReadOnly = true;
            this.gridPagamentos.RowHeadersWidth = 82;
            this.gridPagamentos.RowTemplate.Height = 33;
            this.gridPagamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPagamentos.Size = new System.Drawing.Size(860, 570);
            this.gridPagamentos.TabIndex = 4;
            //
            // lblResumo
            //
            this.lblResumo.AutoSize = true;
            this.lblResumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblResumo.Location = new System.Drawing.Point(885, 75);
            this.lblResumo.Name = "lblResumo";
            this.lblResumo.Size = new System.Drawing.Size(200, 25);
            this.lblResumo.TabIndex = 5;
            this.lblResumo.Text = "Resumo Financeiro:";
            //
            // lstbResumo
            //
            this.lstbResumo.Font = new System.Drawing.Font("Courier New", 9F);
            this.lstbResumo.FormattingEnabled = true;
            this.lstbResumo.ItemHeight = 21;
            this.lstbResumo.Location = new System.Drawing.Point(885, 105);
            this.lstbResumo.Name = "lstbResumo";
            this.lstbResumo.Size = new System.Drawing.Size(360, 540);
            this.lstbResumo.TabIndex = 6;
            //
            // lblTotalRegistros
            //
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(12, 656);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(72, 25);
            this.lblTotalRegistros.TabIndex = 7;
            this.lblTotalRegistros.Text = "Total: ";
            //
            // lblTotalValor
            //
            this.lblTotalValor.AutoSize = true;
            this.lblTotalValor.Location = new System.Drawing.Point(200, 656);
            this.lblTotalValor.Name = "lblTotalValor";
            this.lblTotalValor.Size = new System.Drawing.Size(72, 25);
            this.lblTotalValor.TabIndex = 8;
            this.lblTotalValor.Text = "Soma: ";
            //
            // btnInserir
            //
            this.btnInserir.Location = new System.Drawing.Point(12, 729);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(133, 55);
            this.btnInserir.TabIndex = 9;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            //
            // btnAlterar
            //
            this.btnAlterar.Location = new System.Drawing.Point(180, 729);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(133, 55);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            //
            // btnDeletar
            //
            this.btnDeletar.Location = new System.Drawing.Point(350, 729);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(133, 55);
            this.btnDeletar.TabIndex = 11;
            this.btnDeletar.Text = "Excluir";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            //
            // btnVoltar
            //
            this.btnVoltar.Location = new System.Drawing.Point(1107, 729);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(133, 55);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            //
            // FormPagamento
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 818);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.lblTotalValor);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.lstbResumo);
            this.Controls.Add(this.lblResumo);
            this.Controls.Add(this.gridPagamentos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cboBuscaStatus);
            this.Controls.Add(this.lblFiltroStatus);
            this.Name = "FormPagamento";
            this.Text = "Gerenciamento de Pagamentos";
            this.Load += new System.EventHandler(this.FormPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPagamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView gridPagamentos;
        private System.Windows.Forms.ComboBox cboBuscaStatus;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblFiltroStatus;
        private System.Windows.Forms.ListBox lstbResumo;
        private System.Windows.Forms.Label lblResumo;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.Label lblTotalValor;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnVoltar;
    }
}
