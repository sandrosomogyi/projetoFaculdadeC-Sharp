namespace Sistema_PIM.Apresentacao.Cadastro
{
    partial class frmPessoais
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cbxUF = new System.Windows.Forms.ComboBox();
            this.lblIdentificacao = new System.Windows.Forms.Label();
            this.gpbDesign1 = new System.Windows.Forms.GroupBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.mtbTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.txbProfissao = new System.Windows.Forms.TextBox();
            this.lblProfissao = new System.Windows.Forms.Label();
            this.txbConjuge = new System.Windows.Forms.TextBox();
            this.lblConjuge = new System.Windows.Forms.Label();
            this.txbPai = new System.Windows.Forms.TextBox();
            this.lblPai = new System.Windows.Forms.Label();
            this.txbMae = new System.Windows.Forms.TextBox();
            this.lblMae = new System.Windows.Forms.Label();
            this.lblOutras = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone2 = new System.Windows.Forms.Label();
            this.lblTelefone1 = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.rtbObs = new System.Windows.Forms.RichTextBox();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.txbRua = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txbSobrenome = new System.Windows.Forms.TextBox();
            this.gpbDesign2 = new System.Windows.Forms.GroupBox();
            this.gpbDesign3 = new System.Windows.Forms.GroupBox();
            this.cbxTelefone1 = new System.Windows.Forms.ComboBox();
            this.cbxTelefone2 = new System.Windows.Forms.ComboBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.lblNaturalidade = new System.Windows.Forms.Label();
            this.txbNaturalidade = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbxEscolaridade = new System.Windows.Forms.ComboBox();
            this.lblEscolaridade = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txbComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.mtbNumero = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(290, 7);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(179, 18);
            this.lblTitulo.TabIndex = 754;
            this.lblTitulo.Text = "Cadastro de Pacientes";
            // 
            // cbxUF
            // 
            this.cbxUF.FormattingEnabled = true;
            this.cbxUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxUF.Location = new System.Drawing.Point(349, 222);
            this.cbxUF.Margin = new System.Windows.Forms.Padding(2);
            this.cbxUF.Name = "cbxUF";
            this.cbxUF.Size = new System.Drawing.Size(41, 21);
            this.cbxUF.TabIndex = 14;
            // 
            // lblIdentificacao
            // 
            this.lblIdentificacao.AutoSize = true;
            this.lblIdentificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacao.Location = new System.Drawing.Point(10, 27);
            this.lblIdentificacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdentificacao.Name = "lblIdentificacao";
            this.lblIdentificacao.Size = new System.Drawing.Size(100, 17);
            this.lblIdentificacao.TabIndex = 902;
            this.lblIdentificacao.Text = "Identificação";
            // 
            // gpbDesign1
            // 
            this.gpbDesign1.Location = new System.Drawing.Point(13, 34);
            this.gpbDesign1.Margin = new System.Windows.Forms.Padding(2);
            this.gpbDesign1.Name = "gpbDesign1";
            this.gpbDesign1.Padding = new System.Windows.Forms.Padding(2);
            this.gpbDesign1.Size = new System.Drawing.Size(736, 8);
            this.gpbDesign1.TabIndex = 903;
            this.gpbDesign1.TabStop = false;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnNovo.Location = new System.Drawing.Point(13, 435);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 26;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Green;
            this.btnSalvar.Location = new System.Drawing.Point(671, 435);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // mtbTelefone2
            // 
            this.mtbTelefone2.Location = new System.Drawing.Point(571, 223);
            this.mtbTelefone2.Margin = new System.Windows.Forms.Padding(2);
            this.mtbTelefone2.Mask = "(00)00000-0000";
            this.mtbTelefone2.Name = "mtbTelefone2";
            this.mtbTelefone2.Size = new System.Drawing.Size(96, 20);
            this.mtbTelefone2.TabIndex = 17;
            this.mtbTelefone2.Click += new System.EventHandler(this.MtbTelefone2_Click);
            // 
            // mtbTelefone1
            // 
            this.mtbTelefone1.Location = new System.Drawing.Point(398, 222);
            this.mtbTelefone1.Margin = new System.Windows.Forms.Padding(2);
            this.mtbTelefone1.Mask = "(00)00000-0000";
            this.mtbTelefone1.Name = "mtbTelefone1";
            this.mtbTelefone1.Size = new System.Drawing.Size(86, 20);
            this.mtbTelefone1.TabIndex = 15;
            this.mtbTelefone1.Click += new System.EventHandler(this.MtbTelefone1_Click);
            // 
            // mtbCEP
            // 
            this.mtbCEP.Location = new System.Drawing.Point(13, 179);
            this.mtbCEP.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCEP.Mask = "00000-000";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(70, 20);
            this.mtbCEP.TabIndex = 8;
            this.mtbCEP.Click += new System.EventHandler(this.MtbCEP_Click);
            // 
            // txbProfissao
            // 
            this.txbProfissao.Location = new System.Drawing.Point(262, 329);
            this.txbProfissao.Margin = new System.Windows.Forms.Padding(2);
            this.txbProfissao.Name = "txbProfissao";
            this.txbProfissao.Size = new System.Drawing.Size(246, 20);
            this.txbProfissao.TabIndex = 22;
            this.txbProfissao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbProfissao_KeyPress);
            // 
            // lblProfissao
            // 
            this.lblProfissao.AutoSize = true;
            this.lblProfissao.Location = new System.Drawing.Point(260, 312);
            this.lblProfissao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfissao.Name = "lblProfissao";
            this.lblProfissao.Size = new System.Drawing.Size(50, 13);
            this.lblProfissao.TabIndex = 882;
            this.lblProfissao.Text = "Profissão";
            // 
            // txbConjuge
            // 
            this.txbConjuge.Location = new System.Drawing.Point(13, 328);
            this.txbConjuge.Margin = new System.Windows.Forms.Padding(2);
            this.txbConjuge.Name = "txbConjuge";
            this.txbConjuge.Size = new System.Drawing.Size(246, 20);
            this.txbConjuge.TabIndex = 21;
            this.txbConjuge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbConjuge_KeyPress);
            // 
            // lblConjuge
            // 
            this.lblConjuge.AutoSize = true;
            this.lblConjuge.Location = new System.Drawing.Point(10, 312);
            this.lblConjuge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConjuge.Name = "lblConjuge";
            this.lblConjuge.Size = new System.Drawing.Size(46, 13);
            this.lblConjuge.TabIndex = 880;
            this.lblConjuge.Text = "Cônjuge";
            // 
            // txbPai
            // 
            this.txbPai.Location = new System.Drawing.Point(262, 292);
            this.txbPai.Margin = new System.Windows.Forms.Padding(2);
            this.txbPai.Name = "txbPai";
            this.txbPai.Size = new System.Drawing.Size(246, 20);
            this.txbPai.TabIndex = 20;
            this.txbPai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbPai_KeyPress);
            // 
            // lblPai
            // 
            this.lblPai.AutoSize = true;
            this.lblPai.Location = new System.Drawing.Point(260, 275);
            this.lblPai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPai.Name = "lblPai";
            this.lblPai.Size = new System.Drawing.Size(67, 13);
            this.lblPai.TabIndex = 878;
            this.lblPai.Text = "Filiação : Pai";
            // 
            // txbMae
            // 
            this.txbMae.Location = new System.Drawing.Point(13, 292);
            this.txbMae.Margin = new System.Windows.Forms.Padding(2);
            this.txbMae.Name = "txbMae";
            this.txbMae.Size = new System.Drawing.Size(246, 20);
            this.txbMae.TabIndex = 19;
            this.txbMae.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbMae_KeyPress);
            // 
            // lblMae
            // 
            this.lblMae.AutoSize = true;
            this.lblMae.Location = new System.Drawing.Point(10, 275);
            this.lblMae.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMae.Name = "lblMae";
            this.lblMae.Size = new System.Drawing.Size(73, 13);
            this.lblMae.TabIndex = 876;
            this.lblMae.Text = "Filiação : Mãe";
            // 
            // lblOutras
            // 
            this.lblOutras.AutoSize = true;
            this.lblOutras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutras.Location = new System.Drawing.Point(10, 252);
            this.lblOutras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutras.Name = "lblOutras";
            this.lblOutras.Size = new System.Drawing.Size(150, 17);
            this.lblOutras.TabIndex = 875;
            this.lblOutras.Text = "Outras informações";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(574, 108);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(175, 20);
            this.txbEmail.TabIndex = 7;
            this.txbEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbEmail_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(571, 90);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 873;
            this.lblEmail.Text = "Email *";
            // 
            // lblTelefone2
            // 
            this.lblTelefone2.AutoSize = true;
            this.lblTelefone2.Location = new System.Drawing.Point(569, 205);
            this.lblTelefone2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefone2.Name = "lblTelefone2";
            this.lblTelefone2.Size = new System.Drawing.Size(58, 13);
            this.lblTelefone2.TabIndex = 872;
            this.lblTelefone2.Text = "Telefone 2";
            // 
            // lblTelefone1
            // 
            this.lblTelefone1.AutoSize = true;
            this.lblTelefone1.Location = new System.Drawing.Point(393, 205);
            this.lblTelefone1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefone1.Name = "lblTelefone1";
            this.lblTelefone1.Size = new System.Drawing.Size(58, 13);
            this.lblTelefone1.TabIndex = 871;
            this.lblTelefone1.Text = "Telefone 1";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.Location = new System.Drawing.Point(10, 138);
            this.lblContato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(151, 17);
            this.lblContato.TabIndex = 870;
            this.lblContato.Text = "Dados para contato";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(508, 275);
            this.lblObs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(70, 13);
            this.lblObs.TabIndex = 869;
            this.lblObs.Text = "Observações";
            // 
            // rtbObs
            // 
            this.rtbObs.Location = new System.Drawing.Point(511, 292);
            this.rtbObs.Margin = new System.Windows.Forms.Padding(2);
            this.rtbObs.Name = "rtbObs";
            this.rtbObs.Size = new System.Drawing.Size(238, 107);
            this.rtbObs.TabIndex = 24;
            this.rtbObs.Text = "";
            // 
            // txbCidade
            // 
            this.txbCidade.Location = new System.Drawing.Point(13, 222);
            this.txbCidade.Margin = new System.Windows.Forms.Padding(2);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(156, 20);
            this.txbCidade.TabIndex = 12;
            this.txbCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbCidade_KeyPress);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(10, 205);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 866;
            this.lblCidade.Text = "Cidade";
            // 
            // txbBairro
            // 
            this.txbBairro.Location = new System.Drawing.Point(173, 223);
            this.txbBairro.Margin = new System.Windows.Forms.Padding(2);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(172, 20);
            this.txbBairro.TabIndex = 13;
            this.txbBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbBairro_KeyPress);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(171, 205);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 864;
            this.lblBairro.Text = "Bairro";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(346, 205);
            this.lblUF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(21, 13);
            this.lblUF.TabIndex = 863;
            this.lblUF.Text = "UF";
            // 
            // txbRua
            // 
            this.txbRua.Location = new System.Drawing.Point(86, 179);
            this.txbRua.Margin = new System.Windows.Forms.Padding(2);
            this.txbRua.Name = "txbRua";
            this.txbRua.Size = new System.Drawing.Size(398, 20);
            this.txbRua.TabIndex = 9;
            this.txbRua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbRua_KeyPress);
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(84, 161);
            this.lblRua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(27, 13);
            this.lblRua.TabIndex = 861;
            this.lblRua.Text = "Rua";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(10, 51);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 13);
            this.lblNome.TabIndex = 848;
            this.lblNome.Text = "Nome *";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(13, 68);
            this.txbNome.Margin = new System.Windows.Forms.Padding(2);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(326, 20);
            this.txbNome.TabIndex = 0;
            this.txbNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbNome_KeyPress);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(10, 161);
            this.lblCep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(28, 13);
            this.lblCep.TabIndex = 860;
            this.lblCep.Text = "CEP";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(340, 51);
            this.lblSobrenome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(68, 13);
            this.lblSobrenome.TabIndex = 852;
            this.lblSobrenome.Text = "Sobrenome *";
            // 
            // txbSobrenome
            // 
            this.txbSobrenome.Location = new System.Drawing.Point(342, 68);
            this.txbSobrenome.Margin = new System.Windows.Forms.Padding(2);
            this.txbSobrenome.Name = "txbSobrenome";
            this.txbSobrenome.Size = new System.Drawing.Size(405, 20);
            this.txbSobrenome.TabIndex = 1;
            this.txbSobrenome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbSobrenome_KeyPress);
            // 
            // gpbDesign2
            // 
            this.gpbDesign2.Location = new System.Drawing.Point(13, 145);
            this.gpbDesign2.Margin = new System.Windows.Forms.Padding(2);
            this.gpbDesign2.Name = "gpbDesign2";
            this.gpbDesign2.Padding = new System.Windows.Forms.Padding(2);
            this.gpbDesign2.Size = new System.Drawing.Size(733, 8);
            this.gpbDesign2.TabIndex = 896;
            this.gpbDesign2.TabStop = false;
            this.gpbDesign2.Text = "gpbDesign2";
            // 
            // gpbDesign3
            // 
            this.gpbDesign3.Location = new System.Drawing.Point(13, 260);
            this.gpbDesign3.Margin = new System.Windows.Forms.Padding(2);
            this.gpbDesign3.Name = "gpbDesign3";
            this.gpbDesign3.Padding = new System.Windows.Forms.Padding(2);
            this.gpbDesign3.Size = new System.Drawing.Size(739, 10);
            this.gpbDesign3.TabIndex = 897;
            this.gpbDesign3.TabStop = false;
            this.gpbDesign3.Text = "gpbDesign3";
            // 
            // cbxTelefone1
            // 
            this.cbxTelefone1.FormattingEnabled = true;
            this.cbxTelefone1.Items.AddRange(new object[] {
            "Residencial",
            "Celular",
            "Empresarial"});
            this.cbxTelefone1.Location = new System.Drawing.Point(487, 221);
            this.cbxTelefone1.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTelefone1.Name = "cbxTelefone1";
            this.cbxTelefone1.Size = new System.Drawing.Size(80, 21);
            this.cbxTelefone1.TabIndex = 16;
            // 
            // cbxTelefone2
            // 
            this.cbxTelefone2.FormattingEnabled = true;
            this.cbxTelefone2.Items.AddRange(new object[] {
            "Residencial",
            "Celular",
            "Empresarial"});
            this.cbxTelefone2.Location = new System.Drawing.Point(671, 222);
            this.cbxTelefone2.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTelefone2.Name = "cbxTelefone2";
            this.cbxTelefone2.Size = new System.Drawing.Size(78, 21);
            this.cbxTelefone2.TabIndex = 18;
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(342, 109);
            this.mtbCPF.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCPF.Mask = "000.000.000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(111, 20);
            this.mtbCPF.TabIndex = 5;
            this.mtbCPF.Click += new System.EventHandler(this.MtbCPF_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(339, 94);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(34, 13);
            this.lblCPF.TabIndex = 921;
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
            this.cbxEstado.Location = new System.Drawing.Point(133, 107);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(110, 21);
            this.cbxEstado.TabIndex = 3;
            // 
            // cbxSexo
            // 
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outros"});
            this.cbxSexo.Location = new System.Drawing.Point(247, 108);
            this.cbxSexo.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(91, 21);
            this.cbxSexo.TabIndex = 4;
            // 
            // lblNaturalidade
            // 
            this.lblNaturalidade.AutoSize = true;
            this.lblNaturalidade.Location = new System.Drawing.Point(454, 94);
            this.lblNaturalidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNaturalidade.Name = "lblNaturalidade";
            this.lblNaturalidade.Size = new System.Drawing.Size(67, 13);
            this.lblNaturalidade.TabIndex = 917;
            this.lblNaturalidade.Text = "Naturalidade";
            // 
            // txbNaturalidade
            // 
            this.txbNaturalidade.Location = new System.Drawing.Point(457, 109);
            this.txbNaturalidade.Margin = new System.Windows.Forms.Padding(2);
            this.txbNaturalidade.Name = "txbNaturalidade";
            this.txbNaturalidade.Size = new System.Drawing.Size(113, 20);
            this.txbNaturalidade.TabIndex = 6;
            this.txbNaturalidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbNaturalidade_KeyPress);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(10, 90);
            this.lblData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(104, 13);
            this.lblData.TabIndex = 913;
            this.lblData.Text = "Data de Nascimento";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(245, 92);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 915;
            this.lblSexo.Text = "Sexo";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(131, 90);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(62, 13);
            this.lblEstado.TabIndex = 916;
            this.lblEstado.Text = "Estado Civil";
            // 
            // cbxEscolaridade
            // 
            this.cbxEscolaridade.FormattingEnabled = true;
            this.cbxEscolaridade.Items.AddRange(new object[] {
            "Superior incompleto",
            "Superior Completo",
            "Ensino Fundamental Incompleto",
            "Ensino Fundamental Completo",
            "Ensino Médio Incompleto",
            "Ensino Médio Completo",
            "Técnico"});
            this.cbxEscolaridade.Location = new System.Drawing.Point(13, 365);
            this.cbxEscolaridade.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEscolaridade.Name = "cbxEscolaridade";
            this.cbxEscolaridade.Size = new System.Drawing.Size(246, 21);
            this.cbxEscolaridade.TabIndex = 23;
            // 
            // lblEscolaridade
            // 
            this.lblEscolaridade.AutoSize = true;
            this.lblEscolaridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolaridade.Location = new System.Drawing.Point(10, 350);
            this.lblEscolaridade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEscolaridade.Name = "lblEscolaridade";
            this.lblEscolaridade.Size = new System.Drawing.Size(68, 13);
            this.lblEscolaridade.TabIndex = 923;
            this.lblEscolaridade.Text = "Escolaridade";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.CustomFormat = "";
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataNascimento.Location = new System.Drawing.Point(13, 108);
            this.dtpDataNascimento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(116, 20);
            this.dtpDataNascimento.TabIndex = 2;
            this.dtpDataNascimento.Value = new System.DateTime(2000, 5, 18, 0, 0, 0, 0);
            // 
            // txbComplemento
            // 
            this.txbComplemento.Location = new System.Drawing.Point(577, 179);
            this.txbComplemento.Margin = new System.Windows.Forms.Padding(2);
            this.txbComplemento.Name = "txbComplemento";
            this.txbComplemento.Size = new System.Drawing.Size(172, 20);
            this.txbComplemento.TabIndex = 11;
            this.txbComplemento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbComplemento_KeyPress);
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(575, 161);
            this.lblComplemento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 926;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(486, 161);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 928;
            this.lblNumero.Text = "Numero";
            // 
            // mtbNumero
            // 
            this.mtbNumero.Location = new System.Drawing.Point(488, 179);
            this.mtbNumero.Margin = new System.Windows.Forms.Padding(2);
            this.mtbNumero.Mask = "00000000000";
            this.mtbNumero.Name = "mtbNumero";
            this.mtbNumero.Size = new System.Drawing.Size(82, 20);
            this.mtbNumero.TabIndex = 10;
            this.mtbNumero.Click += new System.EventHandler(this.MtbNumero_Click);
            // 
            // frmPessoais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 484);
            this.Controls.Add(this.mtbNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txbComplemento);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.cbxEscolaridade);
            this.Controls.Add(this.lblEscolaridade);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.lblNaturalidade);
            this.Controls.Add(this.txbNaturalidade);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cbxTelefone2);
            this.Controls.Add(this.cbxTelefone1);
            this.Controls.Add(this.cbxUF);
            this.Controls.Add(this.lblIdentificacao);
            this.Controls.Add(this.gpbDesign1);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.mtbTelefone2);
            this.Controls.Add(this.mtbTelefone1);
            this.Controls.Add(this.mtbCEP);
            this.Controls.Add(this.txbProfissao);
            this.Controls.Add(this.lblProfissao);
            this.Controls.Add(this.txbConjuge);
            this.Controls.Add(this.lblConjuge);
            this.Controls.Add(this.txbPai);
            this.Controls.Add(this.lblPai);
            this.Controls.Add(this.txbMae);
            this.Controls.Add(this.lblMae);
            this.Controls.Add(this.lblOutras);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefone2);
            this.Controls.Add(this.lblTelefone1);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.rtbObs);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txbBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.txbRua);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.txbSobrenome);
            this.Controls.Add(this.gpbDesign2);
            this.Controls.Add(this.gpbDesign3);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPessoais";
            this.Text = "frmPessoais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cbxUF;
        private System.Windows.Forms.Label lblIdentificacao;
        internal System.Windows.Forms.GroupBox gpbDesign1;
        internal System.Windows.Forms.Button btnNovo;
        internal System.Windows.Forms.Button btnSalvar;
        internal System.Windows.Forms.MaskedTextBox mtbTelefone2;
        internal System.Windows.Forms.MaskedTextBox mtbTelefone1;
        internal System.Windows.Forms.MaskedTextBox mtbCEP;
        private System.Windows.Forms.TextBox txbProfissao;
        private System.Windows.Forms.Label lblProfissao;
        private System.Windows.Forms.TextBox txbConjuge;
        private System.Windows.Forms.Label lblConjuge;
        private System.Windows.Forms.TextBox txbPai;
        private System.Windows.Forms.Label lblPai;
        private System.Windows.Forms.TextBox txbMae;
        private System.Windows.Forms.Label lblMae;
        private System.Windows.Forms.Label lblOutras;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone2;
        private System.Windows.Forms.Label lblTelefone1;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.RichTextBox rtbObs;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.TextBox txbRua;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox txbSobrenome;
        internal System.Windows.Forms.GroupBox gpbDesign2;
        internal System.Windows.Forms.GroupBox gpbDesign3;
        private System.Windows.Forms.ComboBox cbxTelefone1;
        private System.Windows.Forms.ComboBox cbxTelefone2;
        internal System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.Label lblNaturalidade;
        private System.Windows.Forms.TextBox txbNaturalidade;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbxEscolaridade;
        private System.Windows.Forms.Label lblEscolaridade;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.TextBox txbComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblNumero;
        internal System.Windows.Forms.MaskedTextBox mtbNumero;
    }
}