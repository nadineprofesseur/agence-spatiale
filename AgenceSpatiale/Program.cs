using System;
using System.Collections.Generic;

namespace AgenceSpatiale
{
	class Program
	{
		static void Main(string[] args)
		{
			SeismeDAO seismeDAO = new SeismeDAO();
			NouvelleDAO nouvelleDAO = new NouvelleDAO();

			//FONCTIONNEL
			List<Seisme> listeSeismes = seismeDAO.listerSeismes("Stella");
			Console.WriteLine(listeSeismes.Count + " seismes");
			//Console.WriteLine(xmlSeismeStella);

			string rssMeteoQuebec = "http://meteo.gc.ca/rss/city/qc-133_f.xml";
			//List<Nouvelle> listeNouvelles = nouvelleDAO.listerNouvelles(rssMeteoQuebec);
			//foreach (Nouvelle nouvelle in listeNouvelles)
			{
			//	Console.WriteLine(nouvelle.titre);
			}

			// DISFONCTIONNEL

			//string rssBlogCodeur = "http://www.joelonsoftware.com/feed/";
			//string xmlBlogCodeur = nouvelleDAO.listerNouvelles(rssBlogCodeur);
			//Console.WriteLine(rssBlogCodeur);

			//string rssNouvellesLivres = "http://ici.radio-canada.ca/rss/1000083";
			//string xmlNouvellesLivres = nouvelleDAO.listerNouvelles(rssNouvellesLivres);
			//Console.WriteLine(xmlNouvellesLivres);

			Console.ReadKey(true);
		}
	}
}
