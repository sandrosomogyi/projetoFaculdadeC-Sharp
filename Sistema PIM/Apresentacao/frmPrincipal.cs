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
using Sistema_PIM.Apresentacao;
using Sistema_PIM.Apresentacao.Prontuario;
using Sistema_PIM.Apresentacao.Cadastro;
using Sistema_PIM.Apresentacao.Profissionais;
using Sistema_PIM.Apresentacao.Encaminhamento;
using Sistema_PIM.Apresentacao.Agenda;

namespace Interface_PIM
{
    public partial class FrmPrincipal : Form
    {
        ///Definição de variaveis para a Função de Mover
        int X = 0;
        int Y = 0;

        public FrmPrincipal()
        {
            InitializeComponent();
            ///Iniciação da Função de Mover o Formulario
            pnlDesign2.MouseDown += new MouseEventHandler(frmPrincipal_MouseDown);
            pnlDesign2.MouseMove += new MouseEventHandler(frmPrincipal_MouseMove);
            ///Iniciador da tela de Login
            Apresentacao.frmLogin frmL = new Apresentacao.frmLogin();
            frmL.ShowDialog();
        }
        private void frmPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ///Função de mover o Formulario
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (!Estaticos.logado)
            {
                this.Close();
            }
            ///Puxador do tipo de usuario para o label
            lblUsuario.Text = Estaticos.nomeUsuario;
            lblTipoLogin.Text = Estaticos.tipoLogin;
        }

        private void btnConsultaDia_Click(object sender, EventArgs e)
        {
            pnlStats.Top = btnConsultaDia.Top;
            pnlStats.Height = btnConsultaDia.Height;

            pnlPrincipal.Controls.Clear();
            frmConsultaDia consultadia = new frmConsultaDia();
            consultadia.TopLevel = false;
            consultadia.Visible = true;
            pnlPrincipal.Controls.Add(consultadia);
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            ///Sinalizador de botão selecionado
            pnlStats.Top = btnAgenda.Top;
            pnlStats.Height = btnAgenda.Height;

            pnlPrincipal.Controls.Clear();
            Apresentacao.frmAgenda agendamento = new Apresentacao.frmAgenda();
            agendamento.TopLevel = false;
            agendamento.Visible = true;
            pnlPrincipal.Controls.Add(agendamento);

        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            pnlStats.Top = btnPaciente.Top;
            pnlStats.Height = btnPaciente.Height;

            pnlPrincipal.Controls.Clear();
            frmConsulta cadastro = new frmConsulta();
            cadastro.TopLevel = false;
            cadastro.Visible = true;
            pnlPrincipal.Controls.Add(cadastro);
        }

        private void btnProntuarios_Click(object sender, EventArgs e)
        {
            pnlStats.Top = btnProntuarios.Top;
            pnlStats.Height = btnProntuarios.Height;

            pnlPrincipal.Controls.Clear();
            frmInicialProntuario prontuario = new frmInicialProntuario();
            prontuario.TopLevel = false;
            prontuario.Visible = true;
            pnlPrincipal.Controls.Add(prontuario);

        }

        private void btnProfissionais_Click(object sender, EventArgs e)
        {
            pnlStats.Top = btnProfissionais.Top;
            pnlStats.Height = btnProfissionais.Height;

            pnlPrincipal.Controls.Clear();
            frmProfissionais prontuario = new frmProfissionais();
            prontuario.TopLevel = false;
            prontuario.Visible = true;
            pnlPrincipal.Controls.Add(prontuario);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult opcao = new DialogResult();
            opcao = MessageBox.Show("Tem certeza disto ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (opcao.Equals(DialogResult.Yes))
                this.Close();
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            ///Para trocar de usuario chamando a tela de Login
            Apresentacao.frmLogin frmL = new Apresentacao.frmLogin();
            frmL.ShowDialog();
            lblTipoLogin.Text = Estaticos.tipoLogin;
            lblUsuario.Text = Estaticos.nomeUsuario;
            pnlPrincipal.Controls.Clear();
            frmConsultaDia consultadia = new frmConsultaDia();
            consultadia.TopLevel = false;
            consultadia.Visible = true;
            pnlPrincipal.Controls.Add(consultadia);
            pnlStats.Top = btnConsultaDia.Top;
            pnlStats.Height = btnConsultaDia.Height;
        }
	}
}
