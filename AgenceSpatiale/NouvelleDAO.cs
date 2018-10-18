using System.IO;
using System;
using System.Net;


namespace AgenceSpatiale
{
	class NouvelleDAO
	{
		public string listerNouvelles(string rss)
		{
			Console.WriteLine("RssDAO.listerNouvelles(" + rss + ")");
			HttpWebRequest requeteNouvelles = (HttpWebRequest)WebRequest.Create(rss);
			requeteNouvelles.Method = "GET";
			//requeteNouvelles.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
			requeteNouvelles.UserAgent = "Mozilla Firefox";
			//ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			WebResponse reponse = requeteNouvelles.GetResponse();
			StreamReader lecteur = new StreamReader(reponse.GetResponseStream());
			return lecteur.ReadToEnd();
		}
	}
}
