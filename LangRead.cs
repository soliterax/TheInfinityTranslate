using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceviri2
{
	class LangRead
	{

		private static INIFile ini = new INIFile(Environment.CurrentDirectory + "/settings.ini");
		private static string lang = ini.Read("APP", "Language");

		public void langvalue()
		{



		}

	}
}
