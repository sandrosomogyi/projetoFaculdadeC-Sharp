namespace Sistema_PIM.Apresentacao.Profissionais
{
    partial class frmEditarFuncionario
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.lblNaturalidade = new System.Windows.Forms.Label();
            this.txbNaturalidade = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblIdentificacao = new System.Windows.Forms.Label();
            this.gpbDesign1 = new System.Windows.Forms.GroupBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txbSobrenome = new System.Windows.Forms.TextBox();
            this.gpbDesign2 = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txbConfSenha = new System.Windows.Forms.TextBox();
            this.lblConfSenha = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txbFuncional = new System.Windows.Forms.TextBox();
            this.txbCoren = new System.Windows.Forms.TextBox();
            this.txbRA = new System.Windows.Forms.TextBox();
            this.lblFuncional = new System.Windows.Forms.Label();
            this.lblCoren = new System.Windows.Forms.Label();
            this.lblRA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Green;
            this.btnSalvar.Location = new System.Drawing.Point(666, 405);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 969;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.CustomFormat = "";
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataNascimento.Location = new System.Drawing.Point(9, 118);
            this.dtpDataNascimento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(116, 20);
            this.dtpDataNascimento.TabIndex = 956;
            this.dtpDataNascimento.Value = new System.DateTime(2000, 5, 18, 0, 0, 0, 0);
            // 
            // mtbCPF
            // 
            this.mtbCPF.Enabled = false;
            this.mtbCPF.Location = new System.Drawing.Point(338, 119);
            this.mtbCPF.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCPF.Mask = "000.000.000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(111, 20);
            this.mtbCPF.TabIndex = 959;
            this.mtbCPF.Click += new System.EventHandler(this.MtbCPF_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(335, 104);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(34, 13);
            this.lblCPF.TabIndex = 990;
            this.lblCPF.Text = "CPF *";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Divorciado(a)",
            "Viúvo(a)",
            "Separado(a)",
            "Amasiado(a)"});
            this.cbxEstado.Location = new System.Drawing.Point(129, 117);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(110, 21);
            this.cbxEstado.TabIndex = 957;
            // 
            // cbxSexo
            // 
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outros"});
            this.cbxSexo.Location = new System.Drawing.Point(243, 118);
            this.cbxSexo.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(91, 21);
            this.cbxSexo.TabIndex = 958;
            // 
            // lblNaturalidade
            // 
            this.lblNaturalidade.AutoSize = true;
            this.lblNaturalidade.Location = new System.Drawing.Point(450, 104);
            this.lblNaturalidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNaturalidade.Name = "lblNaturalidade";
            this.lblNaturalidade.Size = new System.Drawing.Size(67, 13);
            this.lblNaturalidade.TabIndex = 989;
            this.lblNaturalidade.Text = "Naturalidade";
            // 
            // txbNaturalidade
            // 
            this.txbNaturalidade.Location = new System.Drawing.Point(453, 119);
            this.txbNaturalidade.Margin = new System.Windows.Forms.Padding(2);
            this.txbNaturalidade.Name = "txbNaturalidade";
            this.txbNaturalidade.Size = new System.Drawing.Size(113, 20);
            this.txbNaturalidade.TabIndex = 960;
            this.txbNaturalidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbNaturalidade_KeyPress);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(6, 100);
            this.lblData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(104, 13);
            this.lblData.TabIndex = 986;
            this.lblData.Text = "Data de Nascimento";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(241, 102);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 987;
            this.lblSexo.Text = "Sexo";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(127, 100);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(62, 13);
            this.lblEstado.TabIndex = 988;
            this.lblEstado.Text = "Estado Civil";
            // 
            // lblIdentificacao
            // 
            this.lblIdentificacao.AutoSize = true;
            this.lblIdentificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacao.Location = new System.Drawing.Point(6, 37);
            this.lblIdentificacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdentificacao.Name = "lblIdentificacao";
            this.lblIdentificacao.Size = new System.Drawing.Size(100, 17);
            this.lblIdentificacao.TabIndex = 984;
            this.lblIdentificacao.Text = "Identificação";
            // 
            // gpbDesign1
            // 
            this.gpbDesign1.Location = new System.Drawing.Point(9, 44);
            this.gpbDesign1.Margin = new System.Windows.Forms.Padding(2);
            this.gpbDesign1.Name = "gpbDesign1";
            this.gpbDesign1.Padding = new System.Windows.Forms.Padding(2);
            this.gpbDesign1.Size = new System.Drawing.Size(736, 8);
            this.gpbDesign1.TabIndex = 985;
            this.gpbDesign1.TabStop = false;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(570, 118);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(173, 20);
            this.txbEmail.TabIndex = 961;
            this.txbEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbEmail_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(567, 100);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 982;
            this.lblEmail.Text = "Email *";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.Location = new System.Drawing.Point(6, 190);
            this.lblContato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(136, 17);
            this.lblContato.TabIndex = 981;
            this.lblContato.Text = "Dados Cadastrais";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 61);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 13);
            this.lblNome.TabIndex = 979;
            this.lblNome.Text = "Nome *";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(9, 78);
            this.txbNome.Margin = new System.Windows.Forms.Padding(2);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(326, 20);
            this.txbNome.TabIndex = 954;
            this.txbNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbNome_KeyPress);
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(336, 61);
            this.lblSobrenome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(68, 13);
            this.lblSobrenome.TabIndex = 980;
            this.lblSobrenome.Text = "Sobrenome *";
            // 
            // txbSobrenome
            // 
            this.txbSobrenome.Location = new System.Drawing.Point(338, 78);
            this.txbSobrenome.Margin = new System.Windows.Forms.Padding(2);
            this.txbSobrenome.Name = "txbSobrenome";
            this.txbSobrenome.Size = new System.Drawing.Size(405, 20);
            this.txbSobrenome.TabIndex = 955;
            this.txbSobrenome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbSobrenome_KeyPress);
            // 
            // gpbDesign2
            // 
            this.gpbDesign2.Location = new System.Drawing.Point(9, 197);
            this.gpbDesign2.Margin = new System.Windows.Forms.Padding(2);
            this.gpbDesign2.Name = "gpbDesign2";
            this.gpbDesign2.Padding = new System.Windows.Forms.Padding(2);
            this.gpbDesign2.Size = new System.Drawing.Size(733, 8);
            this.gpbDesign2.TabIndex = 983;
            this.gpbDesign2.TabStop = false;
            this.gpbDesign2.Text = "gpbDesign2";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(286, 17);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(155, 18);
            this.lblTitulo.TabIndex = 978;
            this.lblTitulo.Text = "Editar Funcionarios";
            // 
            // txbConfSenha
            // 
            this.txbConfSenha.Location = new System.Drawing.Point(416, 279);
            this.txbConfSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txbConfSenha.Name = "txbConfSenha";
            this.txbConfSenha.Size = new System.Drawing.Size(208, 20);
            this.txbConfSenha.TabIndex = 968;
            this.txbConfSenha.UseSystemPasswordChar = true;
            // 
            // lblConfSenha
            // 
            this.lblConfSenha.AutoSize = true;
            this.lblConfSenha.Location = new System.Drawing.Point(414, 262);
            this.lblConfSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfSenha.Name = "lblConfSenha";
            this.lblConfSenha.Size = new System.Drawing.Size(92, 13);
            this.lblConfSenha.TabIndex = 977;
            this.lblConfSenha.Text = "Confirmar Senha *";
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Coordenador",
            "Estudante",
            "Administrador"});
            this.cbxTipo.Location = new System.Drawing.Point(365, 229);
            this.cbxTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(135, 21);
            this.cbxTipo.TabIndex = 965;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 976;
            this.label1.Text = "Tipo *";
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(220, 279);
            this.txbSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(192, 20);
            this.txbSenha.TabIndex = 967;
            this.txbSenha.UseSystemPasswordChar = true;
            this.txbSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbSenha_KeyPress);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(217, 261);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(45, 13);
            this.lblSenha.TabIndex = 975;
            this.lblSenha.Text = "Senha *";
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(9, 279);
            this.txbLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(207, 20);
            this.txbLogin.TabIndex = 966;
            this.txbLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbLogin_KeyPress);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(6, 261);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(40, 13);
            this.lblLogin.TabIndex = 974;
            this.lblLogin.Text = "Login *";
            // 
            // txbFuncional
            // 
            this.txbFuncional.Location = new System.Drawing.Point(225, 230);
            this.txbFuncional.Margin = new System.Windows.Forms.Padding(2);
            this.txbFuncional.Name = "txbFuncional";
            this.txbFuncional.Size = new System.Drawing.Size(136, 20);
            this.txbFuncional.TabIndex = 964;
            this.txbFuncional.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbFuncional_KeyPress);
            // 
            // txbCoren
            // 
            this.txbCoren.Location = new System.Drawing.Point(109, 230);
            this.txbCoren.Margin = new System.Windows.Forms.Padding(2);
            this.txbCoren.Name = "txbCoren";
            this.txbCoren.Size = new System.Drawing.Size(112, 20);
            this.txbCoren.TabIndex = 963;
            this.txbCoren.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbCoren_KeyPress);
            // 
            // txbRA
            // 
            this.txbRA.Location = new System.Drawing.Point(9, 230);
            this.txbRA.Margin = new System.Windows.Forms.Padding(2);
            this.txbRA.Name = "txbRA";
            this.txbRA.Size = new System.Drawing.Size(96, 20);
            this.txbRA.TabIndex = 962;
            this.txbRA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbRA_KeyPress);
            // 
            // lblFuncional
            // 
            this.lblFuncional.AutoSize = true;
            this.lblFuncional.Location = new System.Drawing.Point(223, 213);
            this.lblFuncional.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFuncional.Name = "lblFuncional";
            this.lblFuncional.Size = new System.Drawing.Size(112, 13);
            this.lblFuncional.TabIndex = 973;
            this.lblFuncional.Text = "N° Funcional da UNIP";
            // 
            // lblCoren
            // 
            this.lblCoren.AutoSize = true;
            this.lblCoren.Location = new System.Drawing.Point(107, 213);
            this.lblCoren.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCoren.Name = "lblCoren";
            this.lblCoren.Size = new System.Drawing.Size(45, 13);
            this.lblCoren.TabIndex = 972;
            this.lblCoren.Text = "COREN";
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.Location = new System.Drawing.Point(6, 213);
            this.lblRA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(59, 13);
            this.lblRA.TabIndex = 971;
            this.lblRA.Text = "RA Aluno *";
            // 
            // frmEditarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 445);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.lblNaturalidade);
            this.Controls.Add(this.txbNaturalidade);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblIdentificacao);
            this.Controls.Add(this.gpbDesign1);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.txbSobrenome);
            this.Controls.Add(this.gpbDesign2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txbConfSenha);
            this.Controls.Add(this.lblConfSenha);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txbFuncional);
            this.Controls.Add(this.txbCoren);
            this.Controls.Add(this.txbRA);
            this.Controls.Add(this.lblFuncional);
            this.Controls.Add(this.lblCoren);
            this.Controls.Add(this.lblRA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarFuncionario";
            this.Text = "frmEditarFuncionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        internal System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.Label lblNaturalidade;
        private System.Windows.Forms.TextBox txbNaturalidade;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblIdentificacao;
        internal System.Windows.Forms.GroupBox gpbDesign1;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox txbSobrenome;
        internal System.Windows.Forms.GroupBox gpbDesign2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txbConfSenha;
        private System.Windows.Forms.Label lblConfSenha;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txbFuncional;
        private System.Windows.Forms.TextBox txbCoren;
        private System.Windows.Forms.TextBox txbRA;
        private System.Windows.Forms.Label lblFuncional;
        private System.Windows.Forms.Label lblCoren;
        private System.Windows.Forms.Label lblRA;
    }
}