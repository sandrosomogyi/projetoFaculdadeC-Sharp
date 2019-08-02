using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PIM.Modelo.Paciente
{
    public class PacienteCompleto
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
        //paciente
        public string filiacaoMae { get; set; } //0
        public string conjuge { get; set; } //1
        public string filiacaoPai { get; set; } //2
        public string profissao { get; set; } //3
        public string escolaridade { get; set; } //4
        public string observacoes { get; set; } //5
        //endereço
        public string cidade { get; set; } //0
        public int cep { get; set; } //1
        public string rua { get; set; } //2
        public string complemento { get; set; } //3
        public string bairro { get; set; } //4
        public int numero { get; set; } //5
        public string estado { get; set; } //6
        //telefone
        public string numero1 { get; set; } //0
        public string tipo1 { get; set; } //1
    }
}
