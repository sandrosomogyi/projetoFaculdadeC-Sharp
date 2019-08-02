using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_PIM.Modelo;
using Sistema_PIM.Modelo.Paciente;

namespace Sistema_PIM.DAL.Paciente
{
    interface intPacienteDAO
    {
        void CadastrarPaciente(Pessoa pessoa, Modelo.Paciente.Paciente paciente, Endereco endereco, Telefone telefone);
        bool VerificarCPF(Pessoa pessoa);
        Pessoa PesquisarPaciente(Pessoa pessoa);
        void ExcluirPaciente(Pessoa pessoa);
        void EditarPaciente(Pessoa pessoa, Modelo.Paciente.Paciente paciente, Endereco endereco, Telefone telefone);
        PacienteCompleto PreencherCampos(Pessoa pessoa);
    }
}
