using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_PIM.Apresentacao.Cadastro;

namespace Sistema_PIM.Apresentacao.Agenda
{
    public partial class frmConsulta : Form
    {
        public frmConsulta()
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

            Modelo.Paciente.Controle controle = new Modelo.Paciente.Controle();
            Modelo.Pessoa pessoa = new Modelo.Pessoa();
            pessoa = controle.PesquisarPaciente(dadosPessoais);

            txbNome.Text = pessoa.nome;
            txbSobrenome.Text = pessoa.sobrenome;
            txbCPF.Text = pessoa.CPF;
            txbEmail.Text = pessoa.email;

            if (pessoa.CPF == "0")
                MessageBox.Show("Não existe nenhum paciente com este CPF ou CPF incorreto.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                Modelo.Paciente.PacienteCompleto pacienteCompleto = new Modelo.Paciente.PacienteCompleto();
                Modelo.Paciente.Controle controle = new Modelo.Paciente.Controle();
                pacienteCompleto = controle.PreencherCampos(dadosPessoais);

                pnlPrincipal.Controls.Clear();
                Paciente.frmEditarPacientes cadastro = new Paciente.frmEditarPacientes(pacienteCompleto);
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

                Modelo.Paciente.Controle controle = new Modelo.Paciente.Controle();
                DialogResult opcao = new DialogResult();
                opcao = MessageBox.Show("Tem certeza disto ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opcao.Equals(DialogResult.Yes))
                {
                    controle.ExcluirPaciente(dadosPessoais);
                    if (controle.mensagem.Equals(""))
                    {
                        MessageBox.Show("Paciente excluido com Sucesso !", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            frmPessoais cadastro = new frmPessoais();
            cadastro.TopLevel = false;
            cadastro.Visible = true;
            pnlPrincipal.Controls.Add(cadastro);
        }
    }
}
