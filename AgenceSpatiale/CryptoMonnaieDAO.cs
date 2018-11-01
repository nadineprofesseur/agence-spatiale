using System;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Collections.Generic;

namespace AgenceSpatiale
{
	class CryptoMonnaieDAO
	{

		/*
		     "GLYPH": {
      "Id": "4530",
      "Url": "/coins/glyph/overview",
      "ImageUrl": "/media/19725/glyph.png",
      "Name": "GLYPH",
      "Symbol": "GLYPH",
      "CoinName": "GlyphCoin",
      "FullName": "GlyphCoin (GLYPH)",
      "Algorithm": "X11",
      "ProofType": "PoW/PoS",
      "FullyPremined": "0",
      "TotalCoinSupply": "7000000",
      "BuiltOn": "N/A",
      "SmartContractAddress": "N/A",
      "PreMinedValue": "N/A",
      "TotalCoinsFreeFloat": "N/A",
      "SortOrder": "126",
      "Sponsored": false
    },

			 */
		public string listerMonnaies()
		{
			Console.WriteLine("CryptoMonnaieDAO.listerMonnaies()");
			string url = "https://www.cryptocompare.com/api/data/coinlist/";
			HttpWebRequest requeteListeMonnaies = (HttpWebRequest)WebRequest.Create(url);
			WebResponse reponse = requeteListeMonnaies.GetResponse();
			StreamReader lecteurListeMonnaies = new StreamReader(reponse.GetResponseStream());
			string json = lecteurListeMonnaies.ReadToEnd();
			//Console.WriteLine(json);

			JavaScriptSerializer parseur = new JavaScriptSerializer();
			dynamic objet = parseur.Deserialize<dynamic>(json);
			var lesMonnaies = objet["Data"];
			foreach (dynamic itemMonnaie in lesMonnaies)
			{
				//Console.WriteLine(itemMonnaie.ToString());
				// Donne : [AXIS, System.Collections.Generic.Dictionary`2[System.String, System.Object]]
				// Même si on a [truc1, truc2] c'est pas un tableau, c'est un cle => valeur, acces avec .Key & .Value
				var monnaie = itemMonnaie.Value;
				var symbole = monnaie["Symbol"];
				var nom = monnaie["CoinName"];
				var algorithme = monnaie["Algorithm"];
				var nombre = monnaie["TotalCoinSupply"];
				// var illustration = monnaie["ImageUrl"]; KeyNotFoundException
				Console.WriteLine("Monnaie " + symbole + " : " + nom + "("+nombre+")");
			}

			return json;
		}

	}
}
