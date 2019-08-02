using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PIM.DAL.Login
{
    class LoginComandos : Modelo.absPropriedades
    {


        SqlCommand cmd = new SqlCommand();
        Conexao conexaoBD = new Conexao();
        public String idPessoa;

        public bool verificarLogin(String login, String senha)
        {
            this.mensagem = "";
            Modelo.Estaticos.logado = false;

            cmd.CommandText = @"select * from Funcionario where login = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Modelo.Estaticos.logado = true;
                }
                dr.Close();
            }
            catch (SqlException)
            {

                this.mensagem = "Erro com Banco de Dados";
            }

            return Modelo.Estaticos.logado;
        }
        public String nomeUsuario(String login, String senha)
        {
            this.mensagem = "";

            cmd.CommandText = @"select fk_idPessoa_Pessoa from Funcionario where login = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                idPessoa = Convert.ToString(cmd.ExecuteScalar());
                conexaoBD.Desconectar();

                    cmd.CommandText = @"select nome from Pessoa where idPessoa = @idPessoa";
                    cmd.Parameters.AddWithValue("@idPessoa", idPessoa);

                    try
                    {
                        cmd.Connection = conexaoBD.Conectar();
                        Modelo.Estaticos.nomeUsuario = Convert.ToString(cmd.ExecuteScalar());
                        conexaoBD.Desconectar();
                    }
                    catch (SqlException e)
                    {
                        this.mensagem = "Erro com Banco de Dados " + e;
                    }
                

            }
            catch (SqlException e)
            {

                this.mensagem = "Erro com Banco de Dados " + e;
            }

            return Modelo.Estaticos.nomeUsuario;
        }

        public String tipoLogin(String login, String senha)
        {
            this.mensagem = "";

            cmd.CommandText = @"select tipo from Funcionario where login = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                Modelo.Estaticos.tipoLogin = Convert.ToString(cmd.ExecuteScalar());               
                conexaoBD.Desconectar();

            }
            catch (SqlException e)
            {

                this.mensagem = "Erro com Banco de Dados" + e;
            }

            return Modelo.Estaticos.tipoLogin;
        }

        public String idFuncionario (String login, String senha)
        {
            this.mensagem = "";

            cmd.CommandText = @"select idFuncionario from Funcionario where login = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                Modelo.Estaticos.idFuncionario = Convert.ToString(cmd.ExecuteScalar());
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {

                this.mensagem = "Erro com Banco de Dados" + e;
            }

            return  Modelo.Estaticos.idFuncionario;
        }
    }
}
