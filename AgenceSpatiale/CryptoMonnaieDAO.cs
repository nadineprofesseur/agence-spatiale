using System;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Collections.Generic;

namespace AgenceSpatiale
{
	class CryptoMonnaieDAO
	{
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
			foreach (dynamic monnaie in lesMonnaies)
			{
				Console.WriteLine(monnaie.ToString());
				// Donne : [AXIS, System.Collections.Generic.Dictionary`2[System.String, System.Object]]
			}

			return json;
		}

	}
}
