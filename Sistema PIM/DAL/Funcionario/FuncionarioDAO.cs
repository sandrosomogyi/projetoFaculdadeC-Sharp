using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_PIM.Modelo;
using Sistema_PIM.Modelo.Funcionario;

namespace Sistema_PIM.DAL.Funcionario
{
    public class FuncionarioDAO : intFuncionarioDAO
    {
        public String mensagem;
        public String id;
        public bool existeCPF;
        public bool existeLogin;
        SqlDataReader dataReader;
        Conexao conexaoBD = new Conexao();

        public void CadastrarFuncionario(Pessoa pessoa, Modelo.Funcionario.Funcionario funcionario)
        {

            SqlCommand cmd = new SqlCommand();
            this.mensagem = "";

            cmd.CommandText = @"insert into Pessoa (nome, sobrenome, naturalidade, CPF, email, sexo, estadoCivil, dataNascimento) 
                                values (@nome, @sobrenome, @naturalidade, @CPF, @email, @sexo, @estadoCivil, @dataNascimento)";

            cmd.Parameters.AddWithValue("@nome", pessoa.nome);
            cmd.Parameters.AddWithValue("@sobrenome", pessoa.sobrenome);
            cmd.Parameters.AddWithValue("@naturalidade", pessoa.naturalidade);
            cmd.Parameters.AddWithValue("@CPF", pessoa.CPF);
            cmd.Parameters.AddWithValue("@email", pessoa.email);
            cmd.Parameters.AddWithValue("@sexo", pessoa.sexo);
            cmd.Parameters.AddWithValue("@estadoCivil", pessoa.estadoCivil);
            cmd.Parameters.AddWithValue("@dataNascimento", pessoa.dataNascimento);

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();

                cmd.CommandText = @"declare @idPessoa int;
                                set @idPessoa = (select max(idPessoa) as fk_idPessoa_Pessoa from Pessoa);
                                insert into Funcionario (senha, tipo, RA, login, coren, funcional, fk_idPessoa_Pessoa)
                                values (@senha, @tipo, @RA, @login, @coren, @funcional, @idPessoa)";

                cmd.Parameters.AddWithValue("@senha", funcionario.senha);
                cmd.Parameters.AddWithValue("@tipo", funcionario.tipo);
                cmd.Parameters.AddWithValue("@RA", funcionario.RA);
                cmd.Parameters.AddWithValue("@login", funcionario.login);
                cmd.Parameters.AddWithValue("@coren", funcionario.coren);
                cmd.Parameters.AddWithValue("@funcional", funcionario.funcional);

                try
                {
                    cmd.Connection = conexaoBD.Conectar();
                    cmd.ExecuteNonQuery();
                    conexaoBD.Desconectar();

                    this.mensagem = "Cadastrado com sucesso";
                }
                catch (SqlException ex)
                {
                    this.mensagem = "Erro no Banco de Dados " + ex.Message.ToString();
                }
            }
            catch (SqlException ex)
            {
                this.mensagem = "Erro no Banco de Dados " + ex.Message.ToString();
            }
        }

