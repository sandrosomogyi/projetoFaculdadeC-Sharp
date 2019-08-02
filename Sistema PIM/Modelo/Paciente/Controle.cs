using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PIM.Modelo.Paciente
{
    public class Controle : absPropriedades
    {

        public void CadastrarPaciente(List<String> dadosPessoais, List<String>dadosPaciente, List<String> dadosEndereco, List<String> dadosTelefone)
        {
            this.mensagem = "";

            Validacao validacao = new Validacao();
            validacao.ValidarDadosPessoa(dadosPessoais);


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

                Paciente paciente = new Paciente();
                paciente.filiacaoMae = dadosPaciente[0];
                paciente.conjuge = dadosPaciente[1];
                paciente.filiacaoPai = dadosPaciente[2];
                paciente.profissao = dadosPaciente[3];
                paciente.escolaridade = dadosPaciente[4];
                paciente.observacoes = dadosPaciente[5];

                Endereco endereco = new Endereco();
                endereco.cidade = dadosEndereco[0];
                endereco.cep = Convert.ToInt32(dadosEndereco[1]);
                endereco.rua = dadosEndereco[2];
                endereco.complemento = dadosEndereco[3];
                endereco.bairro = dadosEndereco[4];
                endereco.numero = Convert.ToInt32(dadosEndereco[5]);
                endereco.estado = dadosEndereco[6];

                Telefone telefone = new Telefone();
                telefone.numero1 = dadosTelefone[0];
                telefone.tipo1 = dadosTelefone[1];
                telefone.numero2 = dadosTelefone[2];
                telefone.tipo2 = dadosTelefone[3];


                DAL.Paciente.PacienteDAO pacienteDAO = new DAL.Paciente.PacienteDAO();
                existeCPF = pacienteDAO.VerificarCPF(pessoa);
                if (existeCPF.Equals(false))
                {
                    pacienteDAO.CadastrarPaciente(pessoa, paciente, endereco, telefone);
                    this.mensagem = pacienteDAO.mensagem;
                }
                else
                {
                    this.mensagem = pacienteDAO.mensagem;
                }
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public Pessoa PesquisarPaciente(List<String> dadosPessoais)
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

            DAL.Paciente.PacienteDAO paciente = new DAL.Paciente.PacienteDAO();
            pessoa = paciente.PesquisarPaciente(pessoa);

            return pessoa;
        }
        public void ExcluirPaciente (List<String> dadosPessoais)
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

            DAL.Paciente.PacienteDAO paciente = new DAL.Paciente.PacienteDAO();
            paciente.ExcluirPaciente(pessoa);
            this.mensagem = paciente.mensagem;
        }
        public PacienteCompleto PreencherCampos(List<String> dadosPessoais)
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

            DAL.Paciente.PacienteDAO pacienteDAO = new DAL.Paciente.PacienteDAO();
            PacienteCompleto pacienteCompleto = new PacienteCompleto();
            pacienteCompleto = pacienteDAO.PreencherCampos(pessoa);
            this.mensagem = pacienteDAO.mensagem;

            return pacienteCompleto;
        }

        public void EditarPaciente (List<String> dadosPessoais, List<String> dadosPaciente, List<String> dadosEndereco, List<String> dadosTelefone)
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

                Paciente paciente = new Paciente();
                paciente.filiacaoMae = dadosPaciente[0];
                paciente.conjuge = dadosPaciente[1];
                paciente.filiacaoPai = dadosPaciente[2];
                paciente.profissao = dadosPaciente[3];
                paciente.escolaridade = dadosPaciente[4];
                paciente.observacoes = dadosPaciente[5];

                Endereco endereco = new Endereco();
                endereco.cidade = dadosEndereco[0];
                endereco.cep = Convert.ToInt32(dadosEndereco[1]);
                endereco.rua = dadosEndereco[2];
                endereco.complemento = dadosEndereco[3];
                endereco.bairro = dadosEndereco[4];
                endereco.numero = Convert.ToInt32(dadosEndereco[5]);
                endereco.estado = dadosEndereco[6];

                Telefone telefone = new Telefone();
                telefone.numero1 = dadosTelefone[0];
                telefone.tipo1 = dadosTelefone[1];
                telefone.numero2 = dadosTelefone[2];
                telefone.tipo2 = dadosTelefone[3];


                DAL.Paciente.PacienteDAO pacienteDAO = new DAL.Paciente.PacienteDAO();
                pacienteDAO.EditarPaciente(pessoa, paciente, endereco, telefone);
                this.mensagem = pacienteDAO.mensagem;

        }

            
    }
}
