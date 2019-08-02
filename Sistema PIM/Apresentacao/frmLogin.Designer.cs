using System.Windows.Forms;

namespace Interface_PIM.Apresentacao
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlDesign1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlDesign3 = new System.Windows.Forms.Panel();
            this.llbEsqueceu = new System.Windows.Forms.LinkLabel();
            this.pnlDesign5 = new System.Windows.Forms.Panel();
            this.pnlDesign4 = new System.Windows.Forms.Panel();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlDesign2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlDesign1.SuspendLayout();
            this.pnlDesign3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDesign1
            // 
            this.pnlDesign1.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlDesign1.Controls.Add(this.btnSair);
            this.pnlDesign1.Controls.Add(this.pnlDesign3);
            this.pnlDesign1.Controls.Add(this.pnlDesign2);
            this.pnlDesign1.Controls.Add(this.lblTitulo);
            this.pnlDesign1.Controls.Add(this.PictureBox1);
            this.pnlDesign1.Location = new System.Drawing.Point(0, 0);
            this.pnlDesign1.Name = "pnlDesign1";
            this.pnlDesign1.Size = new System.Drawing.Size(587, 523);
            this.pnlDesign1.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(533, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(42, 39);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pnlDesign3
            // 
            this.pnlDesign3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlDesign3.Controls.Add(this.llbEsqueceu);
            this.pnlDesign3.Controls.Add(this.pnlDesign5);
            this.pnlDesign3.Controls.Add(this.pnlDesign4);
            this.pnlDesign3.Controls.Add(this.lblSenha);
            this.pnlDesign3.Controls.Add(this.lblLogin);
            this.pnlDesign3.Controls.Add(this.txbSenha);
            this.pnlDesign3.Controls.Add(this.txbLogin);
            this.pnlDesign3.Controls.Add(this.btnLogin);
            this.pnlDesign3.Location = new System.Drawing.Point(124, 192);
            this.pnlDesign3.Name = "pnlDesign3";
            this.pnlDesign3.Size = new System.Drawing.Size(341, 288);
            this.pnlDesign3.TabIndex = 0;
            // 
            // llbEsqueceu
            // 
            this.llbEsqueceu.AutoSize = true;
            this.llbEsqueceu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbEsqueceu.LinkColor = System.Drawing.Color.Green;
            this.llbEsqueceu.Location = new System.Drawing.Point(185, 144);
            this.llbEsqueceu.Name = "llbEsqueceu";
            this.llbEsqueceu.Size = new System.Drawing.Size(141, 16);
            this.llbEsqueceu.TabIndex = 16;
            this.llbEsqueceu.TabStop = true;
            this.llbEsqueceu.Text = "Esqueceu sua senha?";
            this.llbEsqueceu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbEsqueceu_LinkClicked);
            // 
            // pnlDesign5
            // 
            this.pnlDesign5.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlDesign5.Location = new System.Drawing.Point(54, 112);
            this.pnlDesign5.Name = "pnlDesign5";
            this.pnlDesign5.Size = new System.Drawing.Size(242, 5);
            this.pnlDesign5.TabIndex = 15;
            // 
            // pnlDesign4
            // 
            this.pnlDesign4.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlDesign4.Location = new System.Drawing.Point(51, 53);
            this.pnlDesign4.Name = "pnlDesign4";
            this.pnlDesign4.Size = new System.Drawing.Size(242, 5);
            this.pnlDesign4.TabIndex = 14;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(51, 64);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 13;
            this.lblSenha.Text = "Senha";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(51, 18);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 12;
            this.lblLogin.Text = "Login";
            // 
            // txbSenha
            // 
            this.txbSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSenha.Location = new System.Drawing.Point(51, 93);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(242, 13);
            this.txbSenha.TabIndex = 1;
            this.txbSenha.UseSystemPasswordChar = true;
            this.txbSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbSenha_KeyPress);
            // 
            // txbLogin
            // 
            this.txbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbLogin.Location = new System.Drawing.Point(51, 37);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(242, 13);
            this.txbLogin.TabIndex = 0;
            this.txbLogin.Tag = "";
            this.txbLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbLogin_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Green;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(9)))), ((int)(((byte)(75)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(9)))), ((int)(((byte)(75)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Location = new System.Drawing.Point(51, 192);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(242, 36);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "ENTRAR";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlDesign2
            // 
            this.pnlDesign2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlDesign2.Location = new System.Drawing.Point(0, 272);
            this.pnlDesign2.Name = "pnlDesign2";
            this.pnlDesign2.Size = new System.Drawing.Size(587, 251);
            this.pnlDesign2.TabIndex = 11;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(221, 158);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(143, 25);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Enfermagem";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(226, 30);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(134, 125);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 9;
            this.PictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 523);
            this.Controls.Add(this.pnlDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlDesign1.ResumeLayout(false);
            this.pnlDesign1.PerformLayout();
            this.pnlDesign3.ResumeLayout(false);
            this.pnlDesign3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDesign1;
        internal System.Windows.Forms.Label lblTitulo;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Panel pnlDesign3;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbLogin;
        internal System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlDesign2;
        private System.Windows.Forms.Panel pnlDesign5;
        private System.Windows.Forms.Panel pnlDesign4;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.LinkLabel llbEsqueceu;

        public LinkLabel LlbEsqueceu { get => llbEsqueceu; set => llbEsqueceu = value; }
    }
}
