using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Ceviri2
{
	public partial class Çeviri : Form
	{
		public Çeviri()
		{
			InitializeComponent();
		}
		INIFile ini = new INIFile(Environment.CurrentDirectory + "/" + "settings.ini");
		INIRead read = new INIRead();
		public string VERSION = "V2.2", text = "Sonsuz Çeviri";

		public bool olay = true;
		public string language()
		{

			return ini.Read("APP", "Language");

		}

		

		public void bunifuImageButton1_Click(object sender, EventArgs e)
		{

			trayIcon.Visible = false;
			Thread.Sleep(1000);
			Application.Exit();

		}
		private static NotifyIcon trayIcon;
		private static ContextMenu trayMenu;
		homepage home = new homepage();

		private static System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Çeviri));

		public void Form1_Load(object sender, EventArgs e)
		{ 
			if (!File.Exists(Environment.CurrentDirectory + "/background.ini"))
			{

				read.allset();

			} else
			{

				Header.BackColor = al("upMenu");
				sideMenu.BackColor = al("sideMenu");
				bunifuCustomLabel1.ForeColor = al("textColor");
				bunifuCustomLabel1.BackColor = al("textBackColor");
				bunifuCustomLabel2.ForeColor = al("textColor");
				bunifuCustomLabel2.BackColor = al("textBackColor");
				bunifuCustomLabel3.ForeColor = al("textColor");
				bunifuCustomLabel3.BackColor = al("textBackColor");
				bunifuCustomLabel4.ForeColor = al("textColor");
				bunifuCustomLabel4.BackColor = al("textBackColor");
				bunifuFlatButton1.Normalcolor = al("buttonBackColor");
				bunifuFlatButton1.Activecolor = al("sideButtonActiveColor");
				bunifuFlatButton1.OnHovercolor = al("sideButtonHoverColor");
				bunifuFlatButton1.Textcolor = al("buttonColor");
				bunifuFlatButton2.Normalcolor = al("buttonBackColor");
				bunifuFlatButton2.Activecolor = al("sideButtonActiveColor");
				bunifuFlatButton2.OnHovercolor = al("sideButtonHoverColor");
				bunifuFlatButton2.Textcolor = al("buttonColor");
				bunifuFlatButton3.Normalcolor = al("buttonBackColor");
				bunifuFlatButton3.Activecolor = al("sideButtonActiveColor");
				bunifuFlatButton3.OnHovercolor = al("sideButtonHoverColor");
				bunifuFlatButton3.Textcolor = al("buttonColor");
				label4.ForeColor = al("textColor");
				label4.BackColor = al("textBackColor");
				label5.ForeColor = al("textColor");
				label5.BackColor = al("textBackColor");
				panel2.BackColor = al("centerMenu");
			}
			trayMenu = new ContextMenu();
			trayIcon = new NotifyIcon();
			trayIcon.Text = "Sonsuz Çeviri™ - Made by bombacan";
			trayIcon.Icon = new Icon((System.Drawing.Icon)(resources.GetObject("$this.Icon")), 40, 40);
			trayIcon.ShowBalloonTip(1000, "Hoşgeldiniz", "Yapımcı Umut Özercan", ToolTipIcon.Info);
			trayIcon.ContextMenu = trayMenu;
			trayIcon.Visible = true;
			trayMenu.MenuItems.Add("Programı Kapat", programıKapatToolStripMenuItem_Click);
			

			if (language().Contains("turkish"))
			{

				bunifuCustomLabel1.Text = "Sonsuz Çeviri " + VERSION + " | Başlangıç";
				bunifuFlatButton1.Text = "    Anasayfa";
				bunifuFlatButton2.Text = "    Yapımcılar";
				bunifuFlatButton3.Text = "    Ayarlar";
				bunifuCustomLabel2.Text = "Dil: Türkçe (Varsayılan)";
				menulabel.Text = "MENU";
				bunifuCustomLabel3.Text = "Sonsuz Çeviriye Hoşgeldiniz";
				bunifuCustomLabel4.Text = " Yapımcı Umut " + Environment.NewLine + " Sonsuz Çeviri " + VERSION;
				pictureBox1.Visible = true;


			}
			else if (language().Contains("english"))
			{

				bunifuCustomLabel1.Text = "Infinite Translation " + VERSION + " | Start";
				bunifuFlatButton1.Text = "    Homepage";
				bunifuFlatButton2.Text = "    Producers";
				bunifuFlatButton3.Text = "    Settings";
				bunifuCustomLabel2.Text = "Language: English";
				menulabel.Text = "MENU";
				bunifuCustomLabel3.Text = "Welcome To Infinite Translation";
				bunifuCustomLabel4.Text = " Developer Umut " + Environment.NewLine + " The Infinity Translate " + VERSION;
				pictureBox1.Visible = false;

			}
			else if (language().Contains("arapca"))
			{

				bunifuCustomLabel1.Text = "لانهائية الترجمة " + VERSION + " | بداية";
				bunifuFlatButton1.Text = "    الصفحة الرئيسية";
				bunifuFlatButton2.Text = "    المنتجين";
				bunifuFlatButton3.Text = "    الإعدادات";
				bunifuCustomLabel2.Text = "اللغة: العربية";
				menulabel.Text = "القائمة";
				bunifuCustomLabel3.Text = "مرحبا بكم لانهائية الترجمة";
				bunifuCustomLabel4.Text = " نأمل منتج " + Environment.NewLine + " لانهائية الترجمة " + VERSION;
				pictureBox1.Visible = false;

			}
			else
			{

				bunifuCustomLabel1.Text = "Sonsuz Çeviri " + VERSION + " | Başlangıç";
				bunifuFlatButton1.Text = "    Anasayfa";
				bunifuFlatButton2.Text = "    Yapımcılar";
				bunifuFlatButton3.Text = "    Ayarlar";
				bunifuCustomLabel2.Text = "Dil: Türkçe (Varsayılan)";
				menulabel.Text = "MENU";
				bunifuCustomLabel3.Text = "Sonsuz Çeviriye Hoşgeldiniz";
				bunifuCustomLabel4.Text = " Yapımcı Umut " + Environment.NewLine + " Sonsuz Çeviri " + VERSION;

			}

		}

		public Color al(string value)
		{

			return ColorTranslator.FromHtml(read.getini(value));

		}

		public void bunifuImageButton2_Click(object sender, EventArgs e)
		{
			   if (sideMenu.Width == 45)
			   {

				   sideMenu.Visible = false;
				   sideMenu.Width = 212;
				   panelAnimator.ShowSync(sideMenu);
				   menulabel.Visible = true;
				   menubutton.Location = new Point(181, 6);
				   bunifuCustomLabel2.Visible = true;
					//logoAnimator.ShowSync(logo);
					label5.Visible = false;
				   label4.Visible = true;
				   bunifuCustomLabel3.Location = new Point(77, 29);
				   bunifuCustomLabel4.Location = new Point(175, 141);
				pictureBox1.Location = new Point(173, 363);

				   homepage an = new homepage();

				   an.Width = 588;

			   }
			   else
			   {

					//logoAnimator.Hide(logo);
					sideMenu.Width = 45;
				   sideMenu.Visible = false;
				   panelAnimator.ShowSync(sideMenu);
				   menulabel.Visible = false;
				   menubutton.Location = new Point(10, 6);
				   bunifuCustomLabel2.Visible = false;
				   label5.Visible = true;
				   label4.Visible = false;
				   bunifuCustomLabel3.Location = new Point(151, 58);
				   bunifuCustomLabel4.Location = new Point(240, 160);
				pictureBox1.Location = new Point(7, 363);

				   homepage1.Width = 755;

			   }

		}

		public void bunifuImageButton2_Click_1(object sender, EventArgs e)
		{

			WindowState = FormWindowState.Minimized;

		}

		public void anasayfabutton(String arg)
		{

			bunifuFlatButton1.Text = arg;

		}

		public void bunifuFlatButton1_Click(object sender, EventArgs e)
		{
			new Thread(() =>
			{
				Thread.CurrentThread.Name = "Anasayfa Thread";
				bunifuFlatButton3.Normalcolor = al("buttonBackColor");
				bunifuFlatButton3.Iconcolor = al("buttonBackColor");
				bunifuFlatButton2.Normalcolor = al("buttonBackColor");
				bunifuFlatButton2.Iconcolor = al("buttonBackColor");
				bunifuFlatButton1.Normalcolor = al("sideButtonActiveColor");
				bunifuFlatButton1.Iconcolor = al("sideButtonActiveColor");
			}).Start();
			
				
				homepage1.Visible = true;
			yapimcilar1.Visible = false;
				sonsuzayar1.Visible = false;
			if (language().Contains("turkish")) { bunifuCustomLabel1.Text = "Sonsuz Çeviri " + VERSION + " | AnaSayfa"; }
			else if (language().Contains("english")) { bunifuCustomLabel1.Text = "Infinity Translate " + VERSION + " | Homepage"; }
			else if (language().Contains("arapca")) { bunifuCustomLabel1.Text = "لانهائية الترجمة " + VERSION + " | الصفحة الرئيسية"; }
			//Program Button the click of false parameter 
			bunifuCustomLabel3.Visible = false;
				bunifuCustomLabel4.Visible = false;

		}

		public void bunifuFlatButton2_Click(object sender, EventArgs e)
		{

			new Thread(() =>
			{
				Thread.CurrentThread.Name = "Yapımcılar Thread";
				bunifuFlatButton3.Normalcolor = al("buttonBackColor");
				bunifuFlatButton3.Iconcolor = al("buttonBackColor");
				bunifuFlatButton2.Normalcolor = al("sideButtonActiveColor");
				bunifuFlatButton2.Iconcolor = al("sideButtonActiveColor");
				bunifuFlatButton1.Normalcolor = al("buttonBackColor");
				bunifuFlatButton1.Iconcolor = al("buttonBackColor");
			}).Start();

			homepage1.Visible = false;
			yapimcilar1.Visible = true;
			sonsuzayar1.Visible = false;

			if (language().Contains("turkish")) { bunifuCustomLabel1.Text = "Sonsuz Çeviri " + VERSION + " | Yapımcılar"; }
			else if (language().Contains("english")) { bunifuCustomLabel1.Text = "Infinity Translate " + VERSION + " | Producers"; }
			else if (language().Contains("arapca")) { bunifuCustomLabel1.Text = "لانهائية الترجمة " + VERSION + " | المنتجين"; }

			bunifuCustomLabel3.Visible = false;
			bunifuCustomLabel4.Visible = false;

		}

		public void bunifuFlatButton3_Click(object sender, EventArgs e)
		{
			new Thread(() =>
			{
				Thread.CurrentThread.Name = "Ayarlar Thread";
				bunifuFlatButton3.Normalcolor = al("sideButtonActiveColor");
				bunifuFlatButton3.Iconcolor = al("sideButtonActiveColor");
				bunifuFlatButton2.Normalcolor = al("buttonBackColor");
				bunifuFlatButton2.Iconcolor = al("buttonBackColor");
				bunifuFlatButton1.Normalcolor = al("buttonBackColor");
				bunifuFlatButton1.Iconcolor = al("buttonBackColor");
			}).Start();
			sonsuzayar1.Visible = true;
			yapimcilar1.Visible = false;
			homepage1.Visible = false;
			if (language().Contains("turkish")) { bunifuCustomLabel1.Text = "Sonsuz Çeviri " + VERSION + " | Ayarlar"; }
			else if (language().Contains("english")) { bunifuCustomLabel1.Text = "Infinity Translate " + VERSION + " | Settings"; }
			else if (language().Contains("arapca")) { bunifuCustomLabel1.Text = "لانهائية الترجمة " + VERSION + " | الإعدادات"; }
		}

		private void programıKapatToolStripMenuItem_Click(object sender, EventArgs e)
		{

			Application.Exit();

		}

		private void bunifuImageButton6_Click(object sender, EventArgs e)
		{

			WindowState = FormWindowState.Maximized;

		}

		private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
		{

			sonsuzayar1.Visible = true;
			homepage1.Visible = false;


		}

		private void sonsuzÇeviriV20ToolStripMenuItem_Click(object sender, EventArgs e)
		{

			MessageBox.Show("Sonsuz Çeviri ilk yapıldığında tamamen ödev için tasarlanmıştı sonra halka açık uygulama olarak verimeye başladık", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

		}

		private void sideMenu_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		public void refresh()
		{

			this.Hide();
			this.Visible = true;

		}

		
	}
}
