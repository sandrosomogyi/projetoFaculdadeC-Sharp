using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PIM.Modelo.Entidades
{
	public class Anamnese
	{
		public int idAnamnese { get; set; }
		public int idConsulta { get; set; }

		public bool atividadeFisica { get; set; }
		public string moradia { get; set; }
		public bool drogas { get; set; }
		public string atividadeFisicaDesc { get; set; }
		public string drogasDesc { get; set; }
		public string atividadeFisicaFreq { get; set; }
		public string drogasFreq { get; set; }
		public string trabalhadoresMoradia { get; set; }
		public string pessoasMoradia { get; set; }
		public bool descanco { get; set; }
		public int descancoHoras { get; set; }
		public int PN { get; set; }
		public int DUM { get; set; }
		public int G { get; set; }
		public int PC { get; set; }
		public int A { get; set; }
		public string alimentacao { get; set; }
		public DateTime DATETIME { get; set; }
		public bool examePreventivo { get; set; }
		public bool engravidou { get; set; }
		public int menarca { get; set; }
		public int virgindade { get; set; }

	}
}
