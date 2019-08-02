using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_PIM.Modelo.Agendamento;

namespace Sistema_PIM.DAL.Agendamento
{
    class AgendamentoDAO : intAgendamentoDAO
    {
        public String mensagem;
        public String idPessoa;
        public String codigoPaciente;

        Conexao conexaoBD = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public void Agendar(Modelo.Agendamento.Agendamento agendamento)
        {
            this.mensagem = "";
            cmd.CommandText = @"select idPessoa from Pessoa where CPF = @cpf";

            cmd.Parameters.AddWithValue("@cpf", agendamento.CPF);

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                idPessoa = Convert.ToString(cmd.ExecuteScalar());
                conexaoBD.Desconectar();

                cmd.CommandText = @"select codigoPaciente from Paciente where fk_idPessoa_Pessoa = @idPessoa";

                cmd.Parameters.AddWithValue("@idPessoa", idPessoa);

                try
                {
                    cmd.Connection = conexaoBD.Conectar();
                    codigoPaciente = Convert.ToString(cmd.ExecuteScalar());
                    conexaoBD.Desconectar();

                    cmd.CommandText = @"insert into Agendamento
                               values (@horarioMarcado, @tipo, @statusAtendimento, @fk_codigoPaciente, @fk_idFuncionario)";

                    cmd.Parameters.AddWithValue("@horarioMarcado", agendamento.horarioMarcado);
                    cmd.Parameters.AddWithValue("@tipo", agendamento.tipo);
                    cmd.Parameters.AddWithValue("@statusAtendimento", agendamento.statusAtendimento);
                    cmd.Parameters.AddWithValue("@fk_codigoPaciente", codigoPaciente);
                    cmd.Parameters.AddWithValue("@fk_idFuncionario", Modelo.Estaticos.idFuncionario);

                    try
                    {
                        cmd.Connection = conexaoBD.Conectar();
                        cmd.ExecuteNonQuery();
                        conexaoBD.Desconectar();

                        this.mensagem = "Agendado com sucesso";
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
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro no Banco de Dados " + e.Message.ToString();
            }
        }
    }
}
