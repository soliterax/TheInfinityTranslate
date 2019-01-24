using System;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace Ceviri2
{
	public partial class Update_Form : Form
	{
		public Update_Form()
		{
			InitializeComponent();
		}

		private void Update_Form_Load(object sender, EventArgs e)
		{

			WebClient request = new WebClient();
			string version = "2.1";
			string newVersion = request.DownloadString("https://bombacan2019.tr.gg/version.htm");
			string update = request.DownloadString("https://bombacan2019.tr.gg/version.htm");
			newVersion = new WebClient().DownloadString("https://bombacan2019.tr.gg/version.htm");
			if (version == newVersion)
			{

				label1.Text = "Güncelleme bulunamadı";
				Thread.Sleep(4000);
				this.Hide();

			}
		}
	}
}
