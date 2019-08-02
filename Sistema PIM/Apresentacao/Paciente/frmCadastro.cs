using Sistema_PIM.Apresentacao.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_PIM.Apresentacao
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void tsmCadastro(object sender, EventArgs e)
        {
            pnlCadastro.Controls.Clear();
            frmCadastro cadastrar = new frmCadastro();
            cadastrar.TopLevel = false;
            cadastrar.Visible = true;
            pnlCadastro.Controls.Add(cadastrar);
        }

        private void tsmPessoal_Click(object sender, EventArgs e)
        {
            pnlCadastro.Controls.Clear();
            frmPessoais dp = new frmPessoais();
            dp.TopLevel = false;
            dp.Visible = true;
            pnlCadastro.Controls.Add(dp);
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
