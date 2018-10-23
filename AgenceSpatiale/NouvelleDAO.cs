using System.IO;
using System;
using System.Net;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;


namespace AgenceSpatiale
{
	class NouvelleDAO
	{
		//public List<Nouvelle> listerNouvelles(string rss)
		public string listerNouvelles(string rss)
		{
			List<Nouvelle> listeNouvelles = new List<Nouvelle>();
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

				//lecteurNouvelle.ReadToFollowing("link");
				//string lien = lecteurNouvelle.MoveToAttribute("href").ToString();
				//Console.WriteLine(lien);

				lecteurNouvelle.ReadToFollowing("published");
				string publication = lecteurNouvelle.ReadInnerXml();
				Console.WriteLine(publication);

				//lecteurNouvelle.ReadToFollowing("category");
				//string categorie = lecteurNouvelle.MoveToAttribute("term").ToString();
				//Console.WriteLine(categorie);

				lecteurNouvelle.ReadToFollowing("summary");
				string resume = lecteurNouvelle.ReadInnerXml();
				Console.WriteLine(resume);

				Nouvelle nouvelle = new Nouvelle();
				nouvelle.titre = titre;
				//nouvelle.lien = lien;
				nouvelle.publication = publication;
				//nouvelle.categorie = categorie;
				nouvelle.resume = resume;

				listeNouvelles.Add(nouvelle);
			}
			//string titre = (string)lecteurNouvelle.ReadContentAs(typeof(string), null); // bug

			return xml;
		}
	}
}
