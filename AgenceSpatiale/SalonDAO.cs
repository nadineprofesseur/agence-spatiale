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
		/*
		         {
            "id": "CDXU1P58X",
            "name": "g\u00e9n\u00e9ral",
            "is_channel": true,
            "created": 1541513288,
            "is_archived": false,
            "is_general": true,
            "unlinked": 0,
            "creator": "UDY8W3QCW",
            "name_normalized": "general",
            "is_shared": false,
            "is_org_shared": false,
            "is_member": true,
            "is_private": false,
            "is_mpim": false,
            "members": [
                "UDW5UKQGY",
                "UDX852803",
                "UDX85JBL3",
                "UDXB2LJ6N",
                "UDXB5GCPL",
                "UDY8W3QCW",
                "UDYNX46CE"
            ],
            "topic": {
                "value": "MOTD: Message of the day",
                "creator": "UDYNX46CE",
                "last_set": 1541544508
            },
            "purpose": {
                "value": "Cette cha\u00eene est destin\u00e9e \u00e0 la communication et aux annonces pour tout l\u2019espace de travail. Tous les membres font partie de cette cha\u00eene.",
                "creator": "UDY8W3QCW",
                "last_set": 1541513288
            },
            "previous_names": [],
            "num_members": 7
        }
			 */
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
		/*
		{
            "type": "message",
            "user": "UDX85JBL3",
            "text": "moi avec mon jeep lol",
            "client_msg_id": "3656a9d2-f786-407b-9cbb-5ab56310d98c",
            "ts": "1541544198.009000"
        },
			 */
		public string listerMessagesParSalon(string salon)
		{
			Console.WriteLine("SalonDAO.listerMessagesParSalon()");
			string json = "";

			string url = "https://slack.com/api/channels.history?token=xoxp-473953774023-473376698226-473383844915-248d90fb0e1398b093ecc3ca0b7c286a&channel=CDXU1P58X&pretty=1";
			WebRequest requetesMessages = WebRequest.Create(url);
			WebResponse reponse = requetesMessages.GetResponse();
			StreamReader lecteur = new StreamReader(reponse.GetResponseStream());
			json = lecteur.ReadToEnd();

			JavaScriptSerializer parseur = new JavaScriptSerializer();
			dynamic objet = parseur.Deserialize<dynamic>(json);
			var lesMessages = objet["messages"];
			foreach (dynamic message in lesMessages)
			{
				var type = message["type"];
				var texte = message["text"];
				Console.WriteLine(type + " : " + texte);
			}

			return json;
		}

	}
}
