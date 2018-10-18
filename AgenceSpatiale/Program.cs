using System;
using System.Net;
using System.IO;
using System.Net.Http;

namespace AgenceSpatiale
{
	class Program
	{
		protected static string urlSeismesStella = "https://soda.demo.socrata.com/resource/6yvf-kk3n.xml?source=pr&$where=region%20like%20%27%25Stella%25%27";

		static void Main(string[] args)
		{

			WebRequest requeteSeismesStella = WebRequest.Create(urlSeismesStella);
			WebResponse reponse = requeteSeismesStella.GetResponse();
			StreamReader lecteur = new StreamReader(reponse.GetResponseStream());
			string xmlSeismeStella = lecteur.ReadToEnd();
			Console.WriteLine(xmlSeismeStella);
			Console.ReadKey(true);

		}
	}
}
