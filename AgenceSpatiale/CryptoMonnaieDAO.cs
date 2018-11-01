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
			// modifier possiblement les headers de la requete en cas de probleme
			WebResponse reponse = requeteListeMonnaies.GetResponse();
			return "";
		}

	}
}
