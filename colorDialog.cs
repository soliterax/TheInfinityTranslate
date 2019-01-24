using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ceviri2
{
	public partial class colorDialog : Form
	{
		string menuName;
		public colorDialog(string menuName,string name)
		{
			InitializeComponent();

			this.menuName = menuName;
			label1.Text = name;
		}

		INIFile ini = new INIFile(Environment.CurrentDirectory + "/background.ini");
		Çeviri ayar = new Çeviri();

		private void button1_Click(object sender, EventArgs e)
		{
			ini.Write("APP", menuName, "#FF0000");
			bunifuMetroTextbox1.Text = "#FF0000";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ini.Write("APP", menuName, "#0000FF");
			bunifuMetroTextbox1.Text = "#0000FF";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			ini.Write("APP", menuName, "#008000");
			bunifuMetroTextbox1.Text = "#008000";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			ini.Write("APP", menuName, "#32CD32");
			bunifuMetroTextbox1.Text = "#32CD32";
		}

		private void button5_Click(object sender, EventArgs e)
		{
			ini.Write("APP", menuName, "#FFFF00");
			bunifuMetroTextbox1.Text = "#FFFF00";
		}

		private void button6_Click(object sender, EventArgs e)
		{
			ini.Write("APP", menuName, "#00008B");
			bunifuMetroTextbox1.Text = "#00008B";
		}

		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{

			ini.Write("APP", menuName, bunifuMetroTextbox1.Text);
			
			this.Hide();

		}

		private void bunifuMetroTextbox1_Click(object sender, EventArgs e)
		{

			bunifuMetroTextbox1.Text = "";

		}

		private void centerMenu_Load(object sender, EventArgs e)
		{
			string background = ini.Read("APP", "centerMenu");
			this.BackColor = ColorTranslator.FromHtml(background);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			
			string text = bunifuMetroTextbox1.Text;
			if (text.Length == 7)
			{

				ini.Write("APP", menuName, text);
				this.Hide();

			}
			
		}
	}
}
