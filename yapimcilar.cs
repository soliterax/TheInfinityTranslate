using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ceviri2
{
	public partial class yapimcilar : UserControl
	{
		public yapimcilar()
		{
			InitializeComponent();
		}
		INIFile ini = new INIFile(Environment.CurrentDirectory + "/settings.ini");
		private void yapimcilar_Load(object sender, EventArgs e)
		{

			string language = ini.Read("APP", "Language");
			string background = ini.Read("APP", "Background");
			if (language.Contains("turkish")){ label1.Text = "Yapımcı Umut Özercan" + Environment.NewLine + "Kodlama Mustafa Öncel & Umut Özercan"; }
			else if (language.Contains("english")) { label1.Text = "Producer Umut Özercan" + Environment.NewLine + "Coding Mustafa Öncel & Umut Özercan"; }
			else if (language.Contains("arapca")) { label1.Text = "نأمل منتج" + Environment.NewLine + "الترميز سلفه مصطفى "; }
			else { label1.Text = "Yapımcı Umut Özercan" + Environment.NewLine + "Kodlama Mustafa Öncel & Umut Özercan"; }
			if (background.Contains("white")) { this.BackColor = Color.White; }
			else { this.BackColor = ColorTranslator.FromHtml("#252E3B"); }
		}
	}
}
