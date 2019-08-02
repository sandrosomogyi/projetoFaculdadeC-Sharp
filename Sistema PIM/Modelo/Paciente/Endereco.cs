using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PIM.Modelo.Paciente
{
	public class Endereco
	{
		public string cidade { get; set; } //0
		public int cep { get; set; } //1
		public string rua { get; set; } //2
		public string complemento { get; set; } //3
		public string bairro { get; set; } //4
		public int numero { get; set; } //5
		public string estado { get; set; } //6

	}
}
