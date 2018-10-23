using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenceSpatiale
{
	/**
	Contenu basé sur l'analyse du xml reçu pour une nouvelle de fil RSS
	Ce sont les balises dans la balise <entry></entry>	
	 * */
	class Nouvelle
	{
		public string titre { get; set; }
		public string lien { get; set; }
		public string publication { get; set; } // TODO modifier le type pour une date
		public string categorie { get; set;}
		public string resume { get; set; }
	}
}
