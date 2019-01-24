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
		INIFile ene = new INIFile(Environment.CurrentDirectory + "/" + "background.ini");
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
				bunifuCustomLabel4.Text = " Developer Umut "+ Environment.NewLine +" The Infinity Translate " + VERSION;
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
				homepage1.BackColor = ColorTranslator.FromHtml("#252E3B");
				panel2.BackColor = ColorTranslator.FromHtml("#252E3B");
				sonsuzayar1.BackColor = ColorTranslator.FromHtml("#252E3B");
				sideMenu.BackColor = ColorTranslator.FromHtml("#1A2028");
				Header.BackColor = ColorTranslator.FromHtml("#9E9E9E");
				bunifuFlatButton1.Textcolor = Color.White;
				bunifuFlatButton2.Textcolor = Color.White;
				bunifuFlatButton3.Textcolor = Color.White;

			}
			Header.BackColor = ColorTranslator.FromHtml(ene.Read("APP", "upMenu"));
			sideMenu.BackColor = ColorTranslator.FromHtml(ene.Read("APP", "sideMenu"));
			sonsuzayar1.BackColor = ColorTranslator.FromHtml(ene.Read("APP", "sideMenu"));

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
				bunifuFlatButton3.Normalcolor = Color.Transparent;
				bunifuFlatButton3.Iconcolor = Color.Transparent;
				bunifuFlatButton2.Normalcolor = Color.Transparent;
				bunifuFlatButton2.Iconcolor = Color.Transparent;
				bunifuFlatButton1.Normalcolor = Color.DarkBlue;
				bunifuFlatButton1.Iconcolor = Color.DarkBlue;
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
				bunifuFlatButton3.Normalcolor = Color.Transparent;
				bunifuFlatButton3.Iconcolor = Color.Transparent;
				bunifuFlatButton2.Normalcolor = Color.DarkBlue;
				bunifuFlatButton2.Iconcolor = Color.DarkBlue;
				bunifuFlatButton1.Normalcolor = Color.Transparent;
				bunifuFlatButton1.Iconcolor = Color.Transparent;
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

			sonsuzayar1.Visible = true;
			yapimcilar1.Visible = false;
			homepage1.Visible = false;
			if (language().Contains("turkish")) { bunifuCustomLabel1.Text = "Sonsuz Çeviri " + VERSION + " | Ayarlar"; }
			else if (language().Contains("english")) { bunifuCustomLabel1.Text = "Infinity Translate " + VERSION + " | Settings"; }
			else if (language().Contains("arapca")) { bunifuCustomLabel1.Text = "لانهائية الترجمة " + VERSION + " | الإعدادات"; }
			new Thread(() =>
			{
				Thread.CurrentThread.Name = "ayarlar Thread";
				bunifuFlatButton3.Normalcolor = Color.DarkBlue;
				bunifuFlatButton3.Iconcolor = Color.DarkBlue;
				bunifuFlatButton2.Normalcolor = Color.Transparent;
				bunifuFlatButton2.Iconcolor = Color.Transparent;
				bunifuFlatButton1.Normalcolor = Color.Transparent;
				bunifuFlatButton1.Iconcolor = Color.Transparent;
			}).Start();
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

			CustomDesign ayar = new CustomDesign();
			ayar.Hide();
			ayar.Visible = true;

		}

		
	}
}
