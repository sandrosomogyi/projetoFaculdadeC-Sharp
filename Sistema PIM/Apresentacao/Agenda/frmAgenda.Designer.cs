namespace Interface_PIM.Apresentacao
{
    partial class frmAgenda
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
			this.rbtEmergencial = new System.Windows.Forms.RadioButton();
			this.btnAgendar = new System.Windows.Forms.Button();
			this.rbtRetorno = new System.Windows.Forms.RadioButton();
			this.rbtConsulta = new System.Windows.Forms.RadioButton();
			this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
			this.lblCPF = new System.Windows.Forms.Label();
			this.lblManha = new System.Windows.Forms.Label();
			this.rbtM8 = new System.Windows.Forms.RadioButton();
			this.rbtM9 = new System.Windows.Forms.RadioButton();
			this.rbtT18 = new System.Windows.Forms.RadioButton();
			this.lblTarde = new System.Windows.Forms.Label();
			this.rbtT17 = new System.Windows.Forms.RadioButton();
			this.gpbAgenda = new System.Windows.Forms.GroupBox();
			this.gpbHorario = new System.Windows.Forms.GroupBox();
			this.txbT18 = new System.Windows.Forms.TextBox();
			this.txbT17 = new System.Windows.Forms.TextBox();
			this.txbT16 = new System.Windows.Forms.TextBox();
			this.txbT15 = new System.Windows.Forms.TextBox();
			this.txbT14 = new System.Windows.Forms.TextBox();
			this.txbM12 = new System.Windows.Forms.TextBox();
			this.rbtT16 = new System.Windows.Forms.RadioButton();
			this.txbM9 = new System.Windows.Forms.TextBox();
			this.rbtT15 = new System.Windows.Forms.RadioButton();
			this.txbM11 = new System.Windows.Forms.TextBox();
			this.rbtM10 = new System.Windows.Forms.RadioButton();
			this.txbM10 = new System.Windows.Forms.TextBox();
			this.rbtT14 = new System.Windows.Forms.RadioButton();
			this.rbtM11 = new System.Windows.Forms.RadioButton();
			this.rbtM12 = new System.Windows.Forms.RadioButton();
			this.txbM8 = new System.Windows.Forms.TextBox();
			this.lblMedico = new System.Windows.Forms.Label();
			this.cbxMedico = new System.Windows.Forms.ComboBox();
			this.mtcCalendario = new System.Windows.Forms.MonthCalendar();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.gpbAgenda.SuspendLayout();
			this.gpbHorario.SuspendLayout();
			this.SuspendLayout();
			// 
			// rbtEmergencial
			// 
			this.rbtEmergencial.AutoSize = true;
			this.rbtEmergencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtEmergencial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.rbtEmergencial.Location = new System.Drawing.Point(285, 245);
			this.rbtEmergencial.Name = "rbtEmergencial";
			this.rbtEmergencial.Size = new System.Drawing.Size(83, 17);
			this.rbtEmergencial.TabIndex = 69;
			this.rbtEmergencial.TabStop = true;
			this.rbtEmergencial.Text = "Emergencial";
			this.rbtEmergencial.UseVisualStyleBackColor = true;
			this.rbtEmergencial.CheckedChanged += new System.EventHandler(this.RbtEmergencial_CheckedChanged);
			// 
			// btnAgendar
			// 
			this.btnAgendar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnAgendar.FlatAppearance.BorderSize = 0;
			this.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnAgendar.ForeColor = System.Drawing.Color.Green;
			this.btnAgendar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnAgendar.Location = new System.Drawing.Point(667, 392);
			this.btnAgendar.Name = "btnAgendar";
			this.btnAgendar.Size = new System.Drawing.Size(75, 23);
			this.btnAgendar.TabIndex = 67;
			this.btnAgendar.Text = "Agendar";
			this.btnAgendar.UseVisualStyleBackColor = false;
			this.btnAgendar.Click += new System.EventHandler(this.BtnAgendar_Click);
			// 
			// rbtRetorno
			// 
			this.rbtRetorno.AutoSize = true;
			this.rbtRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtRetorno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.rbtRetorno.Location = new System.Drawing.Point(371, 245);
			this.rbtRetorno.Name = "rbtRetorno";
			this.rbtRetorno.Size = new System.Drawing.Size(63, 17);
			this.rbtRetorno.TabIndex = 66;
			this.rbtRetorno.TabStop = true;
			this.rbtRetorno.Text = "Retorno";
			this.rbtRetorno.UseVisualStyleBackColor = true;
			this.rbtRetorno.CheckedChanged += new System.EventHandler(this.RbtRetorno_CheckedChanged);
			// 
			// rbtConsulta
			// 
			this.rbtConsulta.AutoSize = true;
			this.rbtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtConsulta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.rbtConsulta.Location = new System.Drawing.Point(216, 245);
			this.rbtConsulta.Name = "rbtConsulta";
			this.rbtConsulta.Size = new System.Drawing.Size(66, 17);
			this.rbtConsulta.TabIndex = 65;
			this.rbtConsulta.TabStop = true;
			this.rbtConsulta.Text = "Consulta";
			this.rbtConsulta.UseVisualStyleBackColor = true;
			this.rbtConsulta.CheckedChanged += new System.EventHandler(this.RbtConsulta_CheckedChanged);
			// 
			// mtbCPF
			// 
			this.mtbCPF.Location = new System.Drawing.Point(64, 243);
			this.mtbCPF.Mask = "000.000.000-00";
			this.mtbCPF.Name = "mtbCPF";
			this.mtbCPF.Size = new System.Drawing.Size(116, 21);
			this.mtbCPF.TabIndex = 63;
			this.mtbCPF.Click += new System.EventHandler(this.MtbCPF_Click);
			// 
			// lblCPF
			// 
			this.lblCPF.AutoSize = true;
			this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCPF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblCPF.Location = new System.Drawing.Point(31, 247);
			this.lblCPF.Name = "lblCPF";
			this.lblCPF.Size = new System.Drawing.Size(27, 13);
			this.lblCPF.TabIndex = 59;
			this.lblCPF.Text = "CPF";
			// 
			// lblManha
			// 
			this.lblManha.AutoSize = true;
			this.lblManha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.lblManha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblManha.Location = new System.Drawing.Point(13, 0);
			this.lblManha.Name = "lblManha";
			this.lblManha.Size = new System.Drawing.Size(56, 17);
			this.lblManha.TabIndex = 12;
			this.lblManha.Text = "Manhã";
			// 
			// rbtM8
			// 
			this.rbtM8.AutoSize = true;
			this.rbtM8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtM8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.rbtM8.Location = new System.Drawing.Point(16, 25);
			this.rbtM8.Name = "rbtM8";
			this.rbtM8.Size = new System.Drawing.Size(46, 17);
			this.rbtM8.TabIndex = 2;
			this.rbtM8.TabStop = true;
			this.rbtM8.Text = "8:00";
			this.rbtM8.UseVisualStyleBackColor = true;
			this.rbtM8.CheckedChanged += new System.EventHandler(this.RbtM8_CheckedChanged);
			// 
			// rbtM9
			// 
			this.rbtM9.AutoSize = true;
			this.rbtM9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtM9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.rbtM9.Location = new System.Drawing.Point(16, 52);
			this.rbtM9.Name = "rbtM9";
			this.rbtM9.Size = new System.Drawing.Size(46, 17);
			this.rbtM9.TabIndex = 3;
			this.rbtM9.TabStop = true;
			this.rbtM9.Text = "9:00";
			this.rbtM9.UseVisualStyleBackColor = true;
			this.rbtM9.CheckedChanged += new System.EventHandler(this.RbtM9_CheckedChanged);
			// 
			// rbtT18
			// 
			this.rbtT18.AutoSize = true;
			this.rbtT18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtT18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.rbtT18.Location = new System.Drawing.Point(256, 130);
			this.rbtT18.Name = "rbtT18";
			this.rbtT18.Size = new System.Drawing.Size(52, 17);
			this.rbtT18.TabIndex = 11;
			this.rbtT18.TabStop = true;
			this.rbtT18.Text = "18:00";
			this.rbtT18.UseVisualStyleBackColor = true;
			this.rbtT18.CheckedChanged += new System.EventHandler(this.RbtT18_CheckedChanged);
			// 
			// lblTarde
			// 
			this.lblTarde.AutoSize = true;
			this.lblTarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.lblTarde.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblTarde.Location = new System.Drawing.Point(253, 0);
			this.lblTarde.Name = "lblTarde";
			this.lblTarde.Size = new System.Drawing.Size(51, 17);
			this.lblTarde.TabIndex = 13;
			this.lblTarde.Text = "Tarde";
			// 
			// rbtT17
			// 
			this.rbtT17.AutoSize = true;
			this.rbtT17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtT17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.rbtT17.Location = new System.Drawing.Point(256, 104);
			this.rbtT17.Name = "rbtT17";
			this.rbtT17.Size = new System.Drawing.Size(52, 17);
			this.rbtT17.TabIndex = 10;
			this.rbtT17.TabStop = true;
			this.rbtT17.Text = "17:00";
			this.rbtT17.UseVisualStyleBackColor = true;
			this.rbtT17.CheckedChanged += new System.EventHandler(this.RbtT17_CheckedChanged);
			// 
			// gpbAgenda
			// 
			this.gpbAgenda.Controls.Add(this.gpbHorario);
			this.gpbAgenda.Controls.Add(this.lblMedico);
			this.gpbAgenda.Controls.Add(this.cbxMedico);
			this.gpbAgenda.Controls.Add(this.rbtEmergencial);
			this.gpbAgenda.Controls.Add(this.btnAgendar);
			this.gpbAgenda.Controls.Add(this.rbtRetorno);
			this.gpbAgenda.Controls.Add(this.rbtConsulta);
			this.gpbAgenda.Controls.Add(this.mtbCPF);
			this.gpbAgenda.Controls.Add(this.lblCPF);
			this.gpbAgenda.Controls.Add(this.mtcCalendario);
			this.gpbAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpbAgenda.Location = new System.Drawing.Point(10, 45);
			this.gpbAgenda.Name = "gpbAgenda";
			this.gpbAgenda.Size = new System.Drawing.Size(748, 421);
			this.gpbAgenda.TabIndex = 70;
			this.gpbAgenda.TabStop = false;
			this.gpbAgenda.Text = "Agendar Consulta";
			// 
			// gpbHorario
			// 
			this.gpbHorario.Controls.Add(this.txbT18);
			this.gpbHorario.Controls.Add(this.txbT17);
			this.gpbHorario.Controls.Add(this.lblManha);
			this.gpbHorario.Controls.Add(this.txbT16);
			this.gpbHorario.Controls.Add(this.rbtM8);
			this.gpbHorario.Controls.Add(this.txbT15);
			this.gpbHorario.Controls.Add(this.txbT14);
			this.gpbHorario.Controls.Add(this.rbtM9);
			this.gpbHorario.Controls.Add(this.rbtT18);
			this.gpbHorario.Controls.Add(this.lblTarde);
			this.gpbHorario.Controls.Add(this.rbtT17);
			this.gpbHorario.Controls.Add(this.txbM12);
			this.gpbHorario.Controls.Add(this.rbtT16);
			this.gpbHorario.Controls.Add(this.txbM9);
			this.gpbHorario.Controls.Add(this.rbtT15);
			this.gpbHorario.Controls.Add(this.txbM11);
			this.gpbHorario.Controls.Add(this.rbtM10);
			this.gpbHorario.Controls.Add(this.txbM10);
			this.gpbHorario.Controls.Add(this.rbtT14);
			this.gpbHorario.Controls.Add(this.rbtM11);
			this.gpbHorario.Controls.Add(this.rbtM12);
			this.gpbHorario.Controls.Add(this.txbM8);
			this.gpbHorario.Location = new System.Drawing.Point(238, 43);
			this.gpbHorario.Name = "gpbHorario";
			this.gpbHorario.Size = new System.Drawing.Size(504, 162);
			this.gpbHorario.TabIndex = 72;
			this.gpbHorario.TabStop = false;
			// 
			// txbT18
			// 
			this.txbT18.Location = new System.Drawing.Point(314, 130);
			this.txbT18.Name = "txbT18";
			this.txbT18.Size = new System.Drawing.Size(174, 21);
			this.txbT18.TabIndex = 23;
			// 
			// txbT17
			// 
			this.txbT17.Location = new System.Drawing.Point(314, 104);
			this.txbT17.Name = "txbT17";
			this.txbT17.Size = new System.Drawing.Size(174, 21);
			this.txbT17.TabIndex = 22;
			// 
			// txbT16
			// 
			this.txbT16.Location = new System.Drawing.Point(314, 78);
			this.txbT16.Name = "txbT16";
			this.txbT16.Size = new System.Drawing.Size(174, 21);
			this.txbT16.TabIndex = 21;
			// 
			// txbT15
			// 
			this.txbT15.Location = new System.Drawing.Point(314, 53);
			this.txbT15.Name = "txbT15";
			this.txbT15.Size = new System.Drawing.Size(174, 21);
			this.txbT15.TabIndex = 20;
			// 
			// txbT14
			// 
			this.txbT14.Location = new System.Drawing.Point(314, 24);
			this.txbT14.Name = "txbT14";
			this.txbT14.Size = new System.Drawing.Size(174, 21);
			this.txbT14.TabIndex = 19;
			// 
			// txbM12
			// 
			this.txbM12.Location = new System.Drawing.Point(68, 129);
			this.txbM12.Name = "txbM12";
			this.txbM12.Size = new System.Drawing.Size(174, 21);
			this.txbM12.TabIndex = 18;
			// 
			// rbtT16
			// 
			this.rbtT16.AutoSize = true;
			this.rbtT16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtT16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.rbtT16.Location = new System.Drawing.Point(256, 78);
			this.rbtT16.Name = "rbtT16";
			this.rbtT16.Size = new System.Drawing.Size(52, 17);
			this.rbtT16.TabIndex = 9;
			this.rbtT16.TabStop = true;
			this.rbtT16.Text = "16:00";
			this.rbtT16.UseVisualStyleBackColor = true;
			this.rbtT16.CheckedChanged += new System.EventHandler(this.RbtT16_CheckedChanged);
			// 
			// txbM9
			// 
			this.txbM9.Location = new System.Drawing.Point(68, 51);
			this.txbM9.Name = "txbM9";
			this.txbM9.Size = new System.Drawing.Size(174, 21);
			this.txbM9.TabIndex = 15;
			// 
			// rbtT15
			// 
			this.rbtT15.AutoSize = true;
			this.rbtT15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtT15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.rbtT15.Location = new System.Drawing.Point(256, 53);
			this.rbtT15.Name = "rbtT15";
			this.rbtT15.Size = new System.Drawing.Size(52, 17);
			this.rbtT15.TabIndex = 8;
			this.rbtT15.TabStop = true;
			this.rbtT15.Text = "15:00";
			this.rbtT15.UseVisualStyleBackColor = true;
			this.rbtT15.CheckedChanged += new System.EventHandler(this.RbtT15_CheckedChanged);
			// 
			// txbM11
			// 
			this.txbM11.Location = new System.Drawing.Point(68, 103);
			this.txbM11.Name = "txbM11";
			this.txbM11.Size = new System.Drawing.Size(174, 21);
			this.txbM11.TabIndex = 17;
			// 
			// rbtM10
			// 
			this.rbtM10.AutoSize = true;
			this.rbtM10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtM10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.rbtM10.Location = new System.Drawing.Point(16, 78);
			this.rbtM10.Name = "rbtM10";
			this.rbtM10.Size = new System.Drawing.Size(52, 17);
			this.rbtM10.TabIndex = 4;
			this.rbtM10.TabStop = true;
			this.rbtM10.Text = "10:00";
			this.rbtM10.UseVisualStyleBackColor = true;
			this.rbtM10.CheckedChanged += new System.EventHandler(this.RbtM10_CheckedChanged);
			// 
			// txbM10
			// 
			this.txbM10.Location = new System.Drawing.Point(68, 77);
			this.txbM10.Name = "txbM10";
			this.txbM10.Size = new System.Drawing.Size(174, 21);
			this.txbM10.TabIndex = 16;
			// 
			// rbtT14
			// 
			this.rbtT14.AutoSize = true;
			this.rbtT14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtT14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.rbtT14.Location = new System.Drawing.Point(256, 28);
			this.rbtT14.Name = "rbtT14";
			this.rbtT14.Size = new System.Drawing.Size(52, 17);
			this.rbtT14.TabIndex = 7;
			this.rbtT14.TabStop = true;
			this.rbtT14.Text = "14:00";
			this.rbtT14.UseVisualStyleBackColor = true;
			this.rbtT14.CheckedChanged += new System.EventHandler(this.RbtT14_CheckedChanged);
			// 
			// rbtM11
			// 
			this.rbtM11.AutoSize = true;
			this.rbtM11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtM11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.rbtM11.Location = new System.Drawing.Point(16, 104);
			this.rbtM11.Name = "rbtM11";
			this.rbtM11.Size = new System.Drawing.Size(52, 17);
			this.rbtM11.TabIndex = 5;
			this.rbtM11.TabStop = true;
			this.rbtM11.Text = "11:00";
			this.rbtM11.UseVisualStyleBackColor = true;
			this.rbtM11.CheckedChanged += new System.EventHandler(this.RbtM11_CheckedChanged);
			// 
			// rbtM12
			// 
			this.rbtM12.AutoSize = true;
			this.rbtM12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtM12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.rbtM12.Location = new System.Drawing.Point(16, 130);
			this.rbtM12.Name = "rbtM12";
			this.rbtM12.Size = new System.Drawing.Size(52, 17);
			this.rbtM12.TabIndex = 6;
			this.rbtM12.TabStop = true;
			this.rbtM12.Text = "12:00";
			this.rbtM12.UseVisualStyleBackColor = true;
			this.rbtM12.CheckedChanged += new System.EventHandler(this.RbtM12_CheckedChanged);
			// 
			// txbM8
			// 
			this.txbM8.Location = new System.Drawing.Point(68, 25);
			this.txbM8.Name = "txbM8";
			this.txbM8.Size = new System.Drawing.Size(174, 21);
			this.txbM8.TabIndex = 14;
			// 
			// lblMedico
			// 
			this.lblMedico.AutoSize = true;
			this.lblMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMedico.Location = new System.Drawing.Point(10, 281);
			this.lblMedico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblMedico.Name = "lblMedico";
			this.lblMedico.Size = new System.Drawing.Size(48, 15);
			this.lblMedico.TabIndex = 71;
			this.lblMedico.Text = "Médico";
			// 
			// cbxMedico
			// 
			this.cbxMedico.FormattingEnabled = true;
			this.cbxMedico.Items.AddRange(new object[] {
            "Consultório 1",
            "Consultório 2"});
			this.cbxMedico.Location = new System.Drawing.Point(64, 277);
			this.cbxMedico.Margin = new System.Windows.Forms.Padding(2);
			this.cbxMedico.Name = "cbxMedico";
			this.cbxMedico.Size = new System.Drawing.Size(94, 23);
			this.cbxMedico.TabIndex = 70;
			// 
			// mtcCalendario
			// 
			this.mtcCalendario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.mtcCalendario.Location = new System.Drawing.Point(12, 43);
			this.mtcCalendario.Name = "mtcCalendario";
			this.mtcCalendario.TabIndex = 0;
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(337, 22);
			this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(110, 18);
			this.lblTitulo.TabIndex = 755;
			this.lblTitulo.Text = "Agendamento";
			// 
			// frmAgenda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(767, 484);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.gpbAgenda);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmAgenda";
			this.Text = "agenda";
			this.gpbAgenda.ResumeLayout(false);
			this.gpbAgenda.PerformLayout();
			this.gpbHorario.ResumeLayout(false);
			this.gpbHorario.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.RadioButton rbtEmergencial;
        internal System.Windows.Forms.Button btnAgendar;
        internal System.Windows.Forms.RadioButton rbtRetorno;
        internal System.Windows.Forms.RadioButton rbtConsulta;
        internal System.Windows.Forms.MaskedTextBox mtbCPF;
        internal System.Windows.Forms.Label lblCPF;
        internal System.Windows.Forms.Label lblManha;
        internal System.Windows.Forms.RadioButton rbtM8;
        internal System.Windows.Forms.RadioButton rbtM9;
        internal System.Windows.Forms.RadioButton rbtT18;
        internal System.Windows.Forms.Label lblTarde;
        internal System.Windows.Forms.RadioButton rbtT17;
        internal System.Windows.Forms.GroupBox gpbAgenda;
        internal System.Windows.Forms.MonthCalendar mtcCalendario;
        internal System.Windows.Forms.RadioButton rbtT16;
        internal System.Windows.Forms.RadioButton rbtT15;
        internal System.Windows.Forms.RadioButton rbtM10;
        internal System.Windows.Forms.RadioButton rbtT14;
        internal System.Windows.Forms.RadioButton rbtM11;
        internal System.Windows.Forms.RadioButton rbtM12;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.ComboBox cbxMedico;
        private System.Windows.Forms.GroupBox gpbHorario;
        internal System.Windows.Forms.TextBox txbT18;
        internal System.Windows.Forms.TextBox txbT17;
        internal System.Windows.Forms.TextBox txbT16;
        internal System.Windows.Forms.TextBox txbT15;
        internal System.Windows.Forms.TextBox txbT14;
        internal System.Windows.Forms.TextBox txbM12;
        internal System.Windows.Forms.TextBox txbM9;
        internal System.Windows.Forms.TextBox txbM11;
        internal System.Windows.Forms.TextBox txbM10;
        internal System.Windows.Forms.TextBox txbM8;
    }
}