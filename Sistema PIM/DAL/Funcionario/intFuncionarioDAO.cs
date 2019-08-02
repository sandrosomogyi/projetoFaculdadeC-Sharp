using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_PIM.Modelo;
using Sistema_PIM.Modelo.Funcionario;

namespace Sistema_PIM.DAL.Funcionario
{
    interface intFuncionarioDAO
    {
        bool VerificarCPF(Pessoa pessoa);
        bool VerificarLogin(Modelo.Funcionario.Funcionario funcionario);
        void CadastrarFuncionario(Pessoa pessoa, Modelo.Funcionario.Funcionario funcionario );
        Pessoa PesquisarFuncionario(Pessoa pessoa);
        void ExcluirFucnionario(Pessoa pessoa);
        void EditarFuncionario(Pessoa pessoa, Modelo.Funcionario.Funcionario funcionario);
        FuncionarioCompleto PreencherCampos(Pessoa pessoa);
    }
}
