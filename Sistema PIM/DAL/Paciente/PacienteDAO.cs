using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_PIM.Modelo;
using Sistema_PIM.Modelo.Paciente;

namespace Sistema_PIM.DAL.Paciente
{
    class PacienteDAO : intPacienteDAO
    {
        public String mensagem;
        public String id;
        public bool existeCPF;
        SqlDataReader dataReader;
        Conexao conexaoBD = new Conexao();

        public void CadastrarPaciente(Pessoa pessoa, Modelo.Paciente.Paciente paciente, Endereco endereco, Telefone telefone)
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
                                insert into Paciente (filiacaoMae, conjuge, filiacaoPai, profissao, escolaridade, observacoes, fk_idPessoa_Pessoa) 
                                values (@filiacaoMae, @conjuge, @filiacaoPai, @profissao, @escolaridade, @observacoes, @idPessoa)
                                
                                insert into Endereço (cidade, cep, rua, complemento, bairro, numero, estado, fk_idPessoa_Pessoa)
                                values (@cidade, @cep, @rua, @complemento, @bairro, @numero, @estado, @idPessoa)
                                
                                insert into Telefone (numero, tipo, fk_idPessoa_Pessoa)
                                values (@telefone1, @tipo1, @idPessoa)";

                    cmd.Parameters.AddWithValue("@filiacaoMae", paciente.filiacaoMae);
                    cmd.Parameters.AddWithValue("@conjuge", paciente.conjuge);
                    cmd.Parameters.AddWithValue("@filiacaoPai", paciente.filiacaoPai);
                    cmd.Parameters.AddWithValue("@profissao", paciente.profissao);
                    cmd.Parameters.AddWithValue("@escolaridade", paciente.escolaridade);
                    cmd.Parameters.AddWithValue("@observacoes", paciente.observacoes);

                    cmd.Parameters.AddWithValue("@cidade", endereco.cidade);
                    cmd.Parameters.AddWithValue("@cep", endereco.cep);
                    cmd.Parameters.AddWithValue("@rua", endereco.rua);
                    cmd.Parameters.AddWithValue("@complemento", endereco.complemento);
                    cmd.Parameters.AddWithValue("@bairro", endereco.bairro);
                    cmd.Parameters.AddWithValue("@numero", endereco.numero);
                    cmd.Parameters.AddWithValue("@estado", endereco.estado);

                    cmd.Parameters.AddWithValue("@telefone1", telefone.numero1);
                    cmd.Parameters.AddWithValue("@tipo1", telefone.tipo1);
                    cmd.Parameters.AddWithValue("@telefone2", telefone.numero2);
                    cmd.Parameters.AddWithValue("@tipo2", telefone.tipo2);
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

        public void EditarPaciente(Pessoa pessoa, Modelo.Paciente.Paciente paciente, Endereco endereco, Telefone telefone)
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
                                
                                update Paciente set filiacaoMae = @filiacaoMae, conjuge = @conjuge, filiacaoPai = @filiacaoPai,
                                profissao = @profissao, escolaridade = @escolaridade, observacoes = @observacoes
                                where fk_idPessoa_Pessoa = @idPessoa
                                
                                update Endereço set cidade = @cidade, cep = @cep, rua = @rua, complemento = @complemento,
                                bairro = @bairro, numero = @numero, estado = @estado
                                where fk_idPessoa_Pessoa = @idPessoa
                                
                                update Telefone set numero = @telefone1, tipo = @tipo1
                                where fk_idPessoa_Pessoa = @idPessoa";

                cmd.Parameters.AddWithValue("@idPessoa", id);

                cmd.Parameters.AddWithValue("@nome", pessoa.nome);
                cmd.Parameters.AddWithValue("@sobrenome", pessoa.sobrenome);
                cmd.Parameters.AddWithValue("@naturalidade", pessoa.naturalidade);
                cmd.Parameters.AddWithValue("@email", pessoa.email);
                cmd.Parameters.AddWithValue("@sexo", pessoa.sexo);
                cmd.Parameters.AddWithValue("@estadoCivil", pessoa.estadoCivil);
                cmd.Parameters.AddWithValue("@dataNascimento", pessoa.dataNascimento);

                cmd.Parameters.AddWithValue("@filiacaoMae", paciente.filiacaoMae);
                cmd.Parameters.AddWithValue("@conjuge", paciente.conjuge);
                cmd.Parameters.AddWithValue("@filiacaoPai", paciente.filiacaoPai);
                cmd.Parameters.AddWithValue("@profissao", paciente.profissao);
                cmd.Parameters.AddWithValue("@escolaridade", paciente.escolaridade);
                cmd.Parameters.AddWithValue("@observacoes", paciente.observacoes);

