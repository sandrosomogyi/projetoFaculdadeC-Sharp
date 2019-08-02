namespace Sistema_PIM.Apresentacao
{
    partial class frmInicialEncaminhamento
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
            this.pnlMenuEnc = new System.Windows.Forms.Panel();
            this.tmsEncaminhamento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPedidoExame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMenuEnc = new System.Windows.Forms.MenuStrip();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.mnsMenuEnc.SuspendLayout();
            this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuEnc
            // 
            this.pnlMenuEnc.Location = new System.Drawing.Point(0, 24);
            this.pnlMenuEnc.Name = "pnlMenuEnc";
            this.pnlMenuEnc.Size = new System.Drawing.Size(767, 484);
            this.pnlMenuEnc.TabIndex = 3;
            // 
            // tmsEncaminhamento
            // 
            this.tmsEncaminhamento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tmsEncaminhamento.Name = "tmsEncaminhamento";
            this.tmsEncaminhamento.Size = new System.Drawing.Size(113, 20);
            this.tmsEncaminhamento.Text = "Encaminhamento";
            this.tmsEncaminhamento.Click += new System.EventHandler(this.TsmEncaminhamento_Click);
            // 
            // tsmPedidoExame
            // 
            this.tsmPedidoExame.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmPedidoExame.Name = "tsmPedidoExame";
            this.tsmPedidoExame.Size = new System.Drawing.Size(114, 20);
            this.tsmPedidoExame.Text = "Pedido de Exames";
            this.tsmPedidoExame.Click += new System.EventHandler(this.TsmPedidoExame_Click);
            // 
            // mnsMenuEnc
            // 
            this.mnsMenuEnc.BackColor = System.Drawing.Color.Green;
            this.mnsMenuEnc.Dock = System.Windows.Forms.DockStyle.None;
            this.mnsMenuEnc.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMenuEnc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsEncaminhamento,
            this.tsmPedidoExame});
            this.mnsMenuEnc.Location = new System.Drawing.Point(0, 0);
            this.mnsMenuEnc.Name = "mnsMenuEnc";
            this.mnsMenuEnc.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnsMenuEnc.Size = new System.Drawing.Size(767, 24);
            this.mnsMenuEnc.TabIndex = 2;
            this.mnsMenuEnc.Text = "mnsAnamnese";
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(767, 2);
            this.toolStripContainer2.Location = new System.Drawing.Point(0, -1);
            this.toolStripContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(767, 26);
            this.toolStripContainer2.TabIndex = 5;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.mnsMenuEnc);
            // 
            // frmInicialEncaminhamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 508);
            this.Controls.Add(this.toolStripContainer2);
            this.Controls.Add(this.pnlMenuEnc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInicialEncaminhamento";
            this.Text = "frmPedidoExame";
            this.mnsMenuEnc.ResumeLayout(false);
            this.mnsMenuEnc.PerformLayout();
            this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuEnc;
        private System.Windows.Forms.ToolStripMenuItem tmsEncaminhamento;
        private System.Windows.Forms.ToolStripMenuItem tsmPedidoExame;
        private System.Windows.Forms.MenuStrip mnsMenuEnc;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
    }
}