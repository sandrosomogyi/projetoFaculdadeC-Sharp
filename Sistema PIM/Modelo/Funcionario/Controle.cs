using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PIM.Modelo.Funcionario
{
    public class Controle : absPropriedades
    {
        public void CadastrarFuncionario(List<String> dadosPessoais, List<String> dadosFuncionario)
        {
            this.mensagem = "";

            Validacao validacao = new Validacao();
            validacao.ValidarDadosFuncionario(dadosPessoais, dadosFuncionario);

            if (validacao.mensagem.Equals(""))
            {
                Pessoa pessoa = new Pessoa();
                pessoa.nome = dadosPessoais[1];
                pessoa.sobrenome = dadosPessoais[2];
                pessoa.naturalidade = dadosPessoais[3];
                pessoa.CPF = dadosPessoais[4];
                pessoa.email = dadosPessoais[5];
                pessoa.sexo = dadosPessoais[6];
                pessoa.estadoCivil = dadosPessoais[7];
                pessoa.dataNascimento = dadosPessoais[8];

                Funcionario funcionario = new Funcionario();
                funcionario.senha = dadosFuncionario[0];
                funcionario.tipo = dadosFuncionario[2];
                funcionario.RA = dadosFuncionario[3];
                funcionario.login = dadosFuncionario[4];
                funcionario.coren = dadosFuncionario[5];
                funcionario.funcional = dadosFuncionario[6];


                DAL.Funcionario.FuncionarioDAO funcionarioDAO = new DAL.Funcionario.FuncionarioDAO();
                existeCPF = funcionarioDAO.VerificarCPF(pessoa);
                if (existeCPF.Equals(false))
                {
                    existeLogin = funcionarioDAO.VerificarLogin(funcionario);
                    if (existeLogin.Equals(false))
                    {
                        funcionarioDAO.CadastrarFuncionario(pessoa, funcionario);
                        this.mensagem = funcionarioDAO.mensagem;
                    }
                    else
                    {
                        this.mensagem = funcionarioDAO.mensagem;
                    }
                }
                else
                {
                    this.mensagem = funcionarioDAO.mensagem;
                }
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public Pessoa PesquisarFuncionario(List<String> dadosPessoais)
        {
            this.mensagem = "";

            Pessoa pessoa = new Pessoa();
            pessoa.nome = dadosPessoais[1];
            pessoa.sobrenome = dadosPessoais[2];
            pessoa.naturalidade = dadosPessoais[3];
            pessoa.CPF = dadosPessoais[4];
            pessoa.email = dadosPessoais[5];
            pessoa.sexo = dadosPessoais[6];
            pessoa.estadoCivil = dadosPessoais[7];
            pessoa.dataNascimento = dadosPessoais[8];

            DAL.Funcionario.FuncionarioDAO funcionarioDAO = new DAL.Funcionario.FuncionarioDAO();
            pessoa = funcionarioDAO.PesquisarFuncionario(pessoa);

            return pessoa;
        }

        public void ExcluirFuncionario(List<String> dadosPessoais)
        {
            this.mensagem = "";

            Pessoa pessoa = new Pessoa();
            pessoa.nome = dadosPessoais[1];
            pessoa.sobrenome = dadosPessoais[2];
            pessoa.naturalidade = dadosPessoais[3];
            pessoa.CPF = dadosPessoais[4];
            pessoa.email = dadosPessoais[5];
            pessoa.sexo = dadosPessoais[6];
            pessoa.estadoCivil = dadosPessoais[7];
            pessoa.dataNascimento = dadosPessoais[8];

            DAL.Funcionario.FuncionarioDAO funcionarioDAO = new DAL.Funcionario.FuncionarioDAO();
            funcionarioDAO.ExcluirFucnionario(pessoa);
            this.mensagem = funcionarioDAO.mensagem;
        }

        public FuncionarioCompleto PreencherCampos(List<String> dadosPessoais)
        {
            this.mensagem = "";

            Pessoa pessoa = new Pessoa();
            pessoa.nome = dadosPessoais[1];
            pessoa.sobrenome = dadosPessoais[2];
            pessoa.naturalidade = dadosPessoais[3];
            pessoa.CPF = dadosPessoais[4];
            pessoa.email = dadosPessoais[5];
            pessoa.sexo = dadosPessoais[6];
            pessoa.estadoCivil = dadosPessoais[7];
            pessoa.dataNascimento = dadosPessoais[8];

            DAL.Funcionario.FuncionarioDAO funcionarioDAO = new DAL.Funcionario.FuncionarioDAO();
            FuncionarioCompleto funcionarioCompleto  = new FuncionarioCompleto();
            funcionarioCompleto = funcionarioDAO.PreencherCampos(pessoa);
            this.mensagem = funcionarioDAO.mensagem;

            return funcionarioCompleto;
        }

        public void EditarFuncionario(List<String> dadosPessoais, List<String> dadosFuncionario)
        {
            this.mensagem = "";

            Pessoa pessoa = new Pessoa();
            pessoa.nome = dadosPessoais[1];
            pessoa.sobrenome = dadosPessoais[2];
            pessoa.naturalidade = dadosPessoais[3];
            pessoa.CPF = dadosPessoais[4];
            pessoa.email = dadosPessoais[5];
            pessoa.sexo = dadosPessoais[6];
            pessoa.estadoCivil = dadosPessoais[7];
            pessoa.dataNascimento = dadosPessoais[8];

            Funcionario funcionario = new Funcionario();
            funcionario.senha = dadosFuncionario[0];
            funcionario.tipo = dadosFuncionario[2];
            funcionario.RA = dadosFuncionario[3];
            funcionario.login = dadosFuncionario[4];
            funcionario.coren = dadosFuncionario[5];
            funcionario.funcional = dadosFuncionario[6];


            DAL.Funcionario.FuncionarioDAO funcionarioDAO = new DAL.Funcionario.FuncionarioDAO();
            funcionarioDAO.EditarFuncionario(pessoa, funcionario);
            this.mensagem = funcionarioDAO.mensagem;

        }
    }
}
