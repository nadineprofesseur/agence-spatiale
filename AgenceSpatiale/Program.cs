﻿using System;

namespace AgenceSpatiale
{
	class Program
	{
		static void Main(string[] args)
		{
			SeismeDAO seismeDAO;
			seismeDAO = new SeismeDAO();
			//string xmlSeismeStella = seismeDAO.listerSeismes("Stella");
			//Console.WriteLine(xmlSeismeStella);

			//string rssMeteoQuebec = "http://meteo.gc.ca/rss/city/qc-133_f.xml";
			NouvelleDAO nouvelleDAO = new NouvelleDAO();
			//string xmlMeteoQuebec = nouvelleDAO.listerNouvelles(rssMeteoQuebec);
			//Console.WriteLine(xmlMeteoQuebec);

			//string rssBlogCodeur = "http://www.joelonsoftware.com/feed/";
			//string xmlBlogCodeur = nouvelleDAO.listerNouvelles(rssBlogCodeur);
			//Console.WriteLine(rssBlogCodeur);

			string rssNouvellesLivres = "http://ici.radio-canada.ca/rss/1000083";
			string xmlNouvellesLivres = nouvelleDAO.listerNouvelles(rssNouvellesLivres);
			Console.WriteLine(xmlNouvellesLivres);
			Console.ReadKey(true);
		}
	}
}
