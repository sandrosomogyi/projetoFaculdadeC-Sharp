using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PIM.DAL.Agendamento
{
    interface intAgendamentoDAO
    {
        void Agendar(Modelo.Agendamento.Agendamento agendamento);
    }
}
