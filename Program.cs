using System;
using System.Windows.Forms;

namespace Ceviri2
{
	static class Program
	{

		public static Çeviri instance;

		/// <summary>
		/// Uygulamanın ana girdi noktası.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			instance = new Çeviri();
			Application.Run(instance);
		}
	}
}
