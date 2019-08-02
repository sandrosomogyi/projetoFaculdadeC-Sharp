using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PIM.Modelo.Agendamento
{
	public class Agendamento
	{
		public int idAgendamento { get; set; }
		public int idFuncionario { get; set; }
		public int codigoPaciente { get; set; }
        public string CPF { get; set; } //0

        public string horarioMarcado { get; set; } //1
		public string tipo { get; set; } //2
		public string statusAtendimento { get; set; } //3
	}
}
