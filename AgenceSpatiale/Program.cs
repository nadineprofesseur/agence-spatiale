using System;

namespace AgenceSpatiale
{
	class Program
	{
		static void Main(string[] args)
		{
			SeismeDAO seismeDAO;
			seismeDAO = new SeismeDAO();
			string xmlSeismeStella = seismeDAO.listerSeismes("Stella");
			Console.WriteLine(xmlSeismeStella);
			Console.ReadKey(true);
		}
	}
}
