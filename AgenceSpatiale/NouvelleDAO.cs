using System.IO;
using System;
using System.Net;
using System.Xml;
using System.Xml.Linq;


namespace AgenceSpatiale
{
	class NouvelleDAO
	{
		//public List<Nouvelle> listerNouvelles(string rss)
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
			string xml = lecteur.ReadToEnd();
			XElement nouvellesXML = XElement.Parse(xml);
			foreach (XElement nouvelleXML in nouvellesXML.Elements())
			{
				//Console.WriteLine(nouvelleXML.ToString());
				//XDocument nouvelleDoc = nouvelleXML.CreateReader();
				XmlReader lecteurNouvelle = nouvelleXML.CreateReader();
				lecteurNouvelle.MoveToContent();
				lecteurNouvelle.ReadToDescendant("title");
				string titre = lecteurNouvelle.ReadInnerXml();
				Console.WriteLine(titre);
			}
			//string titre = (string)lecteurNouvelle.ReadContentAs(typeof(string), null); // bug

			return xml;
		}
	}
}
