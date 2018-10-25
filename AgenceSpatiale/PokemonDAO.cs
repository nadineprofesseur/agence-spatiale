using System;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
// Références -> Ajouter une référence -> Assemblies -> Framework : System.Web.Extension
// https://stackoverflow.com/questions/7000811/cannot-find-javascriptserializer-in-net-4-0
// using System.Collections.Generic;

namespace AgenceSpatiale
{
	class PokemonDAO
	{
		public string listerPokemon()
		{
			Console.WriteLine("PokemonDAO.listerPokemon()");
			string url = "https://pokeapi.co/api/v2/pokemon/";
			HttpWebRequest requeteListePokemon = (HttpWebRequest)WebRequest.Create(url);
			requeteListePokemon.Method = "GET";
			requeteListePokemon.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36";
			WebResponse reponseListePokemon = requeteListePokemon.GetResponse();
			StreamReader lecteurListePokemon = new StreamReader(reponseListePokemon.GetResponseStream());
			string json = lecteurListePokemon.ReadToEnd();
			Console.WriteLine(json);

			// https://docs.microsoft.com/en-us/dotnet/api/system.web.script.serialization.javascriptserializer
			// https://social.msdn.microsoft.com/Forums/vstudio/en-US/a2e31874-e870-459c-a2a4-2a8d25b20fae/how-to-parse-a-object-using-systemjson?forum=csharpgeneral
			JavaScriptSerializer parseur = new JavaScriptSerializer();
			// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/using-type-dynamic
			dynamic objet = parseur.Deserialize<dynamic>(json);
			string nombre = objet["count"].ToString();

			dynamic[] listePokemonDynamiques = objet["results"];
			foreach (dynamic pokemonDynamique in listePokemonDynamiques)
			{
				string nom = pokemonDynamique["name"].ToString();
				string source = pokemonDynamique["url"].ToString();
				Console.WriteLine(nom + " - " + source);
			}



			Console.WriteLine(nombre + " pokemons recus");
			return json;
		}
	}
}
