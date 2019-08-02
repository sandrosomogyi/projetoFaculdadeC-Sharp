using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PIM.Modelo.Paciente
{
	public class Paciente
	{
		public string filiacaoMae { get; set; } //0
		public string conjuge { get; set; } //1
		public string filiacaoPai { get; set; } //2
		public string profissao { get; set; } //3
		public string escolaridade { get; set; } //4
		public string observacoes { get; set; } //5
	}
}
