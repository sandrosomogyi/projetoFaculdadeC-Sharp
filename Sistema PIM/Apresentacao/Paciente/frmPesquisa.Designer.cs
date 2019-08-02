namespace Sistema_PIM.Apresentacao.Agenda
{
    partial class frmConsulta
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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlLista = new System.Windows.Forms.Panel();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.txbSobrenome = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCPFConsultado = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlDesign = new System.Windows.Forms.Panel();
            this.pnlPrincipal.SuspendLayout();
            this.pnlLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.pnlLista);
            this.pnlPrincipal.Controls.Add(this.btnExcluir);
            this.pnlPrincipal.Controls.Add(this.btnEditar);
            this.pnlPrincipal.Controls.Add(this.btnNovo);
            this.pnlPrincipal.Controls.Add(this.btnConsultar);
            this.pnlPrincipal.Controls.Add(this.mtbCPF);
            this.pnlPrincipal.Controls.Add(this.lblCPF);
            this.pnlPrincipal.Controls.Add(this.lblTitulo);
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(767, 484);
            this.pnlPrincipal.TabIndex = 764;
            // 
            // pnlLista
            // 
            this.pnlLista.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlLista.Controls.Add(this.pnlDesign);
            this.pnlLista.Controls.Add(this.txbEmail);
            this.pnlLista.Controls.Add(this.txbCPF);
            this.pnlLista.Controls.Add(this.txbSobrenome);
            this.pnlLista.Controls.Add(this.txbNome);
            this.pnlLista.Controls.Add(this.lblEmail);
            this.pnlLista.Controls.Add(this.lblCPFConsultado);
            this.pnlLista.Controls.Add(this.lblSobrenome);
            this.pnlLista.Controls.Add(this.lblNome);
            this.pnlLista.Location = new System.Drawing.Point(18, 107);
            this.pnlLista.Name = "pnlLista";
            this.pnlLista.Size = new System.Drawing.Size(464, 323);
            this.pnlLista.TabIndex = 770;
            // 
            // txbEmail
            // 
            this.txbEmail.Enabled = false;
            this.txbEmail.Location = new System.Drawing.Point(128, 236);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(306, 20);
            this.txbEmail.TabIndex = 7;
            this.txbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbCPF
            // 
            this.txbCPF.Enabled = false;
            this.txbCPF.Location = new System.Drawing.Point(128, 179);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(306, 20);
            this.txbCPF.TabIndex = 6;
            this.txbCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbSobrenome
            // 
            this.txbSobrenome.Enabled = false;
            this.txbSobrenome.Location = new System.Drawing.Point(128, 115);
            this.txbSobrenome.Name = "txbSobrenome";
            this.txbSobrenome.Size = new System.Drawing.Size(306, 20);
            this.txbSobrenome.TabIndex = 5;
            this.txbSobrenome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbNome
            // 
            this.txbNome.Enabled = false;
            this.txbNome.Location = new System.Drawing.Point(128, 64);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(306, 20);
            this.txbNome.TabIndex = 4;
            this.txbNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(26, 238);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 18);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email :";
            // 
            // lblCPFConsultado
            // 
            this.lblCPFConsultado.AutoSize = true;
            this.lblCPFConsultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFConsultado.Location = new System.Drawing.Point(26, 181);
            this.lblCPFConsultado.Name = "lblCPFConsultado";
            this.lblCPFConsultado.Size = new System.Drawing.Size(46, 18);
            this.lblCPFConsultado.TabIndex = 2;
            this.lblCPFConsultado.Text = "CPF :";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.Location = new System.Drawing.Point(26, 114);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(94, 18);
            this.lblSobrenome.TabIndex = 1;
            this.lblSobrenome.Text = "Sobrenome :";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(29, 63);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(57, 18);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome :";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnExcluir.ForeColor = System.Drawing.Color.Red;
            this.btnExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExcluir.Location = new System.Drawing.Point(15, 436);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 766;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnEditar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnEditar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditar.Location = new System.Drawing.Point(676, 436);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 765;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnNovo.ForeColor = System.Drawing.Color.Green;
            this.btnNovo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNovo.Location = new System.Drawing.Point(626, 74);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(125, 23);
            this.btnNovo.TabIndex = 771;
            this.btnNovo.Text = "Novo Paciente";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnConsultar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnConsultar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConsultar.Location = new System.Drawing.Point(194, 75);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 769;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(47, 76);
            this.mtbCPF.Mask = "000.000.000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(118, 20);
            this.mtbCPF.TabIndex = 768;
            this.mtbCPF.Click += new System.EventHandler(this.MtbCPF_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCPF.Location = new System.Drawing.Point(15, 79);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 767;
            this.lblCPF.Text = "CPF";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(284, 26);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(168, 18);
            this.lblTitulo.TabIndex = 764;
            this.lblTitulo.Text = "Consulta de Paciente";
            // 
            // pnlDesign
            // 
            this.pnlDesign.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlDesign.Location = new System.Drawing.Point(0, 0);
            this.pnlDesign.Name = "pnlDesign";
            this.pnlDesign.Size = new System.Drawing.Size(464, 13);
            this.pnlDesign.TabIndex = 772;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 484);
            this.Controls.Add(this.pnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmConsulta";
            this.Text = "frmConsulta";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlLista.ResumeLayout(false);
            this.pnlLista.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlLista;
        private System.Windows.Forms.Panel pnlDesign;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.TextBox txbSobrenome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCPFConsultado;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblNome;
        internal System.Windows.Forms.Button btnExcluir;
        internal System.Windows.Forms.Button btnEditar;
        internal System.Windows.Forms.Button btnNovo;
        internal System.Windows.Forms.Button btnConsultar;
        internal System.Windows.Forms.MaskedTextBox mtbCPF;
        internal System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblTitulo;
    }
}