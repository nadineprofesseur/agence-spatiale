using System;
using System.Web.Script.Serialization;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Text;

// Liste des salons
// https://slack.com/api/channels.list?token=xoxp-473953774023-473376698226-472643986400-fb1078e65934f7e2e473d1fa7157a120&pretty=1
// Messages du salon general
// https://slack.com/api/channels.history?token=xoxp-473953774023-473376698226-472643986400-fb1078e65934f7e2e473d1fa7157a120&channel=CDXU1P58X&pretty=1

namespace AgenceSpatiale
{
	class SalonDAO // Slack
	{
		public string listerSalons()
		{
			Console.WriteLine("SalonDAO.listerSalons()");
			string json = "";

			string url = "https://slack.com/api/channels.list?token=xoxp-473953774023-473376698226-473681655141-c1f0e28aa268cc2a8f586f80c34330ff&pretty=1";
			WebRequest requetesSalons = WebRequest.Create(url);
			WebResponse reponse = requetesSalons.GetResponse();
			StreamReader lecteur = new StreamReader(reponse.GetResponseStream());
			json = lecteur.ReadToEnd();

			JavaScriptSerializer parseur = new JavaScriptSerializer();
			dynamic objet = parseur.Deserialize<dynamic>(json);
			var lesSalons = objet["channels"];
			foreach (dynamic salon in lesSalons)
			{
				var id = salon["id"];
				var nom = salon["name"];
				Console.WriteLine(id + " : " + nom);
			}

			return json;
		}
	}
}
