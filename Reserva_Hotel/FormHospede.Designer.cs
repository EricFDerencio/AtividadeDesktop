namespace Reserva_Hotel
{
    partial class FormHospede
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
            this.btnInserir = new System.Windows.Forms.Button();
            this.gridHospedes = new System.Windows.Forms.DataGridView();
            this.txtBxBuscaNome = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtBxBuscaSobrenome = new System.Windows.Forms.TextBox();
            this.lblBuscaNome = new System.Windows.Forms.Label();
            this.lblBuscaSobrenome = new System.Windows.Forms.Label();
            this.lblTotalHospedes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridHospedes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(12, 729);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(133, 55);
            this.btnInserir.TabIndex = 3;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // gridHospedes
            // 
            this.gridHospedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHospedes.Location = new System.Drawing.Point(12, 79);
            this.gridHospedes.Name = "gridHospedes";
            this.gridHospedes.RowHeadersWidth = 82;
            this.gridHospedes.RowTemplate.Height = 33;
            this.gridHospedes.Size = new System.Drawing.Size(1228, 587);
            this.gridHospedes.TabIndex = 5;
            // 
            // txtBxBuscaNome
            // 
            this.txtBxBuscaNome.Location = new System.Drawing.Point(92, 20);
            this.txtBxBuscaNome.Name = "txtBxBuscaNome";
            this.txtBxBuscaNome.Size = new System.Drawing.Size(400, 31);
            this.txtBxBuscaNome.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1098, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(125, 44);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(180, 729);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(133, 55);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(350, 729);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(133, 55);
            this.btnDeletar.TabIndex = 9;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(1107, 729);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(133, 55);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtBxBuscaSobrenome
            // 
            this.txtBxBuscaSobrenome.Location = new System.Drawing.Point(648, 20);
            this.txtBxBuscaSobrenome.Name = "txtBxBuscaSobrenome";
            this.txtBxBuscaSobrenome.Size = new System.Drawing.Size(410, 31);
            this.txtBxBuscaSobrenome.TabIndex = 11;
            // 
            // lblBuscaNome
            // 
            this.lblBuscaNome.AutoSize = true;
            this.lblBuscaNome.Location = new System.Drawing.Point(12, 23);
            this.lblBuscaNome.Name = "lblBuscaNome";
            this.lblBuscaNome.Size = new System.Drawing.Size(74, 25);
            this.lblBuscaNome.TabIndex = 12;
            this.lblBuscaNome.Text = "Nome:";
            // 
            // lblBuscaSobrenome
            // 
            this.lblBuscaSobrenome.AutoSize = true;
            this.lblBuscaSobrenome.Location = new System.Drawing.Point(514, 23);
            this.lblBuscaSobrenome.Name = "lblBuscaSobrenome";
            this.lblBuscaSobrenome.Size = new System.Drawing.Size(128, 25);
            this.lblBuscaSobrenome.TabIndex = 13;
            this.lblBuscaSobrenome.Text = "Sobrenome:";
            // 
            // lblTotalHospedes
            // 
            this.lblTotalHospedes.AutoSize = true;
            this.lblTotalHospedes.Location = new System.Drawing.Point(13, 673);
            this.lblTotalHospedes.Name = "lblTotalHospedes";
            this.lblTotalHospedes.Size = new System.Drawing.Size(72, 25);
            this.lblTotalHospedes.TabIndex = 14;
            this.lblTotalHospedes.Text = "Total: ";
            // 
            // FormHospede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 818);
            this.Controls.Add(this.lblTotalHospedes);
            this.Controls.Add(this.lblBuscaSobrenome);
            this.Controls.Add(this.lblBuscaNome);
            this.Controls.Add(this.txtBxBuscaSobrenome);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBxBuscaNome);
            this.Controls.Add(this.gridHospedes);
            this.Controls.Add(this.btnInserir);
            this.Name = "FormHospede";
            this.Text = "FormHospede";
            this.Load += new System.EventHandler(this.FormHospede_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridHospedes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DataGridView gridHospedes;
        private System.Windows.Forms.TextBox txtBxBuscaNome;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtBxBuscaSobrenome;
        private System.Windows.Forms.Label lblBuscaNome;
        private System.Windows.Forms.Label lblBuscaSobrenome;
        private System.Windows.Forms.Label lblTotalHospedes;
    }
}