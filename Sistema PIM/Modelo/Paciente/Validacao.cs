using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PIM.Modelo.Paciente
{
    public class Validacao : absPropriedades
    {
        public void ValidarDadosPessoa(List<String> dadosPessoa)
        {
            this.mensagem = "";

            if (dadosPessoa[4].Length > 13)
                this.mensagem += " CPF com mais de 13 caracteres \n";

            try
            {
                this.id = Convert.ToInt32(dadosPessoa[0]);
            }
            catch (FormatException)
            {
                this.mensagem += " ID inválido ";
            }
        }
    }
}
