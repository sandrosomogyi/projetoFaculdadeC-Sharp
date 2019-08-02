using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_PIM.Apresentacao.Paciente
{
    public partial class frmEditarPacientes : Form
    {
        public frmEditarPacientes(Modelo.Paciente.PacienteCompleto pacienteCompleto)
        {
            InitializeComponent();
            txbNome.Text = pacienteCompleto.nome;
            txbSobrenome.Text = pacienteCompleto.sobrenome;
            dtpDataNascimento.Text = pacienteCompleto.dataNascimento;
            cbxEstado.Text = pacienteCompleto.estadoCivil;
            cbxSexo.Text = pacienteCompleto.sexo;
            mtbCPF.Text = pacienteCompleto.CPF;
            txbNaturalidade.Text = pacienteCompleto.naturalidade;
            txbEmail.Text = pacienteCompleto.email;

            txbMae.Text = pacienteCompleto.filiacaoMae;
            txbConjuge.Text = pacienteCompleto.conjuge;
            txbPai.Text = pacienteCompleto.filiacaoPai;
            txbProfissao.Text = pacienteCompleto.profissao;
            cbxEscolaridade.Text = pacienteCompleto.escolaridade;
            rtbObs.Text = pacienteCompleto.observacoes;

            txbCidade.Text = pacienteCompleto.cidade;
            mtbCEP.Text = pacienteCompleto.cep.ToString();
            txbRua.Text = pacienteCompleto.rua;
            txbComplemento.Text = pacienteCompleto.complemento;
            txbBairro.Text = pacienteCompleto.bairro;
            mtbNumero.Text = pacienteCompleto.numero.ToString();
            cbxUF.Text = pacienteCompleto.estado;

            mtbTelefone1.Text = pacienteCompleto.numero1;
            cbxTelefone1.Text = pacienteCompleto.tipo1;
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

        private void TxbRua_KeyPress(object sender, KeyPressEventArgs e)
        {
            txbRua.MaxLength = 100;
        }
        private void TxbComplemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            txbComplemento.MaxLength = 50;
        }

        private void TxbBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            txbBairro.MaxLength = 50;
        }

        private void TxbCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            txbCidade.MaxLength = 50;

            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void TxbMae_KeyPress(object sender, KeyPressEventArgs e)
        {
            txbMae.MaxLength = 50;

            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void TxbPai_KeyPress(object sender, KeyPressEventArgs e)
        {
            txbPai.MaxLength = 50;

            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void TxbConjuge_KeyPress(object sender, KeyPressEventArgs e)
        {
            txbConjuge.MaxLength = 50;

            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void TxbProfissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            txbProfissao.MaxLength = 40;

        }

        private void MtbCEP_Click(object sender, EventArgs e)
        {
            mtbCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (mtbCEP.Text.Equals(""))
                mtbCEP.SelectionStart = 0;
            mtbCEP.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        }

        private void MtbNumero_Click(object sender, EventArgs e)
        {
            mtbNumero.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (mtbNumero.Text.Equals(""))
                mtbNumero.SelectionStart = 0;
            mtbNumero.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        }

        private void MtbCPF_Click(object sender, EventArgs e)
        {
            mtbCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (mtbCPF.Text.Equals(""))
                mtbCPF.SelectionStart = 0;
            mtbCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        }

        private void MtbTelefone1_Click(object sender, EventArgs e)
        {
            mtbTelefone1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (mtbTelefone1.Text.Equals(""))
                mtbTelefone1.SelectionStart = 0;
            mtbTelefone1.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        }

        private void MtbTelefone2_Click(object sender, EventArgs e)
        {
            mtbTelefone2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (mtbTelefone2.Text.Equals(""))
                mtbTelefone2.SelectionStart = 0;
            mtbTelefone2.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbNome.Text) || string.IsNullOrWhiteSpace(txbSobrenome.Text)
                || string.IsNullOrWhiteSpace(mtbCPF.Text) || string.IsNullOrWhiteSpace(txbEmail.Text))
            {
                MessageBox.Show("Campos obrigatorios em branco, todos com * na frente", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                mtbCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mtbCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mtbNumero.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mtbTelefone1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mtbTelefone2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                if (mtbCEP.Text.Equals(""))
                    mtbCEP.Text = "0";

                if (mtbNumero.Text.Equals(""))
                    mtbNumero.Text = "0";


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

                List<String> dadosPaciente = new List<string>();
                dadosPaciente.Add(txbMae.Text);
                dadosPaciente.Add(txbConjuge.Text);
                dadosPaciente.Add(txbPai.Text);
                dadosPaciente.Add(txbProfissao.Text);
                dadosPaciente.Add(cbxEscolaridade.Text);
                dadosPaciente.Add(rtbObs.Text);

                List<String> dadosEndereco = new List<string>();
                dadosEndereco.Add(txbCidade.Text);
                dadosEndereco.Add(mtbCEP.Text);
                dadosEndereco.Add(txbRua.Text);
                dadosEndereco.Add(txbComplemento.Text);
                dadosEndereco.Add(txbBairro.Text);
                dadosEndereco.Add(mtbNumero.Text);
                dadosEndereco.Add(cbxUF.Text);

                List<String> dadosTelefone = new List<string>();
                dadosTelefone.Add(mtbTelefone1.Text);
                dadosTelefone.Add(cbxTelefone1.Text);
                dadosTelefone.Add(mtbTelefone2.Text);
                dadosTelefone.Add(cbxTelefone2.Text);

                if (mtbCEP.Text.Equals("0"))
                    mtbCEP.Text = "";
                if (mtbNumero.Text.Equals("0"))
                    mtbNumero.Text = "";

                mtbCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                mtbCEP.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                mtbNumero.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                mtbTelefone1.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                mtbTelefone2.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                Modelo.Paciente.Controle controle = new Modelo.Paciente.Controle();
                controle.EditarPaciente(dadosPessoais, dadosPaciente, dadosEndereco, dadosTelefone);
                MessageBox.Show(controle.mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
