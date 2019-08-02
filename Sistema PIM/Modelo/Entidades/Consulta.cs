using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PIM.Modelo.Entidades
{
	public class Consulta
	{
		public int idConsulta { get; set; }
		public int idAgendamento { get; set; }

		public string nomeAcompanhante { get; set; }
		public DateTime horarioAtendimento { get; set; }
	}
}
