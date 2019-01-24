using System;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Ceviri2
{
	public partial class CustomDesign : UserControl
	{
		public CustomDesign()
		{
			InitializeComponent();
		}
		INIFile ini = new INIFile(Environment.CurrentDirectory + "/background.ini");
		sonsuzayar ayar = new sonsuzayar();
		private string up = "";
		private string side = "";
		private string center = "";
		private string yaziRenk = "";
		private void CustomDesign_Load(object sender, EventArgs e)
		{

			if (!File.Exists(Environment.CurrentDirectory + "/background.ini"))
			{

				if (ayar.bunifuiOSSwitch1.Value == true)
				{
					setIni("upMenu", "#00BFFF");
					setIni("sideMenu", "#E5E1E1");
					setIni("centerMenu", "#FFFFFF");
					setIni("textMenu", "#000000");
				}
				else
				{

					ini.Write("APP", "upMenu", "#9E9E9E");
					ini.Write("APP", "sideMenu", "#1A2028");
					ini.Write("APP", "centerMenu", "#252E3B");
					ini.Write("APP", "textColor", "#FFFFFF");

				}
			}
			else
			{

				up = ini.Read("APP", "upMenu");
				side = ini.Read("APP", "sideMenu");
				center = ini.Read("APP", "centerMenu");
				yaziRenk = ini.Read("APP", "textColor");

			}

			upMenu.BackColor = ColorTranslator.FromHtml(up);
			sideMenu.BackColor = ColorTranslator.FromHtml(side);
			centerMenu.BackColor = ColorTranslator.FromHtml(center);
			Image image = Image.FromFile(ini.Read("APP","Image"));
			new Thread(() =>
			{
				Thread.CurrentThread.IsBackground = true;
				Thread.CurrentThread.Name = "Color Thread";
				while (true)
				{
					string upmenucolor = ini.Read("APP", "upMenu");
					string sideMenucolor = ini.Read("APP", "sideMenu");
					string centerMenucolor = ini.Read("APP", "centerMenu");
					image = Image.FromFile(ini.Read("APP", "Image"));
					upMenu.BackColor = ColorTranslator.FromHtml(upmenucolor);
					sideMenu.BackColor = ColorTranslator.FromHtml(sideMenucolor);
					centerMenu.BackColor = ColorTranslator.FromHtml(centerMenucolor);
					Thread.Sleep(2000);
				}
			}).Start();

			pictureBox1.Image = image;
		}
		public void setIni(string name, string value)
		{

			ini.Write("APP", name, value);

		}
		public string getIni(string name)
		{

			return ini.Read("APP", name);

		}

		public void setUp(string upColor)
		{

			this.up = upColor;

		}

		private void upMenu_Click(object sender, EventArgs e)
		{

			using (colorDialog dia = new colorDialog("upMenu","UpMenu"))
			{
				if (dia.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{



				}


			}

		}

		private void sideMenu_Click(object sender, EventArgs e)
		{

			using (colorDialog dia = new colorDialog("sideMenu","SideMenu"))
			{
				if (dia.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{



				}


			}

		}

		public void centerMenu_Click(object sender, EventArgs e)
		{

			using (colorDialog dia = new colorDialog("centerMenu","CenterMenu"))
			{
				if (dia.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{

					

				}


			}

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			upMenu.Visible = true;
			sideMenu.Visible = true;
			centerMenu.Visible = true;
			pictureBox1.Visible = false;
			button1.Enabled = false;

		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			upMenu.Visible = false;
			sideMenu.Visible = false;
			centerMenu.Visible = false;
			pictureBox1.Visible = true;
			button1.Enabled = true;
		}

		private void centerMenu_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

			OpenFileDialog dia = new OpenFileDialog();
			dia.Filter = "PNG Images |*.png*";
			if (dia.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{

				ini.Write("APP", "Image", dia.FileName);
				Image file = Image.FromFile(dia.FileName);
				pictureBox1.Image = file;

			}

		}

		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{

			if (radioButton1.Checked == true)
			{

				ini.Write("APP", "check", "true");
				this.Hide();


			} else
			{

				ini.Write("APP", "check", "false");
				this.Hide();

			}

		}

		private void label1_Click(object sender, EventArgs e)
		{

			

		}

		private void button2_Click(object sender, EventArgs e)
		{

			using(colorDialog dia = new colorDialog("buttonColor","ButtonColor"))
			{

				if (dia.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{



				}

			}

		}
	}
}
