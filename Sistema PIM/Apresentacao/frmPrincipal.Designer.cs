namespace Interface_PIM
{
    partial class FrmPrincipal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
			this.pnlDesign1 = new System.Windows.Forms.Panel();
			this.btnConsultaDia = new System.Windows.Forms.Button();
			this.btnTrocar = new System.Windows.Forms.Button();
			this.lblTipoLogin = new System.Windows.Forms.Label();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnProfissionais = new System.Windows.Forms.Button();
			this.pnlStats = new System.Windows.Forms.Panel();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.ptbUsuario = new System.Windows.Forms.PictureBox();
			this.btnProntuarios = new System.Windows.Forms.Button();
			this.btnAgenda = new System.Windows.Forms.Button();
			this.btnPaciente = new System.Windows.Forms.Button();
			this.pnlDesign2 = new System.Windows.Forms.Panel();
			this.pnlDesign3 = new System.Windows.Forms.Panel();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.ptbLogo = new System.Windows.Forms.PictureBox();
			this.pnlPrincipal = new System.Windows.Forms.Panel();
			this.lblBemvindo = new System.Windows.Forms.Label();
			this.pnlDesign1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbUsuario)).BeginInit();
			this.pnlDesign2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
			this.pnlPrincipal.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlDesign1
			// 
			this.pnlDesign1.BackColor = System.Drawing.Color.DarkGreen;
			this.pnlDesign1.Controls.Add(this.btnConsultaDia);
			this.pnlDesign1.Controls.Add(this.btnTrocar);
			this.pnlDesign1.Controls.Add(this.lblTipoLogin);
			this.pnlDesign1.Controls.Add(this.btnSair);
			this.pnlDesign1.Controls.Add(this.btnProfissionais);
			this.pnlDesign1.Controls.Add(this.pnlStats);
			this.pnlDesign1.Controls.Add(this.lblUsuario);
			this.pnlDesign1.Controls.Add(this.ptbUsuario);
			this.pnlDesign1.Controls.Add(this.btnProntuarios);
			this.pnlDesign1.Controls.Add(this.btnAgenda);
			this.pnlDesign1.Controls.Add(this.btnPaciente);
			this.pnlDesign1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlDesign1.Location = new System.Drawing.Point(0, 0);
			this.pnlDesign1.Name = "pnlDesign1";
			this.pnlDesign1.Size = new System.Drawing.Size(200, 551);
			this.pnlDesign1.TabIndex = 3;
			// 
			// btnConsultaDia
			// 
			this.btnConsultaDia.FlatAppearance.BorderSize = 0;
			this.btnConsultaDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConsultaDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.btnConsultaDia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnConsultaDia.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaDia.Image")));
			this.btnConsultaDia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnConsultaDia.Location = new System.Drawing.Point(12, 163);
			this.btnConsultaDia.Name = "btnConsultaDia";
			this.btnConsultaDia.Size = new System.Drawing.Size(192, 28);
			this.btnConsultaDia.TabIndex = 0;
			this.btnConsultaDia.Text = "   Consultas do Dia";
			this.btnConsultaDia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnConsultaDia.UseVisualStyleBackColor = true;
			this.btnConsultaDia.Click += new System.EventHandler(this.btnConsultaDia_Click);
			// 
			// btnTrocar
			// 
			this.btnTrocar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnTrocar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrocar.BackgroundImage")));
			this.btnTrocar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnTrocar.FlatAppearance.BorderSize = 0;
			this.btnTrocar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTrocar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnTrocar.Location = new System.Drawing.Point(19, 507);
			this.btnTrocar.Name = "btnTrocar";
			this.btnTrocar.Size = new System.Drawing.Size(39, 28);
			this.btnTrocar.TabIndex = 5;
			this.btnTrocar.UseVisualStyleBackColor = true;
			this.btnTrocar.Click += new System.EventHandler(this.btnTrocar_Click);
			// 
			// lblTipoLogin
			// 
			this.lblTipoLogin.AutoSize = true;
			this.lblTipoLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblTipoLogin.ForeColor = System.Drawing.Color.DarkGreen;
			this.lblTipoLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblTipoLogin.Location = new System.Drawing.Point(58, 123);
			this.lblTipoLogin.Name = "lblTipoLogin";
			this.lblTipoLogin.Size = new System.Drawing.Size(0, 13);
			this.lblTipoLogin.TabIndex = 24;
			// 
			// btnSair
			// 
			this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
			this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnSair.FlatAppearance.BorderSize = 0;
			this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSair.Location = new System.Drawing.Point(149, 502);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(39, 37);
			this.btnSair.TabIndex = 6;
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// btnProfissionais
			// 
			this.btnProfissionais.FlatAppearance.BorderSize = 0;
			this.btnProfissionais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProfissionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.btnProfissionais.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnProfissionais.Image = ((System.Drawing.Image)(resources.GetObject("btnProfissionais.Image")));
			this.btnProfissionais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnProfissionais.Location = new System.Drawing.Point(12, 266);
			this.btnProfissionais.Name = "btnProfissionais";
			this.btnProfissionais.Size = new System.Drawing.Size(192, 28);
			this.btnProfissionais.TabIndex = 4;
			this.btnProfissionais.Text = "    Profissionais";
			this.btnProfissionais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnProfissionais.UseVisualStyleBackColor = true;
			this.btnProfissionais.Click += new System.EventHandler(this.btnProfissionais_Click);
			// 
			// pnlStats
			// 
			this.pnlStats.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.pnlStats.Location = new System.Drawing.Point(0, 164);
			this.pnlStats.Name = "pnlStats";
			this.pnlStats.Size = new System.Drawing.Size(7, 28);
			this.pnlStats.TabIndex = 5;
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblUsuario.Location = new System.Drawing.Point(58, 91);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(0, 16);
			this.lblUsuario.TabIndex = 7;
			// 
			// ptbUsuario
			// 
			this.ptbUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbUsuario.BackgroundImage")));
			this.ptbUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ptbUsuario.Location = new System.Drawing.Point(61, 24);
			this.ptbUsuario.Name = "ptbUsuario";
			this.ptbUsuario.Size = new System.Drawing.Size(64, 64);
			this.ptbUsuario.TabIndex = 6;
			this.ptbUsuario.TabStop = false;
			// 
			// btnProntuarios
			// 
			this.btnProntuarios.FlatAppearance.BorderSize = 0;
			this.btnProntuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProntuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.btnProntuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnProntuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnProntuarios.Image")));
			this.btnProntuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnProntuarios.Location = new System.Drawing.Point(12, 300);
			this.btnProntuarios.Name = "btnProntuarios";
			this.btnProntuarios.Size = new System.Drawing.Size(192, 28);
			this.btnProntuarios.TabIndex = 3;
			this.btnProntuarios.Text = "    Prontuários";
			this.btnProntuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnProntuarios.UseVisualStyleBackColor = true;
			this.btnProntuarios.Click += new System.EventHandler(this.btnProntuarios_Click);
			// 
			// btnAgenda
			// 
			this.btnAgenda.FlatAppearance.BorderSize = 0;
			this.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.btnAgenda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnAgenda.Image = ((System.Drawing.Image)(resources.GetObject("btnAgenda.Image")));
			this.btnAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgenda.Location = new System.Drawing.Point(12, 198);
			this.btnAgenda.Name = "btnAgenda";
			this.btnAgenda.Size = new System.Drawing.Size(192, 28);
			this.btnAgenda.TabIndex = 1;
			this.btnAgenda.Text = "    Agenda de Consultas";
			this.btnAgenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAgenda.UseVisualStyleBackColor = true;
			this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
			// 
			// btnPaciente
			// 
			this.btnPaciente.FlatAppearance.BorderSize = 0;
			this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.btnPaciente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnPaciente.Image")));
			this.btnPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPaciente.Location = new System.Drawing.Point(12, 232);
			this.btnPaciente.Name = "btnPaciente";
			this.btnPaciente.Size = new System.Drawing.Size(192, 28);
			this.btnPaciente.TabIndex = 2;
			this.btnPaciente.Text = "    Pacientes";
			this.btnPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPaciente.UseVisualStyleBackColor = true;
			this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
			// 
			// pnlDesign2
			// 
			this.pnlDesign2.BackColor = System.Drawing.Color.Green;
			this.pnlDesign2.Controls.Add(this.pnlDesign3);
			this.pnlDesign2.Controls.Add(this.lblTitulo);
			this.pnlDesign2.Controls.Add(this.ptbLogo);
			this.pnlDesign2.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlDesign2.Location = new System.Drawing.Point(200, 0);
			this.pnlDesign2.Name = "pnlDesign2";
			this.pnlDesign2.Size = new System.Drawing.Size(767, 44);
			this.pnlDesign2.TabIndex = 4;
			// 
			// pnlDesign3
			// 
			this.pnlDesign3.Location = new System.Drawing.Point(0, 43);
			this.pnlDesign3.Name = "pnlDesign3";
			this.pnlDesign3.Size = new System.Drawing.Size(767, 508);
			this.pnlDesign3.TabIndex = 5;
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblTitulo.Location = new System.Drawing.Point(25, 13);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(163, 20);
			this.lblTitulo.TabIndex = 1;
			this.lblTitulo.Text = "Sistema Enfermagem";
			// 
			// ptbLogo
			// 
			this.ptbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbLogo.BackgroundImage")));
			this.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ptbLogo.Location = new System.Drawing.Point(666, 2);
			this.ptbLogo.Name = "ptbLogo";
			this.ptbLogo.Size = new System.Drawing.Size(100, 40);
			this.ptbLogo.TabIndex = 0;
			this.ptbLogo.TabStop = false;
			// 
			// pnlPrincipal
			// 
			this.pnlPrincipal.Controls.Add(this.lblBemvindo);
			this.pnlPrincipal.Location = new System.Drawing.Point(200, 44);
			this.pnlPrincipal.Name = "pnlPrincipal";
			this.pnlPrincipal.Size = new System.Drawing.Size(767, 508);
			this.pnlPrincipal.TabIndex = 5;
			// 
			// lblBemvindo
			// 
			this.lblBemvindo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblBemvindo.BackColor = System.Drawing.Color.Transparent;
			this.lblBemvindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBemvindo.ForeColor = System.Drawing.Color.Green;
			this.lblBemvindo.Location = new System.Drawing.Point(148, 155);
			this.lblBemvindo.Name = "lblBemvindo";
			this.lblBemvindo.Size = new System.Drawing.Size(502, 128);
			this.lblBemvindo.TabIndex = 2;
			this.lblBemvindo.Text = "Bem vindo,  ao Sistema de Gestão da Clinica de Enfermagem.\r\nUniversidade Paulista" +
    " - Unip\r\n Campus Sorocaba.";
			this.lblBemvindo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FrmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(967, 551);
			this.Controls.Add(this.pnlDesign2);
			this.Controls.Add(this.pnlDesign1);
			this.Controls.Add(this.pnlPrincipal);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Interface";
			this.Load += new System.EventHandler(this.frmPrincipal_Load);
			this.pnlDesign1.ResumeLayout(false);
			this.pnlDesign1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbUsuario)).EndInit();
			this.pnlDesign2.ResumeLayout(false);
			this.pnlDesign2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
			this.pnlPrincipal.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Panel pnlDesign1;
        internal System.Windows.Forms.Button btnProfissionais;
        internal System.Windows.Forms.Panel pnlStats;
        internal System.Windows.Forms.Label lblUsuario;
        internal System.Windows.Forms.PictureBox ptbUsuario;
        internal System.Windows.Forms.Button btnProntuarios;
        internal System.Windows.Forms.Button btnAgenda;
        internal System.Windows.Forms.Button btnPaciente;
        internal System.Windows.Forms.Panel pnlDesign2;
        internal System.Windows.Forms.Label lblTitulo;
        internal System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTipoLogin;
        private System.Windows.Forms.Panel pnlDesign3;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Button btnTrocar;
        internal System.Windows.Forms.Button btnConsultaDia;
        private System.Windows.Forms.Label lblBemvindo;
    }
}

