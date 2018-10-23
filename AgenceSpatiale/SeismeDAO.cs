using System.Net;
using System.IO;
using System;
using System.Text;
using System.Xml.XPath;

namespace AgenceSpatiale
{
	class SeismeDAO
	{
		public static string URL_SEISME= "http://soda.demo.socrata.com/resource/6yvf-kk3n.xml?source=pr&$where=region%20like%20%27%25{{LIEU}}%25%27";

		//public List<Seisme> listerSeismes(string lieu)
		public string listerSeismes(string lieu)
		{
			Console.WriteLine("SeismeDAO.listerSeismes("+lieu+")");
			string url = URL_SEISME.Replace("{{LIEU}}", lieu);
			Console.WriteLine(url);
			WebRequest requeteSeismes = WebRequest.Create(url);
			WebResponse reponse = requeteSeismes.GetResponse();
			StreamReader lecteur = new StreamReader(reponse.GetResponseStream());
			string xml = lecteur.ReadToEnd();

			// string -> byte[] -> MemoryStream -> XPathDocument -> XPathNavigator
			MemoryStream flux = new MemoryStream(Encoding.ASCII.GetBytes(xml));
			XPathDocument document = new XPathDocument(flux);
			XPathNavigator navigateurXPath = document.CreateNavigator();

			return xml;
		}
	}
}
