using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_PIM.Apresentacao.Prontuario;

namespace Sistema_PIM.Apresentacao
{
    public partial class frmInicialProntuario : Form
    {
        public frmInicialProntuario()
        {
            InitializeComponent();
            frmCrianca frmC = new frmCrianca();
            frmC.TopLevel = false;
            frmC.Visible = true;
            pnlBranco.Controls.Add(frmC);
        }

        private void tsmCrianca_Click(object sender, EventArgs e)
        {
            pnlBranco.Controls.Clear();
            frmCrianca frmC = new frmCrianca();
            frmC.TopLevel = false;
            frmC.Visible = true;
            pnlBranco.Controls.Add(frmC);
        }

        private void tsmAdulto_Click(object sender, EventArgs e)
        {
            pnlBranco.Controls.Clear();
            frmAdulto frmAD = new frmAdulto();
            frmAD.TopLevel = false;
            frmAD.Visible = true;
            pnlBranco.Controls.Add(frmAD);
        }

        private void tsmGestante_Click(object sender, EventArgs e)
        {
            pnlBranco.Controls.Clear();
            frmGestante frmG = new frmGestante();
            frmG.TopLevel = false;
            frmG.Visible = true;
            pnlBranco.Controls.Add(frmG);
        }

        private void tsmAnamnese_Click(object sender, EventArgs e)
        {
            pnlBranco.Controls.Clear();
            frmAnamnese frmA = new frmAnamnese();
            frmA.TopLevel = false;
            frmA.Visible = true;
            pnlBranco.Controls.Add(frmA);
        }

        private void tsmHistorico_Click(object sender, EventArgs e)
        {
            pnlBranco.Controls.Clear();
        }
    }
}
