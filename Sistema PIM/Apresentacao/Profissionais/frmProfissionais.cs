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
    public partial class frmProfissionais : Form
    {
        public frmProfissionais()
        {
            InitializeComponent();
        }
        private void MtbCPF_Click(object sender, EventArgs e)
        {
            mtbCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (mtbCPF.Text.Equals(""))
                mtbCPF.SelectionStart = 0;
            mtbCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            mtbCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            List<String> dadosPessoais = new List<string>();
            dadosPessoais.Add("0");
            dadosPessoais.Add("");
            dadosPessoais.Add("");
            dadosPessoais.Add("");
            dadosPessoais.Add(mtbCPF.Text);
            dadosPessoais.Add("");
            dadosPessoais.Add("");
            dadosPessoais.Add("");
            dadosPessoais.Add("");

            mtbCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            Modelo.Funcionario.Controle controle = new Modelo.Funcionario.Controle();
            Modelo.Pessoa pessoa = new Modelo.Pessoa();
            pessoa = controle.PesquisarFuncionario(dadosPessoais);

            txbNome.Text = pessoa.nome;
            txbSobrenome.Text = pessoa.sobrenome;
            txbCPF.Text = pessoa.CPF;
            txbEmail.Text = pessoa.email;

            if (pessoa.CPF == "0")
                MessageBox.Show("Não existe nenhum paciente com este CPF ou CPF incorreto.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void BtnAdiconar_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();

            frmCadastroFuncionario cadastro = new frmCadastroFuncionario();
            cadastro.TopLevel = false;
            cadastro.Visible = true;
            pnlPrincipal.Controls.Add(cadastro);

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            mtbCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (!mtbCPF.Text.Equals(""))
            {               

                List<String> dadosPessoais = new List<string>();
                dadosPessoais.Add("0");
                dadosPessoais.Add("");
                dadosPessoais.Add("");
                dadosPessoais.Add("");
                dadosPessoais.Add(mtbCPF.Text);
                dadosPessoais.Add("");
                dadosPessoais.Add("");
                dadosPessoais.Add("");
                dadosPessoais.Add("");

                mtbCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                Modelo.Funcionario.FuncionarioCompleto funcionarioCompleto = new Modelo.Funcionario.FuncionarioCompleto();
                Modelo.Funcionario.Controle controle = new Modelo.Funcionario.Controle();
                funcionarioCompleto = controle.PreencherCampos(dadosPessoais);

                pnlPrincipal.Controls.Clear();
                frmEditarFuncionario cadastro = new frmEditarFuncionario(funcionarioCompleto);
                cadastro.TopLevel = false;
                cadastro.Visible = true;
                pnlPrincipal.Controls.Add(cadastro);
            }
            mtbCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (!txbCPF.Text.Equals(""))
            {
                List<String> dadosPessoais = new List<string>();
                dadosPessoais.Add("0");
                dadosPessoais.Add("");
                dadosPessoais.Add("");
                dadosPessoais.Add("");
                dadosPessoais.Add(txbCPF.Text);
                dadosPessoais.Add("");
                dadosPessoais.Add("");
                dadosPessoais.Add("");
                dadosPessoais.Add("");

                Modelo.Funcionario.Controle controle = new Modelo.Funcionario.Controle();
                DialogResult opcao = new DialogResult();
                opcao = MessageBox.Show("Tem certeza disto ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opcao.Equals(DialogResult.Yes))
                {
                    controle.ExcluirFuncionario(dadosPessoais);
                    if (controle.mensagem.Equals(""))
                    {
                        MessageBox.Show("Funcionario excluido com Sucesso !", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txbNome.Text = "";
                        txbSobrenome.Text = "";
                        txbCPF.Text = "";
                        txbEmail.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(controle.mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
