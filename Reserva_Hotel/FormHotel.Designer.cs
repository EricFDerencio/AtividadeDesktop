namespace Reserva_Hotel {
    partial class FormHotel {
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblNomeHotel = new System.Windows.Forms.Label();
            this.txtNomeHotel = new System.Windows.Forms.TextBox();
            this.txtEnderecoHotel = new System.Windows.Forms.TextBox();
            this.lblEnderecoHotel = new System.Windows.Forms.Label();
            this.txtCidadeHotel = new System.Windows.Forms.TextBox();
            this.lblCidadeHotel = new System.Windows.Forms.Label();
            this.txtTelefoneHotel = new System.Windows.Forms.TextBox();
            this.lblTelefoneHotel = new System.Windows.Forms.Label();
            this.lblEstrelasHotel = new System.Windows.Forms.Label();
            this.cmbBxEstrelasHotel = new System.Windows.Forms.ComboBox();
            this.btnSalvarHotel = new System.Windows.Forms.Button();
            this.btnEditarHotel = new System.Windows.Forms.Button();
            this.btnExcluirHotel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(284, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 212);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblNomeHotel
            // 
            this.lblNomeHotel.AutoSize = true;
            this.lblNomeHotel.Location = new System.Drawing.Point(25, 30);
            this.lblNomeHotel.Name = "lblNomeHotel";
            this.lblNomeHotel.Size = new System.Drawing.Size(61, 13);
            this.lblNomeHotel.TabIndex = 1;
            this.lblNomeHotel.Text = "Nome hotel";
            // 
            // txtNomeHotel
            // 
            this.txtNomeHotel.Location = new System.Drawing.Point(28, 46);
            this.txtNomeHotel.Name = "txtNomeHotel";
            this.txtNomeHotel.Size = new System.Drawing.Size(230, 20);
            this.txtNomeHotel.TabIndex = 2;
            // 
            // txtEnderecoHotel
            // 
            this.txtEnderecoHotel.Location = new System.Drawing.Point(28, 109);
            this.txtEnderecoHotel.Name = "txtEnderecoHotel";
            this.txtEnderecoHotel.Size = new System.Drawing.Size(230, 20);
            this.txtEnderecoHotel.TabIndex = 4;
            // 
            // lblEnderecoHotel
            // 
            this.lblEnderecoHotel.AutoSize = true;
            this.lblEnderecoHotel.Location = new System.Drawing.Point(25, 93);
            this.lblEnderecoHotel.Name = "lblEnderecoHotel";
            this.lblEnderecoHotel.Size = new System.Drawing.Size(53, 13);
            this.lblEnderecoHotel.TabIndex = 3;
            this.lblEnderecoHotel.Text = "Endereço";
            // 
            // txtCidadeHotel
            // 
            this.txtCidadeHotel.Location = new System.Drawing.Point(28, 179);
            this.txtCidadeHotel.Name = "txtCidadeHotel";
            this.txtCidadeHotel.Size = new System.Drawing.Size(230, 20);
            this.txtCidadeHotel.TabIndex = 6;
            // 
            // lblCidadeHotel
            // 
            this.lblCidadeHotel.AutoSize = true;
            this.lblCidadeHotel.Location = new System.Drawing.Point(25, 163);
            this.lblCidadeHotel.Name = "lblCidadeHotel";
            this.lblCidadeHotel.Size = new System.Drawing.Size(40, 13);
            this.lblCidadeHotel.TabIndex = 5;
            this.lblCidadeHotel.Text = "Cidade";
            // 
            // txtTelefoneHotel
            // 
            this.txtTelefoneHotel.Location = new System.Drawing.Point(28, 248);
            this.txtTelefoneHotel.Name = "txtTelefoneHotel";
            this.txtTelefoneHotel.Size = new System.Drawing.Size(230, 20);
            this.txtTelefoneHotel.TabIndex = 8;
            // 
            // lblTelefoneHotel
            // 
            this.lblTelefoneHotel.AutoSize = true;
            this.lblTelefoneHotel.Location = new System.Drawing.Point(25, 232);
            this.lblTelefoneHotel.Name = "lblTelefoneHotel";
            this.lblTelefoneHotel.Size = new System.Drawing.Size(49, 13);
            this.lblTelefoneHotel.TabIndex = 7;
            this.lblTelefoneHotel.Text = "Telefone";
            // 
            // lblEstrelasHotel
            // 
            this.lblEstrelasHotel.AutoSize = true;
            this.lblEstrelasHotel.Location = new System.Drawing.Point(25, 303);
            this.lblEstrelasHotel.Name = "lblEstrelasHotel";
            this.lblEstrelasHotel.Size = new System.Drawing.Size(44, 13);
            this.lblEstrelasHotel.TabIndex = 9;
            this.lblEstrelasHotel.Text = "Estrelas";
            // 
            // cmbBxEstrelasHotel
            // 
            this.cmbBxEstrelasHotel.DisplayMember = "5";
            this.cmbBxEstrelasHotel.FormattingEnabled = true;
            this.cmbBxEstrelasHotel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbBxEstrelasHotel.Location = new System.Drawing.Point(28, 319);
            this.cmbBxEstrelasHotel.Name = "cmbBxEstrelasHotel";
            this.cmbBxEstrelasHotel.Size = new System.Drawing.Size(121, 21);
            this.cmbBxEstrelasHotel.TabIndex = 10;
            // 
            // btnSalvarHotel
            // 
            this.btnSalvarHotel.Location = new System.Drawing.Point(28, 392);
            this.btnSalvarHotel.Name = "btnSalvarHotel";
            this.btnSalvarHotel.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarHotel.TabIndex = 11;
            this.btnSalvarHotel.Text = "Salvar";
            this.btnSalvarHotel.UseVisualStyleBackColor = true;
            this.btnSalvarHotel.Click += new System.EventHandler(this.btnSalvarHotel_Click);
            // 
            // btnEditarHotel
            // 
            this.btnEditarHotel.Location = new System.Drawing.Point(126, 392);
            this.btnEditarHotel.Name = "btnEditarHotel";
            this.btnEditarHotel.Size = new System.Drawing.Size(75, 23);
            this.btnEditarHotel.TabIndex = 12;
            this.btnEditarHotel.Text = "Editar";
            this.btnEditarHotel.UseVisualStyleBackColor = true;
            this.btnEditarHotel.Click += new System.EventHandler(this.btnEditarHotel_Click);
            // 
            // btnExcluirHotel
            // 
            this.btnExcluirHotel.Location = new System.Drawing.Point(227, 392);
            this.btnExcluirHotel.Name = "btnExcluirHotel";
            this.btnExcluirHotel.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirHotel.TabIndex = 13;
            this.btnExcluirHotel.Text = "Excluir";
            this.btnExcluirHotel.UseVisualStyleBackColor = true;
            this.btnExcluirHotel.Click += new System.EventHandler(this.btnExcluirHotel_Click);
            // 
            // FormHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExcluirHotel);
            this.Controls.Add(this.btnEditarHotel);
            this.Controls.Add(this.btnSalvarHotel);
            this.Controls.Add(this.cmbBxEstrelasHotel);
            this.Controls.Add(this.lblEstrelasHotel);
            this.Controls.Add(this.txtTelefoneHotel);
            this.Controls.Add(this.lblTelefoneHotel);
            this.Controls.Add(this.txtCidadeHotel);
            this.Controls.Add(this.lblCidadeHotel);
            this.Controls.Add(this.txtEnderecoHotel);
            this.Controls.Add(this.lblEnderecoHotel);
            this.Controls.Add(this.txtNomeHotel);
            this.Controls.Add(this.lblNomeHotel);
            this.Controls.Add(this.listBox1);
            this.Name = "FormHotel";
            this.Text = "Hotel";
            this.Load += new System.EventHandler(this.FormHotel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblNomeHotel;
        private System.Windows.Forms.TextBox txtNomeHotel;
        private System.Windows.Forms.TextBox txtEnderecoHotel;
        private System.Windows.Forms.Label lblEnderecoHotel;
        private System.Windows.Forms.TextBox txtCidadeHotel;
        private System.Windows.Forms.Label lblCidadeHotel;
        private System.Windows.Forms.TextBox txtTelefoneHotel;
        private System.Windows.Forms.Label lblTelefoneHotel;
        private System.Windows.Forms.Label lblEstrelasHotel;
        private System.Windows.Forms.ComboBox cmbBxEstrelasHotel;
        private System.Windows.Forms.Button btnSalvarHotel;
        private System.Windows.Forms.Button btnEditarHotel;
        private System.Windows.Forms.Button btnExcluirHotel;
    }
}