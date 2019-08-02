using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_PIM.Apresentacao.Encaminhamento;

namespace Sistema_PIM.Apresentacao
{
    public partial class frmInicialEncaminhamento : Form
    {
        public frmInicialEncaminhamento()
        {
            InitializeComponent();
            frmEncaminhamento frmEncaminha = new frmEncaminhamento();
            frmEncaminha.TopLevel = false;
            frmEncaminha.Visible = true;
            pnlMenuEnc.Controls.Add(frmEncaminha);
        }

        private void TsmEncaminhamento_Click(object sender, EventArgs e)
        {
            pnlMenuEnc.Controls.Clear();
            frmEncaminhamento frmEncaminha = new frmEncaminhamento();
            frmEncaminha.TopLevel = false;
            frmEncaminha.Visible = true;
            pnlMenuEnc.Controls.Add(frmEncaminha);
        }

        private void TsmPedidoExame_Click(object sender, EventArgs e)
        {
            pnlMenuEnc.Controls.Clear();
            frmPedidoExame frmPedido = new frmPedidoExame();
            frmPedido.TopLevel = false;
            frmPedido.Visible = true;
            pnlMenuEnc.Controls.Add(frmPedido);
        }
      
    }
}
