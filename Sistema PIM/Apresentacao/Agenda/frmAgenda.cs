using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_PIM.Apresentacao
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }
        public String dataSelecionada;
        public String horaSelecionada;
        public String tipo;

        private void MtbCPF_Click(object sender, EventArgs e)
        {
            mtbCPF.SelectionStart = 0;
        }

        private void RbtM8_CheckedChanged(object sender, EventArgs e)
        {
            horaSelecionada = " 08:00:00:000";
        }

        private void RbtM9_CheckedChanged(object sender, EventArgs e)
        {
            horaSelecionada = " 09:00:00:000";
        }

        private void RbtM10_CheckedChanged(object sender, EventArgs e)
        {
            horaSelecionada = " 10:00:00:000";
        }

        private void RbtM11_CheckedChanged(object sender, EventArgs e)
        {
            horaSelecionada = " 11:00:00:000";
        }

        private void RbtM12_CheckedChanged(object sender, EventArgs e)
        {
            horaSelecionada = " 12:00:00:000";
        }

        private void RbtT14_CheckedChanged(object sender, EventArgs e)
        {
            horaSelecionada = " 14:00:00:000";
        }

        private void RbtT15_CheckedChanged(object sender, EventArgs e)
        {
            horaSelecionada = " 15:00:00:000";
        }

        private void RbtT16_CheckedChanged(object sender, EventArgs e)
        {
            horaSelecionada = " 16:00:00:000";
        }

        private void RbtT17_CheckedChanged(object sender, EventArgs e)
        {
            horaSelecionada = " 17:00:00:000";
        }

        private void RbtT18_CheckedChanged(object sender, EventArgs e)
        {
            horaSelecionada = " 18:00:00:000";
        }

        private void RbtConsulta_CheckedChanged(object sender, EventArgs e)
        {
            tipo = rbtConsulta.Text;
        }

        private void RbtEmergencial_CheckedChanged(object sender, EventArgs e)
        {
            tipo = rbtEmergencial.Text;
        }

        private void RbtRetorno_CheckedChanged(object sender, EventArgs e)
        {
            tipo = rbtRetorno.Text;
        }

        private void BtnAgendar_Click(object sender, EventArgs e)
        {
            dataSelecionada = mtcCalendario.SelectionRange.Start.ToString("yyyyMMdd");

            mtbCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            List<String> dadosAgendamento = new List<string>();
            dadosAgendamento.Add(mtbCPF.Text);
            dadosAgendamento.Add(dataSelecionada + horaSelecionada);
            dadosAgendamento.Add(tipo);
            dadosAgendamento.Add(cbxMedico.Text);

            mtbCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            Sistema_PIM.Modelo.Agendamento.Controle controle = new Sistema_PIM.Modelo.Agendamento.Controle();
            controle.Agendar(dadosAgendamento);
            MessageBox.Show(controle.mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

    }
}
