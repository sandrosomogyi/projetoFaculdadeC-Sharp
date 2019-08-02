using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PIM.Modelo.Agendamento
{
    public class Controle : absPropriedades
    {
        public void Agendar (List<String> dadosAgendamento)
        {
            Agendamento agendamento = new Agendamento();
            agendamento.CPF = dadosAgendamento[0];
            agendamento.horarioMarcado = dadosAgendamento[1];
            agendamento.tipo = dadosAgendamento[2];
            agendamento.statusAtendimento = dadosAgendamento[3];

            DAL.Agendamento.AgendamentoDAO agendamentoDAO = new DAL.Agendamento.AgendamentoDAO();
            agendamentoDAO.Agendar(agendamento);
            this.mensagem = agendamentoDAO.mensagem;
        }
    }
}
