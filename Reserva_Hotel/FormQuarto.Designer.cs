namespace Reserva_Hotel
{
    partial class FormQuarto
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lstBxQuartos = new System.Windows.Forms.ListBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cmbBxStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbBxTipo = new System.Windows.Forms.ComboBox();
            this.txtBxPreco = new System.Windows.Forms.TextBox();
            this.txtBxNumero = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblHotel = new System.Windows.Forms.Label();
            this.cmbBxHotel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(719, 393);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(121, 40);
            this.btnExcluir.TabIndex = 29;
            this.btnExcluir.Text = "Excluir Quarto";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(537, 393);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(121, 40);
            this.btnEditar.TabIndex = 28;
            this.btnEditar.Text = "Editar Quarto";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lstBxQuartos
            // 
            this.lstBxQuartos.FormattingEnabled = true;
            this.lstBxQuartos.ItemHeight = 16;
            this.lstBxQuartos.Location = new System.Drawing.Point(363, 52);
            this.lstBxQuartos.Name = "lstBxQuartos";
            this.lstBxQuartos.Size = new System.Drawing.Size(550, 260);
            this.lstBxQuartos.TabIndex = 27;
            this.lstBxQuartos.SelectedIndexChanged += new System.EventHandler(this.lstBxQuartos_SelectedIndexChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(367, 393);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(121, 40);
            this.btnSalvar.TabIndex = 26;
            this.btnSalvar.Text = "Salvar Quarto";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cmbBxStatus
            // 
            this.cmbBxStatus.FormattingEnabled = true;
            this.cmbBxStatus.Items.AddRange(new object[] {
            "Disponível",
            "Ocupado",
            "Manutenção"});
            this.cmbBxStatus.Location = new System.Drawing.Point(25, 413);
            this.cmbBxStatus.Name = "cmbBxStatus";
            this.cmbBxStatus.Size = new System.Drawing.Size(121, 24);
            this.cmbBxStatus.TabIndex = 25;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(22, 384);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "Status";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(22, 307);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(97, 16);
            this.lblTipo.TabIndex = 23;
            this.lblTipo.Text = "Tipo de Quarto";
            // 
            // cmbBxTipo
            // 
            this.cmbBxTipo.FormattingEnabled = true;
            this.cmbBxTipo.Items.AddRange(new object[] {
            "Luxo",
            "Suíte",
            "Standard"});
            this.cmbBxTipo.Location = new System.Drawing.Point(25, 335);
            this.cmbBxTipo.Name = "cmbBxTipo";
            this.cmbBxTipo.Size = new System.Drawing.Size(121, 24);
            this.cmbBxTipo.TabIndex = 22;
            // 
            // txtBxPreco
            // 
            this.txtBxPreco.Location = new System.Drawing.Point(25, 253);
            this.txtBxPreco.Name = "txtBxPreco";
            this.txtBxPreco.Size = new System.Drawing.Size(128, 22);
            this.txtBxPreco.TabIndex = 21;
            // 
            // txtBxNumero
            // 
            this.txtBxNumero.Location = new System.Drawing.Point(25, 165);
            this.txtBxNumero.Name = "txtBxNumero";
            this.txtBxNumero.Size = new System.Drawing.Size(128, 22);
            this.txtBxNumero.TabIndex = 20;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(22, 222);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(43, 16);
            this.lblPreco.TabIndex = 19;
            this.lblPreco.Text = "Preço";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(22, 129);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(117, 16);
            this.lblNumero.TabIndex = 18;
            this.lblNumero.Text = "Numero do Quarto";
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Location = new System.Drawing.Point(22, 43);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(39, 16);
            this.lblHotel.TabIndex = 30;
            this.lblHotel.Text = "Hotel";
            // 
            // cmbBxHotel
            // 
            this.cmbBxHotel.FormattingEnabled = true;
            this.cmbBxHotel.Items.AddRange(new object[] {
            "Luxo",
            "Suíte",
            "Standard"});
            this.cmbBxHotel.Location = new System.Drawing.Point(25, 75);
            this.cmbBxHotel.Name = "cmbBxHotel";
            this.cmbBxHotel.Size = new System.Drawing.Size(121, 24);
            this.cmbBxHotel.TabIndex = 31;
            // 
            // FormQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 737);
            this.Controls.Add(this.cmbBxHotel);
            this.Controls.Add(this.lblHotel);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lstBxQuartos);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cmbBxStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbBxTipo);
            this.Controls.Add(this.txtBxPreco);
            this.Controls.Add(this.txtBxNumero);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblNumero);
            this.Name = "FormQuarto";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormQuarto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ListBox lstBxQuartos;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cmbBxStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbBxTipo;
        private System.Windows.Forms.TextBox txtBxPreco;
        private System.Windows.Forms.TextBox txtBxNumero;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.ComboBox cmbBxHotel;
    }
}

