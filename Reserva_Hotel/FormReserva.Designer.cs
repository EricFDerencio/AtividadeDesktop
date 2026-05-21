namespace Reserva_Hotel
{
    partial class FormReserva
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
            this.gridReservas = new System.Windows.Forms.DataGridView();
            this.cboBuscaStatus = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblFiltroStatus = new System.Windows.Forms.Label();
            this.lblTotalReservas = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridReservas)).BeginInit();
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
            // gridReservas
            //
            this.gridReservas.AllowUserToAddRows = false;
            this.gridReservas.AllowUserToDeleteRows = false;
            this.gridReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReservas.Location = new System.Drawing.Point(12, 75);
            this.gridReservas.MultiSelect = false;
            this.gridReservas.Name = "gridReservas";
            this.gridReservas.ReadOnly = true;
            this.gridReservas.RowHeadersWidth = 82;
            this.gridReservas.RowTemplate.Height = 33;
            this.gridReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridReservas.Size = new System.Drawing.Size(1240, 570);
            this.gridReservas.TabIndex = 4;
            //
            // lblTotalReservas
            //
            this.lblTotalReservas.AutoSize = true;
            this.lblTotalReservas.Location = new System.Drawing.Point(12, 656);
            this.lblTotalReservas.Name = "lblTotalReservas";
            this.lblTotalReservas.Size = new System.Drawing.Size(72, 25);
            this.lblTotalReservas.TabIndex = 5;
            this.lblTotalReservas.Text = "Total: 0 reservas";
            //
            // btnInserir
            //
            this.btnInserir.Location = new System.Drawing.Point(12, 729);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(133, 55);
            this.btnInserir.TabIndex = 6;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            //
            // btnAlterar
            //
            this.btnAlterar.Location = new System.Drawing.Point(180, 729);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(133, 55);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            //
            // btnDeletar
            //
            this.btnDeletar.Location = new System.Drawing.Point(350, 729);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(133, 55);
            this.btnDeletar.TabIndex = 8;
            this.btnDeletar.Text = "Excluir";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            //
            // btnVoltar
            //
            this.btnVoltar.Location = new System.Drawing.Point(1107, 729);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(133, 55);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            //
            // FormReserva
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 818);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.lblTotalReservas);
            this.Controls.Add(this.gridReservas);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cboBuscaStatus);
            this.Controls.Add(this.lblFiltroStatus);
            this.MaximizeBox = false;
            this.Name = "FormReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gerenciamento de Reservas";
            this.Load += new System.EventHandler(this.FormReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView gridReservas;
        private System.Windows.Forms.ComboBox cboBuscaStatus;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblFiltroStatus;
        private System.Windows.Forms.Label lblTotalReservas;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnVoltar;
    }
}