        public void EditarFuncionario(Pessoa pessoa, Modelo.Funcionario.Funcionario funcionario)
        {
            SqlCommand cmd = new SqlCommand();
            this.mensagem = "";

            cmd.CommandText = @"select idPessoa from Pessoa where CPF = @cpf";

            cmd.Parameters.AddWithValue("@cpf", pessoa.CPF);

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                id = Convert.ToString(cmd.ExecuteScalar());
                conexaoBD.Desconectar();

                cmd.CommandText = @"update Pessoa set nome = @nome, sobrenome = @sobrenome, naturalidade = @naturalidade,
                                email = @email, sexo = @sexo, estadoCivil = @estadoCivil, dataNascimento =  @dataNascimento
                                where idPessoa = @idPessoa
                                
                                update Funcionario set senha = @senha, tipo = @tipo, RA = @RA,
                                login = @login, coren = @coren, funcional = @funcional
                                where fk_idPessoa_Pessoa = @idPessoa";

                cmd.Parameters.AddWithValue("@idPessoa", id);

                cmd.Parameters.AddWithValue("@nome", pessoa.nome);
                cmd.Parameters.AddWithValue("@sobrenome", pessoa.sobrenome);
                cmd.Parameters.AddWithValue("@naturalidade", pessoa.naturalidade);
                cmd.Parameters.AddWithValue("@email", pessoa.email);
                cmd.Parameters.AddWithValue("@sexo", pessoa.sexo);
                cmd.Parameters.AddWithValue("@estadoCivil", pessoa.estadoCivil);
                cmd.Parameters.AddWithValue("@dataNascimento", pessoa.dataNascimento);

                cmd.Parameters.AddWithValue("@senha", funcionario.senha);
                cmd.Parameters.AddWithValue("@tipo", funcionario.tipo);
                cmd.Parameters.AddWithValue("@RA", funcionario.RA);
                cmd.Parameters.AddWithValue("@login", funcionario.login);
                cmd.Parameters.AddWithValue("@coren", funcionario.coren);
                cmd.Parameters.AddWithValue("@funcional", funcionario.funcional);

                try
                {
                    cmd.Connection = conexaoBD.Conectar();
                    cmd.ExecuteNonQuery();
                    conexaoBD.Desconectar();

                    this.mensagem = "Editado com sucesso";
                }
                catch (SqlException ex)
                {
                    this.mensagem = "Erro no Banco de Dados " + ex.Message.ToString();
                }
            }
            catch (SqlException ex)
            {
                this.mensagem = "Erro no Banco de Dados " + ex.Message.ToString();
            }
        }

        public void ExcluirFucnionario(Pessoa pessoa)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"declare @id int
                                set @id = (select max (idPessoa) from Pessoa where CPF = @CPF)
                                delete Funcionario where fk_idPessoa_Pessoa = @id
                                delete Pessoa where idPessoa = @id";
            cmd.Parameters.AddWithValue("@CPF", pessoa.CPF);

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro no Banco de Dados " + e.Message.ToString();
            }
        }

        public Pessoa PesquisarFuncionario(Pessoa pessoa)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from Pessoa where CPF = @CPF";
            cmd.Parameters.AddWithValue("@CPF", pessoa.CPF);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    pessoa.nome = dataReader["nome"].ToString();
                    pessoa.sobrenome = dataReader["sobrenome"].ToString();
                    pessoa.CPF = dataReader["CPF"].ToString();
                    pessoa.email = dataReader["email"].ToString();
                }
                else
                {
                    pessoa.CPF = "0";
                }
                dataReader.Close();
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro no Banco de Dados " + e.Message.ToString();
            }
            return pessoa;
        }

        public FuncionarioCompleto PreencherCampos(Pessoa pessoa)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            FuncionarioCompleto funcionarioCompleto = new FuncionarioCompleto();

            cmd.CommandText = @"select idPessoa from Pessoa where CPF = @cpf";

            cmd.Parameters.AddWithValue("@cpf", pessoa.CPF);

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                id = Convert.ToString(cmd.ExecuteScalar());
                conexaoBD.Desconectar();

                cmd.CommandText = @"select * from Pessoa, Funcionario where idPessoa = @idPessoa and fk_idPessoa_Pessoa = @idPessoa";

                cmd.Parameters.AddWithValue("@idPessoa", id);

                try
                {
                    cmd.Connection = conexaoBD.Conectar();
                    dataReader = cmd.ExecuteReader();

                    dataReader.Read();
                    funcionarioCompleto.nome = dataReader["nome"].ToString();
                    funcionarioCompleto.sobrenome = dataReader["sobrenome"].ToString();
                    funcionarioCompleto.naturalidade = dataReader["naturalidade"].ToString();
                    funcionarioCompleto.CPF = dataReader["CPF"].ToString();
                    funcionarioCompleto.email = dataReader["email"].ToString();
                    funcionarioCompleto.sexo = dataReader["sexo"].ToString();
                    funcionarioCompleto.estadoCivil = dataReader["estadoCivil"].ToString();
                    funcionarioCompleto.dataNascimento = dataReader["dataNascimento"].ToString();

                    funcionarioCompleto.senha = dataReader["senha"].ToString();
                    funcionarioCompleto.tipo = dataReader["tipo"].ToString();
                    funcionarioCompleto.RA = dataReader["RA"].ToString();
                    funcionarioCompleto.login = dataReader["login"].ToString();
                    funcionarioCompleto.coren = dataReader["coren"].ToString();
                    funcionarioCompleto.funcional = dataReader["funcional"].ToString();

                    dataReader.Close();
                    conexaoBD.Desconectar();
                }
                catch (SqlException e)
                {

                    this.mensagem = "Erro no Banco de Dados " + e.Message.ToString();
                }
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro no Banco de Dados " + e.Message.ToString();
            }

            return funcionarioCompleto;
        }
        public bool VerificarCPF(Pessoa pessoa)
        {
            SqlCommand cmd = new SqlCommand();
            this.mensagem = "";
            this.existeCPF = false;

            cmd.CommandText = @"select * from Pessoa where CPF = @cpf";

            cmd.Parameters.AddWithValue("@cpf", pessoa.CPF);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    existeCPF = dataReader.HasRows;
                    this.mensagem = "CPF já resgistrado";
                }

                dataReader.Close();
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro no Banco de Dados " + e.Message.ToString();
            }

            return existeCPF;
        }

        public bool VerificarLogin(Modelo.Funcionario.Funcionario funcionario)
        {
            SqlCommand cmd = new SqlCommand();
            this.mensagem = "";
            this.existeLogin = false;

            cmd.CommandText = @"select * from Funcionario where login = @login";

            cmd.Parameters.AddWithValue("@login", funcionario.login);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    existeLogin = dataReader.HasRows;
                    this.mensagem = "Login já resgistrado";
                }

                dataReader.Close();
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro no Banco de Dados " + e.Message.ToString();
            }

            return existeLogin;
        }
    }
    }