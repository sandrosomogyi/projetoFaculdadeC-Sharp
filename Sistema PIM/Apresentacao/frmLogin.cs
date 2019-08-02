using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_PIM.Modelo;

namespace Interface_PIM.Apresentacao
{
    public partial class frmLogin : Form
    {
        int X = 0;
        int Y = 0;

        public frmLogin()
        {
            InitializeComponent();
            pnlDesign1.MouseDown += new MouseEventHandler(frmLogin_MouseDown);
            pnlDesign1.MouseMove += new MouseEventHandler(frmLogin_MouseMove);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Sistema_PIM.Modelo.Login.Controle controle = new Sistema_PIM.Modelo.Login.Controle();
            controle.Acessar(txbLogin.Text, txbSenha.Text);
            Estaticos.tipoLogin = "";
            Estaticos.nomeUsuario = "";

            if (controle.mensagem.Equals(""))
            {
                if (Estaticos.logado)
                {
                    Estaticos.nomeUsuario = controle.nomeUsuario(txbLogin.Text, txbSenha.Text);
                    Estaticos.tipoLogin = controle.tipoLogin(txbLogin.Text, txbSenha.Text);
                    Estaticos.idFuncionario = controle.idFuncionario(txbLogin.Text, txbSenha.Text);
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Login ou Senha inválidos", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void TxbLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void TxbSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void LlbEsqueceu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contate o administrador do sistema", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}