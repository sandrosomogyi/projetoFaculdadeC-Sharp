namespace Sistema_PIM.Apresentacao
{
    partial class frmInicialProntuario
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
            this.mnsAnamnese = new System.Windows.Forms.MenuStrip();
            this.tsmCrianca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdulto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGestante = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAnamnese = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHistorico = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBranco = new System.Windows.Forms.Panel();
            this.mnsAnamnese.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsAnamnese
            // 
            this.mnsAnamnese.BackColor = System.Drawing.Color.Green;
            this.mnsAnamnese.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsAnamnese.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCrianca,
            this.tsmAdulto,
            this.tsmGestante,
            this.tsmAnamnese,
            this.tsmHistorico});
            this.mnsAnamnese.Location = new System.Drawing.Point(0, 0);
            this.mnsAnamnese.Name = "mnsAnamnese";
            this.mnsAnamnese.Size = new System.Drawing.Size(767, 24);
            this.mnsAnamnese.TabIndex = 0;
            this.mnsAnamnese.Text = "mnsAnamnese";
            // 
            // tsmCrianca
            // 
            this.tsmCrianca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmCrianca.Name = "tsmCrianca";
            this.tsmCrianca.Size = new System.Drawing.Size(125, 20);
            this.tsmCrianca.Text = "Cadastro de Criança";
            this.tsmCrianca.Click += new System.EventHandler(this.tsmCrianca_Click);
            // 
            // tsmAdulto
            // 
            this.tsmAdulto.BackColor = System.Drawing.Color.Green;
            this.tsmAdulto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmAdulto.Name = "tsmAdulto";
            this.tsmAdulto.Size = new System.Drawing.Size(121, 20);
            this.tsmAdulto.Text = "Cadastro de Adulto";
            this.tsmAdulto.Click += new System.EventHandler(this.tsmAdulto_Click);
            // 
            // tsmGestante
            // 
            this.tsmGestante.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmGestante.Name = "tsmGestante";
            this.tsmGestante.Size = new System.Drawing.Size(131, 20);
            this.tsmGestante.Text = "Cadastro de Gestante";
            this.tsmGestante.Click += new System.EventHandler(this.tsmGestante_Click);
            // 
            // tsmAnamnese
            // 
            this.tsmAnamnese.Checked = true;
            this.tsmAnamnese.CheckOnClick = true;
            this.tsmAnamnese.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmAnamnese.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmAnamnese.Name = "tsmAnamnese";
            this.tsmAnamnese.Size = new System.Drawing.Size(75, 20);
            this.tsmAnamnese.Text = "Anamnese";
            this.tsmAnamnese.Click += new System.EventHandler(this.tsmAnamnese_Click);
            // 
            // tsmHistorico
            // 
            this.tsmHistorico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmHistorico.Name = "tsmHistorico";
            this.tsmHistorico.Size = new System.Drawing.Size(67, 20);
            this.tsmHistorico.Text = "Histórico";
            this.tsmHistorico.Click += new System.EventHandler(this.tsmHistorico_Click);
            // 
            // pnlBranco
            // 
            this.pnlBranco.Location = new System.Drawing.Point(0, 24);
            this.pnlBranco.Name = "pnlBranco";
            this.pnlBranco.Size = new System.Drawing.Size(767, 484);
            this.pnlBranco.TabIndex = 1;
            // 
            // frmInicialProntuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 508);
            this.Controls.Add(this.pnlBranco);
            this.Controls.Add(this.mnsAnamnese);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mnsAnamnese;
            this.Name = "frmInicialProntuario";
            this.Text = "frmProntuario";
            this.mnsAnamnese.ResumeLayout(false);
            this.mnsAnamnese.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsAnamnese;
        private System.Windows.Forms.ToolStripMenuItem tsmAnamnese;
        private System.Windows.Forms.ToolStripMenuItem tsmAdulto;
        private System.Windows.Forms.ToolStripMenuItem tsmGestante;
        private System.Windows.Forms.ToolStripMenuItem tsmCrianca;
        private System.Windows.Forms.Panel pnlBranco;
        private System.Windows.Forms.ToolStripMenuItem tsmHistorico;
    }
}