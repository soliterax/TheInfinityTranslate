using System;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ceviri2
{
	public partial class sonsuzayar : UserControl
	{
		public sonsuzayar()
		{
			InitializeComponent();
		}
		/** INI import */
		INIFile ini = new INIFile(Environment.CurrentDirectory + "/" + "settings.ini");
		/** INI File functions
		 *
		 * ini.Write("APP","Ayar","value");
		 * ini.Read("APP","Ayar");
		 *                                                    */
		private void sonsuzayar_Load(object sender, EventArgs e)
		{

			comboBox1.Text = "Türkçe";
			string language = ini.Read("APP", "Language");
			string background = ini.Read("APP", "Background");
			if (background.Contains("white")) { bunifuiOSSwitch1.Value = true; }
			else { bunifuiOSSwitch1.Value = false; }
			if(language.Contains("turkish"))
			{

				comboBox1.Text = "Türkçe";
				comboBox1.Items.Add("Arapça");
				comboBox1.Items.Add("İngilizce");
				comboBox1.Items.Add("Türkçe");
				bunifuCustomLabel1.Text = "Dil : ";
				bunifuCustomLabel1.Location = new Point(182, 73);
				label2.Text = "Arkaplan : ";
				label2.Location = new Point(155, 145);

			}
			else if (language.Contains("english"))
			{

				comboBox1.Text = "English";
				comboBox1.Items.Add("English");
				comboBox1.Items.Add("Arabic");
				comboBox1.Items.Add("Turkish");
				bunifuCustomLabel1.Text = "Language";
				bunifuCustomLabel1.Location = new Point(111, 73);
				label2.Text = "Background : ";
				label2.Location = new Point(135, 145);

			}
			else if (language.Contains("arapca"))
			{

				comboBox1.Text = "العربية";
				comboBox1.Items.Add("العربية");
				comboBox1.Items.Add("اللغة الإنجليزية");
				comboBox1.Items.Add("التركية");
				bunifuCustomLabel1.Text = "اللغة";
				bunifuCustomLabel1.Location = new Point(171, 73);
				label2.Text = "الخلفية : ";
				label2.Location = new Point(182, 145);

			} else
			{

				comboBox1.Text = "Türkçe";
				comboBox1.Items.Add("Arapça");
				comboBox1.Items.Add("İngilizce");
				comboBox1.Items.Add("Türkçe");
				bunifuCustomLabel1.Text = "Dil : ";
				bunifuCustomLabel1.Location = new Point(182, 73);
				label2.Text = "Arkaplan : ";
				label2.Location = new Point(155, 145);

			}

		}
		//save button
		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{
				
				
				

				Çeviri ceviri = new Çeviri();
				if (comboBox1.Text == "Türkçe" || comboBox1.Text == "Turkish" || comboBox1.Text == "التركية")
				{

					ini.Write("APP", "Language", "turkish");

				}
				else if (comboBox1.Text == "İngilizce" || comboBox1.Text == "English" || comboBox1.Text == "اللغة الإنجليزية")
				{

					ini.Write("APP", "Language", "english");

				}
				else if (comboBox1.Text == "Arapça" || comboBox1.Text == "Arabic" || comboBox1.Text == "العربية")
				{

					ini.Write("APP", "Language", "arapca");

				}
			if (bunifuiOSSwitch1.Value == true)
			{
				ini.Write("APP", "Background", "white");
			}
			else
			{
				ini.Write("APP", "Background", "black");
			}

			Application.Restart();
			

		}
		

		private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
		{
			

		}
	}
}
