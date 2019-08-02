using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_PIM.Apresentacao.Profissionais
{
    public partial class frmEditarFuncionario : Form
    {
        public frmEditarFuncionario(Modelo.Funcionario.FuncionarioCompleto funcionarioCompleto)
        {
            InitializeComponent();
            txbNome.Text = funcionarioCompleto.nome;
            txbSobrenome.Text = funcionarioCompleto.sobrenome;
            dtpDataNascimento.Text = funcionarioCompleto.dataNascimento;
            cbxEstado.Text = funcionarioCompleto.estadoCivil;
            cbxSexo.Text = funcionarioCompleto.sexo;
            mtbCPF.Text = funcionarioCompleto.CPF;
            txbNaturalidade.Text = funcionarioCompleto.naturalidade;
            txbEmail.Text = funcionarioCompleto.email;

            cbxTipo.Text = funcionarioCompleto.tipo;
            txbRA.Text = funcionarioCompleto.RA;
            txbLogin.Text = funcionarioCompleto.login;
            txbCoren.Text = funcionarioCompleto.coren;
            txbFuncional.Text = funcionarioCompleto.funcional;
        }

        private void TxbNome_KeyPress(object sender, KeyPressEventArgs e)
        {

            ///Limitador de caracteres

            txbNome.MaxLength = 30;

            ///Bloqueador de numeros com funcionamento do backspace e espaço

            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }

        }

        private void TxbSobrenome_KeyPress(object sender, KeyPressEventArgs e)
        {
            txbSobrenome.MaxLength = 50;

            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void TxbNaturalidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            txbNaturalidade.MaxLength = 40;

            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void TxbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            txbEmail.MaxLength = 100;

            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void MtbCPF_Click(object sender, EventArgs e)
        {
            mtbCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (mtbCPF.Text.Equals(""))
                mtbCPF.SelectionStart = 0;
            mtbCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        }

        private void TxbRA_KeyPress(object sender, KeyPressEventArgs e)
        {
            txbRA.MaxLength = 7;
        }

        private void TxbCoren_KeyPress(object sender, KeyPressEventArgs e)
        {
            txbCoren.MaxLength = 11;
        }

        private void TxbFuncional_KeyPress(object sender, KeyPressEventArgs e)
        {
            txbFuncional.MaxLength = 11;
        }

        private void TxbLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            txbLogin.MaxLength = 20;
        }

        private void TxbSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            txbSenha.MaxLength = 100;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbNome.Text) || string.IsNullOrWhiteSpace(txbSobrenome.Text)
                || string.IsNullOrWhiteSpace(mtbCPF.Text) || string.IsNullOrWhiteSpace(txbEmail.Text)
                || string.IsNullOrWhiteSpace(txbRA.Text) || string.IsNullOrWhiteSpace(cbxTipo.Text)
                || string.IsNullOrWhiteSpace(txbLogin.Text) || string.IsNullOrWhiteSpace(txbSenha.Text)
                || string.IsNullOrWhiteSpace(txbConfSenha.Text))
            {
                MessageBox.Show("Campos obrigatorios em branco, todos com * na frente", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                mtbCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                List<String> dadosPessoais = new List<string>();
                dadosPessoais.Add("0");
                dadosPessoais.Add(txbNome.Text);
                dadosPessoais.Add(txbSobrenome.Text);
                dadosPessoais.Add(txbNaturalidade.Text);
                dadosPessoais.Add(mtbCPF.Text);
                dadosPessoais.Add(txbEmail.Text);
                dadosPessoais.Add(cbxSexo.Text);
                dadosPessoais.Add(cbxEstado.Text);
                dadosPessoais.Add(dtpDataNascimento.Value.ToString("yyyyMMdd"));

                List<String> dadosFuncionario = new List<string>();
                dadosFuncionario.Add(txbSenha.Text);
                dadosFuncionario.Add(txbConfSenha.Text);
                dadosFuncionario.Add(cbxTipo.Text);
                dadosFuncionario.Add(txbRA.Text);
                dadosFuncionario.Add(txbLogin.Text);
                dadosFuncionario.Add(txbCoren.Text);
                dadosFuncionario.Add(txbFuncional.Text);

                mtbCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                Modelo.Funcionario.Controle controle = new Modelo.Funcionario.Controle();
                controle.EditarFuncionario(dadosPessoais, dadosFuncionario);
                MessageBox.Show(controle.mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
