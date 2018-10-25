using System;
using System.Collections.Generic;
using System.Net;
using System.IO;

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
			return json;
		}
	}
}