                cmd.Parameters.AddWithValue("@cidade", endereco.cidade);
                cmd.Parameters.AddWithValue("@cep", endereco.cep);
                cmd.Parameters.AddWithValue("@rua", endereco.rua);
                cmd.Parameters.AddWithValue("@complemento", endereco.complemento);
                cmd.Parameters.AddWithValue("@bairro", endereco.bairro);
                cmd.Parameters.AddWithValue("@numero", endereco.numero);
                cmd.Parameters.AddWithValue("@estado", endereco.estado);

                cmd.Parameters.AddWithValue("@telefone1", telefone.numero1);
                cmd.Parameters.AddWithValue("@tipo1", telefone.tipo1);
                cmd.Parameters.AddWithValue("@telefone2", telefone.numero2);
                cmd.Parameters.AddWithValue("@tipo2", telefone.tipo2);

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
            

        public void ExcluirPaciente(Pessoa pessoa)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"declare @id int
                                set @id = (select max (idPessoa) from Pessoa where CPF = @CPF)
                                delete Endereço where fk_idPessoa_Pessoa = @id
                                delete Telefone where fk_idPessoa_Pessoa = @id
                                delete Paciente where fk_idPessoa_Pessoa = @id
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

        public Pessoa PesquisarPaciente(Pessoa pessoa)
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

        public PacienteCompleto PreencherCampos(Pessoa pessoa)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            PacienteCompleto pacienteCompleto = new PacienteCompleto();

            cmd.CommandText = @"select idPessoa from Pessoa where CPF = @cpf";

            cmd.Parameters.AddWithValue("@cpf", pessoa.CPF);

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                id = Convert.ToString(cmd.ExecuteScalar());
                conexaoBD.Desconectar();

                cmd.CommandText = @"select *, Telefone.numero as numTel, Telefone.tipo as tipoTel 
                                    from Pessoa, Paciente, Endereço, Telefone where idPessoa = @idPessoa
                                    and Paciente.fk_idPessoa_Pessoa = @idPessoa and Endereço.fk_idPessoa_Pessoa = @idPessoa 
                                    and Telefone.fk_idPessoa_Pessoa = @idPessoa";

                cmd.Parameters.AddWithValue("@idPessoa", id);

                try
                {
                    cmd.Connection = conexaoBD.Conectar();
                    dataReader = cmd.ExecuteReader();

                    dataReader.Read();
                    pacienteCompleto.nome = dataReader["nome"].ToString();
                    pacienteCompleto.sobrenome = dataReader["sobrenome"].ToString();
                    pacienteCompleto.naturalidade = dataReader["naturalidade"].ToString();
                    pacienteCompleto.CPF = dataReader["CPF"].ToString();
                    pacienteCompleto.email = dataReader["email"].ToString();
                    pacienteCompleto.sexo = dataReader["sexo"].ToString();
                    pacienteCompleto.estadoCivil = dataReader["estadoCivil"].ToString();
                    pacienteCompleto.dataNascimento = dataReader["dataNascimento"].ToString();

                    pacienteCompleto.filiacaoMae = dataReader["filiacaoMae"].ToString();
                    pacienteCompleto.conjuge = dataReader["conjuge"].ToString();
                    pacienteCompleto.filiacaoPai = dataReader["filiacaoPai"].ToString();
                    pacienteCompleto.profissao = dataReader["profissao"].ToString();
                    pacienteCompleto.escolaridade = dataReader["escolaridade"].ToString();
                    pacienteCompleto.observacoes = dataReader["observacoes"].ToString();

                    pacienteCompleto.cidade = dataReader["cidade"].ToString();
                    pacienteCompleto.cep = Convert.ToInt32(dataReader["cep"]);
                    pacienteCompleto.rua = dataReader["rua"].ToString();
                    pacienteCompleto.complemento = dataReader["complemento"].ToString();
                    pacienteCompleto.bairro = dataReader["bairro"].ToString();
                    pacienteCompleto.numero = Convert.ToInt32(dataReader["numero"]);
                    pacienteCompleto.estado = dataReader["estado"].ToString();

                    pacienteCompleto.numero1 = dataReader["numTel"].ToString();
                    pacienteCompleto.tipo1 = dataReader["tipoTel"].ToString();

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

            return pacienteCompleto;
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
    }
}
