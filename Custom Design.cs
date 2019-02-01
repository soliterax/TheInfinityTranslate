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
	public partial class Custom_Design : Form
	{
		public Custom_Design()
		{
			InitializeComponent();

			this.BackColor = ColorTranslator.FromHtml(read.getini("centerMenu"));
			centerMenu.BackColor = ColorTranslator.FromHtml(read.getini("centerMenu"));
			sideMenu.BackColor = ColorTranslator.FromHtml(read.getini("sideMenu"));
			upMenu.BackColor = ColorTranslator.FromHtml(read.getini("upMenu"));
		}
		private INIFile ini = new INIFile(Environment.CurrentDirectory + "/background.ini");
		private INIRead read = new INIRead();

		private void upMenu_Click(object sender, EventArgs e)
		{
			colorDialog dia = new colorDialog("upMenu", "UpMenu");
			if (dia.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{



			}
		}

		private void sideMenu_Click(object sender, EventArgs e)
		{
			colorDialog dia = new colorDialog("sideMenu", "SideMenu");
			if (dia.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{



			}
		}

		public void centerMenu_Click(object sender, EventArgs e)
		{
			colorDialog dia = new colorDialog("centerMenu", "CenterMenu");
			if (dia.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{



			}
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			upMenu.Visible = true;
			sideMenu.Visible = true;
			centerMenu.Visible = true;
			pictureBox1.Visible = false;

		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			upMenu.Visible = false;
			sideMenu.Visible = false;
			centerMenu.Visible = false;
			pictureBox1.Visible = true;
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

			}
			else
			{

				ini.Write("APP", "check", "false");
				this.Hide();

			}
			read.saveChanges();

		}

		private void label1_Click(object sender, EventArgs e)
		{



		}

		private void button2_Click(object sender, EventArgs e)
		{
			colorDialog dia = new colorDialog("buttonColor", "ButtonColor");
			colorDialog die = new colorDialog("buttonBackColor", "ButtonBackColor");


			if (dia.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				
				if (die.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{

					read.saveChanges();

				}
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox1_Click(object sender, EventArgs e)
		{

			using(colorDialog dia = new colorDialog("comboboxTextColor","Combo Box Text Color"))
			{

				if(dia.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{

					using(colorDialog die = new colorDialog("comboboxBackColor","Combo Box Background Color"))
					{

						if (die.ShowDialog() == System.Windows.Forms.DialogResult.OK)
						{

							read.saveChanges();
							die.Close();

						}
						else
						{

							die.Close();

						}
						
					}
					dia.Close();
				}
				else
				{

					dia.Close();

				}
				
			}

		}

		private void ComboBox1_Click_1(object sender, EventArgs e)
		{



		}

		private void Button1_Click(object sender, EventArgs e)
		{

			read.allset();

		}
	}
}
