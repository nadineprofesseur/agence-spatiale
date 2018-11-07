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
			PokemonDAO pokemonDAO = new PokemonDAO();
			CryptoMonnaieDAO cryptomonnaieDAO = new CryptoMonnaieDAO();
			SalonDAO salonDAO = new SalonDAO();

			//string listeSalons = salonDAO.listerSalons();
			//Console.WriteLine(listeSalons);
			string listeMessages = salonDAO.listerMessagesParSalon("");
			//Console.WriteLine(listeMessages);

			/*List<CryptoMonnaie> listeMonnaies = cryptomonnaieDAO.listerMonnaies();
			foreach (CryptoMonnaie monnaie in listeMonnaies)
			{
				Console.WriteLine("Programme principal : " + monnaie.nom);
			}
			*/

			//FONCTIONNEL
			/*List<Pokemon> listePokemon = pokemonDAO.listerPokemon();
			foreach(Pokemon pokemon in listePokemon)
			{
				Console.WriteLine("Pokemon du programme principal : " + pokemon.nom);
			}*/
			//List<Seisme> listeSeismes = seismeDAO.listerSeismes("Stella");
			//Console.WriteLine(listeSeismes.Count + " seismes");
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
