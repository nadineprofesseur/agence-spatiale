using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenceSpatiale
{
	class CryptoMonnaie
	{
		public string symbole { get; set; }
		public string nom { get; set; }
		public string algorithme { get; set; }
		public string nombre { get; set; } // TODO changer en int
		public string sourceIllustration { get; set; }
	}
}
