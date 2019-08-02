using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PIM.Modelo.Login
{
    public class Controle : Modelo.absPropriedades
    {

        public bool Acessar (String login, String senha)
        {
            this.mensagem = "";
            Modelo.Estaticos.logado = false ; 

            DAL.Login.LoginComandos loginComandos = new DAL.Login.LoginComandos();
            Modelo.Estaticos.logado = loginComandos.verificarLogin(login, senha);

            if (!loginComandos.mensagem.Equals(""))
            {
                this.mensagem = loginComandos.mensagem;
            }
            return Modelo.Estaticos.logado;
        }
        public String nomeUsuario(String login, String senha)
        {
            DAL.Login.LoginComandos loginComandos = new DAL.Login.LoginComandos();
            Estaticos.nomeUsuario = loginComandos.nomeUsuario(login, senha);

            if (!loginComandos.mensagem.Equals(""))
            {
                this.mensagem = loginComandos.mensagem;
            }
            return Estaticos.nomeUsuario;
        }
        public String tipoLogin(String login, String senha)
        {
            DAL.Login.LoginComandos loginComandos = new DAL.Login.LoginComandos();
            Estaticos.tipoLogin = loginComandos.tipoLogin(login, senha);

            if (!loginComandos.mensagem.Equals(""))
            {
                this.mensagem = loginComandos.mensagem;
            }
            return Estaticos.tipoLogin;
        }

        public String idFuncionario (String login, String senha)
        {
            DAL.Login.LoginComandos loginComandos = new DAL.Login.LoginComandos();
            Estaticos.idFuncionario = loginComandos.idFuncionario(login, senha);

            if (!loginComandos.mensagem.Equals(""))
            {
                this.mensagem = loginComandos.mensagem;
            }
            return Estaticos.idFuncionario;
        }
    }
}
