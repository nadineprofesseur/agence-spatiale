using System.Net;
using System.IO;
using System;

namespace AgenceSpatiale
{
	class SeismeDAO
	{
		public static string URL_SEISME= "http://soda.demo.socrata.com/resource/6yvf-kk3n.xml?source=pr&$where=region%20like%20%27%25{{LIEU}}%25%27";

		public string listerSeismes(string lieu)
		{
			Console.WriteLine("SeismeDAO.listerSeismes("+lieu+")");
			string url = URL_SEISME.Replace("{{LIEU}}", lieu);
			Console.WriteLine(url);
			WebRequest requeteSeismes = WebRequest.Create(url);
			WebResponse reponse = requeteSeismes.GetResponse();
			StreamReader lecteur = new StreamReader(reponse.GetResponseStream());
			return lecteur.ReadToEnd();
		}
	}
}
