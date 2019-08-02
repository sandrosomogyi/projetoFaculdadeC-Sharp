using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_PIM.Apresentacao.Prontuario
{
    public partial class frmAnamnese : Form
    {
        public frmAnamnese()
        {
            InitializeComponent();
        }

        private void RdbNaoAtividade_CheckedChanged(object sender, EventArgs e)
        {
            txbFrequenciaAtividade.Enabled = false;
            txbAtividadeFisica.Enabled = false;
        }

        private void RdbSimAtividade_CheckedChanged(object sender, EventArgs e)
        {
            txbFrequenciaAtividade.Enabled = true;
            txbAtividadeFisica.Enabled = true;
        }

        private void RdbNaoDrogas_CheckedChanged(object sender, EventArgs e)
        {
            txbUsoDrogas.Enabled = false;
            txbFrequenciaDrogas.Enabled = false;
        }

        private void RdbSimDrogas_CheckedChanged(object sender, EventArgs e)
        {
            txbUsoDrogas.Enabled = true;
            txbFrequenciaDrogas.Enabled = true;
        }

        private void RdbNaoPreventivo_CheckedChanged(object sender, EventArgs e)
        {
            dtpPreventivo.Enabled = false;
        }

        private void RdbSimPreventivo_CheckedChanged(object sender, EventArgs e)
        {
            dtpPreventivo.Enabled = true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {


        }
    }
}
