using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

			return json;
		}
	}
}
