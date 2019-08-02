namespace Sistema_PIM.Apresentacao.Encaminhamento
{
    partial class frmEncaminhamento
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
			this.rbtNutricao = new System.Windows.Forms.RadioButton();
			this.rbtOdontologia = new System.Windows.Forms.RadioButton();
			this.rbtPsicologia = new System.Windows.Forms.RadioButton();
			this.rbtFisioterapia = new System.Windows.Forms.RadioButton();
			this.rbtOutros = new System.Windows.Forms.RadioButton();
			this.txbOutros = new System.Windows.Forms.TextBox();
			this.lblObs = new System.Windows.Forms.Label();
			this.rtbObs = new System.Windows.Forms.RichTextBox();
			this.lblText4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// rbtNutricao
			// 
			this.rbtNutricao.AutoSize = true;
			this.rbtNutricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtNutricao.Location = new System.Drawing.Point(11, 36);
			this.rbtNutricao.Margin = new System.Windows.Forms.Padding(2);
			this.rbtNutricao.Name = "rbtNutricao";
			this.rbtNutricao.Size = new System.Drawing.Size(71, 19);
			this.rbtNutricao.TabIndex = 7;
			this.rbtNutricao.TabStop = true;
			this.rbtNutricao.Text = "Nutrição";
			this.rbtNutricao.UseVisualStyleBackColor = true;
			// 
			// rbtOdontologia
			// 
			this.rbtOdontologia.AutoSize = true;
			this.rbtOdontologia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtOdontologia.Location = new System.Drawing.Point(77, 36);
			this.rbtOdontologia.Margin = new System.Windows.Forms.Padding(2);
			this.rbtOdontologia.Name = "rbtOdontologia";
			this.rbtOdontologia.Size = new System.Drawing.Size(92, 19);
			this.rbtOdontologia.TabIndex = 8;
			this.rbtOdontologia.TabStop = true;
			this.rbtOdontologia.Text = "Odontologia";
			this.rbtOdontologia.UseVisualStyleBackColor = true;
			// 
			// rbtPsicologia
			// 
			this.rbtPsicologia.AutoSize = true;
			this.rbtPsicologia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtPsicologia.Location = new System.Drawing.Point(166, 36);
			this.rbtPsicologia.Margin = new System.Windows.Forms.Padding(2);
			this.rbtPsicologia.Name = "rbtPsicologia";
			this.rbtPsicologia.Size = new System.Drawing.Size(82, 19);
			this.rbtPsicologia.TabIndex = 9;
			this.rbtPsicologia.TabStop = true;
			this.rbtPsicologia.Text = "Psicologia";
			this.rbtPsicologia.UseVisualStyleBackColor = true;
			// 
			// rbtFisioterapia
			// 
			this.rbtFisioterapia.AutoSize = true;
			this.rbtFisioterapia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtFisioterapia.Location = new System.Drawing.Point(252, 36);
			this.rbtFisioterapia.Margin = new System.Windows.Forms.Padding(2);
			this.rbtFisioterapia.Name = "rbtFisioterapia";
			this.rbtFisioterapia.Size = new System.Drawing.Size(89, 19);
			this.rbtFisioterapia.TabIndex = 10;
			this.rbtFisioterapia.TabStop = true;
			this.rbtFisioterapia.Text = "Fisioterapia";
			this.rbtFisioterapia.UseVisualStyleBackColor = true;
			// 
			// rbtOutros
			// 
			this.rbtOutros.AutoSize = true;
			this.rbtOutros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtOutros.Location = new System.Drawing.Point(345, 36);
			this.rbtOutros.Margin = new System.Windows.Forms.Padding(2);
			this.rbtOutros.Name = "rbtOutros";
			this.rbtOutros.Size = new System.Drawing.Size(64, 19);
			this.rbtOutros.TabIndex = 11;
			this.rbtOutros.TabStop = true;
			this.rbtOutros.Text = "Outros:";
			this.rbtOutros.UseVisualStyleBackColor = true;
			this.rbtOutros.CheckedChanged += new System.EventHandler(this.RadioButton5_CheckedChanged);
			// 
			// txbOutros
			// 
			this.txbOutros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbOutros.Location = new System.Drawing.Point(413, 35);
			this.txbOutros.Margin = new System.Windows.Forms.Padding(2);
			this.txbOutros.Name = "txbOutros";
			this.txbOutros.Size = new System.Drawing.Size(343, 21);
			this.txbOutros.TabIndex = 12;
			// 
			// lblObs
			// 
			this.lblObs.AutoSize = true;
			this.lblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblObs.Location = new System.Drawing.Point(11, 67);
			this.lblObs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblObs.Name = "lblObs";
			this.lblObs.Size = new System.Drawing.Size(116, 22);
			this.lblObs.TabIndex = 13;
			this.lblObs.Text = "Observações";
			// 
			// rtbObs
			// 
			this.rtbObs.Location = new System.Drawing.Point(10, 100);
			this.rtbObs.Margin = new System.Windows.Forms.Padding(2);
			this.rtbObs.Name = "rtbObs";
			this.rtbObs.Size = new System.Drawing.Size(746, 175);
			this.rtbObs.TabIndex = 14;
			this.rtbObs.Text = "";
			// 
			// lblText4
			// 
			this.lblText4.AutoSize = true;
			this.lblText4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblText4.Location = new System.Drawing.Point(10, 9);
			this.lblText4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblText4.Name = "lblText4";
			this.lblText4.Size = new System.Drawing.Size(151, 22);
			this.lblText4.TabIndex = 6;
			this.lblText4.Text = "Encaminhar para:";
			// 
			// frmEncaminhamento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(767, 484);
			this.Controls.Add(this.rtbObs);
			this.Controls.Add(this.lblObs);
			this.Controls.Add(this.txbOutros);
			this.Controls.Add(this.rbtOutros);
			this.Controls.Add(this.rbtFisioterapia);
			this.Controls.Add(this.rbtPsicologia);
			this.Controls.Add(this.rbtOdontologia);
			this.Controls.Add(this.rbtNutricao);
			this.Controls.Add(this.lblText4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "frmEncaminhamento";
			this.Text = "frmEncaminhamento";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbtNutricao;
        private System.Windows.Forms.RadioButton rbtOdontologia;
        private System.Windows.Forms.RadioButton rbtPsicologia;
        private System.Windows.Forms.RadioButton rbtFisioterapia;
        private System.Windows.Forms.RadioButton rbtOutros;
        private System.Windows.Forms.TextBox txbOutros;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.RichTextBox rtbObs;
		private System.Windows.Forms.Label lblText4;
	}
}