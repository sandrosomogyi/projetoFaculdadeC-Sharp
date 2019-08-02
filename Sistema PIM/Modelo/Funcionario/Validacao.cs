using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PIM.Modelo.Funcionario
{
    public class Validacao : absPropriedades
    {
        public void ValidarDadosFuncionario(List<String> dadosPessoais, List<String> dadosFuncionario)
        {
            this.mensagem = "";

            if (!dadosFuncionario[0].Equals(dadosFuncionario[1]))
                this.mensagem = "Senhas não estão iguais";

            try
            {
                this.id = Convert.ToInt32(dadosPessoais[0]);
            }
            catch (FormatException)
            {
                this.mensagem += " ID inválido ";
            }
        }
    }
}
