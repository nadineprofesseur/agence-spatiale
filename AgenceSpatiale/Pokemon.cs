using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenceSpatiale
{
	class Pokemon
	{
		public string nom {get;set;}
		public int hauteur {get;set;}
		public int numero { get; set; }
		public string illustration { get; set; }
	
		public List<string> abilites { get; set; }
		public Pokemon()
		{
			this.abilites = new List<string>();
		}

		public void ajouterAbilete(string abilete)
		{
			this.abilites.Add(abilete);
		}


	}
}
