using System.Net;
using System.IO;

namespace AgenceSpatiale
{
	class SeismeDAO
	{
		public static string URL_SEISME_STELLA = "http://soda.demo.socrata.com/resource/6yvf-kk3n.xml?source=pr&$where=region%20like%20%27%25Stella%25%27";

		public string listerSeismes()
		{
			WebRequest requeteSeismesStella = WebRequest.Create(URL_SEISME_STELLA);
			WebResponse reponse = requeteSeismesStella.GetResponse();
			StreamReader lecteur = new StreamReader(reponse.GetResponseStream());
			return lecteur.ReadToEnd();
		}
	}
}
