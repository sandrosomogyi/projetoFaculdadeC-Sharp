using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PIM.Modelo.Funcionario
{
    public class FuncionarioCompleto
    {
        //pessoa
        public string nome { get; set; } //1
        public string sobrenome { get; set; } //2
        public string naturalidade { get; set; } //3
        public string CPF { get; set; } //4
        public string email { get; set; }  //5
        public string sexo { get; set; } //6
        public string estadoCivil { get; set; } //7
        public string dataNascimento { get; set; } //8
        //funcionario
        public string senha { get; set; } //0
        public string tipo { get; set; } //1
        public string RA { get; set; } //2
        public string login { get; set; } //3
        public string coren { get; set; } //4
        public string funcional { get; set; } //5
    }
}
