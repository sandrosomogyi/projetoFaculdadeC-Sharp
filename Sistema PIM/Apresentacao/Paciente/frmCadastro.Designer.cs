namespace Sistema_PIM.Apresentacao
{
    partial class frmCadastro
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
            this.mnsCadastro = new System.Windows.Forms.MenuStrip();
            this.tsmPessoal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCrianca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdulto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGestante = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAnamnese = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.mnsCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsCadastro
            // 
            this.mnsCadastro.BackColor = System.Drawing.Color.Green;
            this.mnsCadastro.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsCadastro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPessoal,
            this.tsmCrianca,
            this.tsmAdulto,
            this.tsmGestante,
            this.tsmAnamnese});
            this.mnsCadastro.Location = new System.Drawing.Point(0, 0);
            this.mnsCadastro.Name = "mnsCadastro";
            this.mnsCadastro.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnsCadastro.Size = new System.Drawing.Size(1023, 28);
            this.mnsCadastro.TabIndex = 1;
            this.mnsCadastro.Text = "mnsAnamnese";
            // 
            // tsmPessoal
            // 
            this.tsmPessoal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmPessoal.Name = "tsmPessoal";
            this.tsmPessoal.Size = new System.Drawing.Size(110, 24);
            this.tsmPessoal.Text = "Dado Pessoal";
            // 
            // tsmCrianca
            // 
            this.tsmCrianca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmCrianca.Name = "tsmCrianca";
            this.tsmCrianca.Size = new System.Drawing.Size(154, 24);
            this.tsmCrianca.Text = "Cadastro de Criança";
            // 
            // tsmAdulto
            // 
            this.tsmAdulto.BackColor = System.Drawing.Color.Green;
            this.tsmAdulto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmAdulto.Name = "tsmAdulto";
            this.tsmAdulto.Size = new System.Drawing.Size(150, 24);
            this.tsmAdulto.Text = "Cadastro de Adulto";
            // 
            // tsmGestante
            // 
            this.tsmGestante.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmGestante.Name = "tsmGestante";
            this.tsmGestante.Size = new System.Drawing.Size(163, 24);
            this.tsmGestante.Text = "Cadastro de Gestante";
            // 
            // tsmAnamnese
            // 
            this.tsmAnamnese.Checked = true;
            this.tsmAnamnese.CheckOnClick = true;
            this.tsmAnamnese.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmAnamnese.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmAnamnese.Name = "tsmAnamnese";
            this.tsmAnamnese.Size = new System.Drawing.Size(90, 24);
            this.tsmAnamnese.Text = "Anamnese";
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.Location = new System.Drawing.Point(0, 28);
            this.pnlCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(1023, 596);
            this.pnlCadastro.TabIndex = 2;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 596);
            this.Controls.Add(this.pnlCadastro);
            this.Controls.Add(this.mnsCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadastro";
            this.Text = "frmCadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.mnsCadastro.ResumeLayout(false);
            this.mnsCadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsCadastro;
        private System.Windows.Forms.ToolStripMenuItem tsmPessoal;
        private System.Windows.Forms.ToolStripMenuItem tsmCrianca;
        private System.Windows.Forms.ToolStripMenuItem tsmAdulto;
        private System.Windows.Forms.ToolStripMenuItem tsmGestante;
        private System.Windows.Forms.ToolStripMenuItem tsmAnamnese;
        private System.Windows.Forms.Panel pnlCadastro;
    }
}