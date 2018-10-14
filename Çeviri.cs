using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ceviri2
{
	public partial class Çeviri : Form
	{
		public Çeviri()
		{
			InitializeComponent();
		}

		public void bunifuImageButton1_Click(object sender, EventArgs e)
		{

			Application.Exit();

		}

		public void Form1_Load(object sender, EventArgs e)
		{
			
			trayMenu = new ContextMenu();
			

			trayIcon = new NotifyIcon();
			trayIcon.Text = "Sonsuz Çeviri™ - Made by bombacan";
			trayIcon.Icon = new Icon((System.Drawing.Icon)(resources.GetObject("$this.Icon")), 40, 40);
			trayIcon.ShowBalloonTip(1000, "Hoşgeldiniz", "Yapımcı Umut Özercan", ToolTipIcon.Info);
			trayIcon.ContextMenu = trayMenu;
			trayIcon.Visible = true;

			comboBox1.Text = "İngilizce";
			comboBox2.Text = "Türkçe";

			this.textBox1.GotFocus += new System.EventHandler(ceviri_Focus);
			this.textBox1.LostFocus += new System.EventHandler(ceviri_UnFocus);
			 

		}

		private const string finalURL =
		"https://translate.yandex.net/api/v1.5/tr.json/translate?lang=COUNTRYKEY&key=" +
		"trnsl.1.1.20180403T234128Z.5790699ba62f5d0f.ba2a4bb3f66abe408a4b0d973f443a7a649054ff";

		private static bool waterMarkFour = true;
		private static bool waterMarkFive = true;

		private static bool runningTwo = false;

		private static NotifyIcon trayIcon;
		private static ContextMenu trayMenu;

		private static System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Çeviri));

		private static string FirstCharToUpper(string input)
		{

			return input.First().ToString().ToUpper() + input.Substring(1);

		}

		private string doPost(string URL, string postData)
		{

			try
			{

				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);

				request.Method = WebRequestMethods.Http.Post;
				request.ContentType = "application/x-www-form-urlencoded";
				request.Referer = "https://www.lifemcserver.com/";
				request.UserAgent = "Mozilla/5.0";
				request.Proxy = null;

				var data = Encoding.UTF8.GetBytes(postData);

				using (Stream stream = request.GetRequestStream())
				{

					stream.Write(data, 0, data.Length);
					stream.Close();

				}

				HttpWebResponse response = (HttpWebResponse)request.GetResponse();

				if (!response.StatusCode.Equals(HttpStatusCode.OK))
				{

					return "Hata oluştu: #" + response.StatusCode.ToString();

				}

				Stream streamResponse = response.GetResponseStream();
				StreamReader streamRead = new StreamReader(streamResponse);

				Char[] readBuff = new Char[256];
				int count = streamRead.Read(readBuff, 0, 256);

				String responseStr = "";

				while (count > 0)
				{
					String outputData = new String(readBuff, 0, count);
					responseStr = responseStr + outputData;
					count = streamRead.Read(readBuff, 0, 256);
				}

				streamResponse.Close();
				streamRead.Close();
				response.Close();
				request.Abort();

				responseStr = responseStr.ToString().Trim();

				if (responseStr.Replace(" ", "").Length < 1 || responseStr.ToLower().Contains("invalid") || responseStr.ToLower().Contains("error"))
				{
					return "Bilinmeyen hata oluştu :/";
				}

				return responseStr;

			}
			catch (WebException we)
			{

				return "Hata oluştu: #" + ((HttpWebResponse)we.Response).StatusCode.ToString();

			}
			catch (Exception)
			{

				return "Bilinmeyen hata oluştu :/";

			}
		}

		private void bunifuImageButton3_Click(object sender, EventArgs e)
		{

			String countryKey = "";

			String countryKey1 = "";
			String countryKey2 = "";

			if (comboBox1.Text == "Türkçe")
			{

				countryKey1 = "tr";

			}

			else if (comboBox1.Text == "İngilizce")
			{

				countryKey1 = "en";

			}

			else if (comboBox1.Text == "Almanca")
			{

				countryKey1 = "de";

			}

			else if (comboBox1.Text == "Rusça")
			{

				countryKey1 = "ru";

			}

			else if (comboBox1.Text == "Fransızca")
			{

				countryKey1 = "fr";

			}

			else if (comboBox1.Text == "Arapça")
			{

				countryKey1 = "ar";

			}

			else if (comboBox1.Text == "Korece")
			{

				countryKey1 = "ko";

			}

			else if (comboBox1.Text == "İspanyolca")
			{

				countryKey1 = "es";

			}

			/*-------------------------------------------------------------------------------------------------------------------*/

			if (comboBox2.Text == "Türkçe")
			{

				countryKey2 = "tr";

			}

			else if (comboBox2.Text == "İngilizce")
			{

				countryKey2 = "en";

			}

			else if (comboBox2.Text == "Almanca")
			{

				countryKey2 = "de";

			}

			else if (comboBox2.Text == "Rusça")
			{

				countryKey2 = "ru";

			}

			else if (comboBox2.Text == "Fransızca")
			{

				countryKey2 = "fr";

			}

			else if (comboBox2.Text == "Arapça")
			{

				countryKey2 = "ar";

			}

			else if (comboBox2.Text == "Korece")
			{

				countryKey2 = "ko";

			}

			else if (comboBox2.Text == "İspanyolca")
			{

				countryKey2 = "es";

			}

			countryKey = countryKey1 + "-" + countryKey2;

			if (runningTwo)
			{
				return;
			}

			if (textBox1.Text.Length < 1 || textBox1.Text.Equals("Çevirilecek metin..."))
			{
				MessageBox.Show("Lütfen çevirmek için bir metin girin!", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			runningTwo = true;

			textBox2.Text = "Lütfen bekleyin...";

			new Thread(() => {

				Thread.CurrentThread.IsBackground = true;

				this.Invoke(new MethodInvoker(() => textBox1.Text = FirstCharToUpper(textBox1.Text)));

				string resp = doPost(finalURL.Replace("COUNTRYKEY", countryKey + ""), "text=" + textBox1.Text);

				if (resp.ToString().ToLower().Contains("badrequest"))
				{

					this.Invoke(new MethodInvoker(() => textBox2.Text = "Lütfen geçerli diller girin."));
					runningTwo = false;
					return;

				}

				if (resp.ToString().ToLower().Contains("hata"))
				{
					this.Invoke(new MethodInvoker(() => textBox2.Text = resp));
					runningTwo = false;
					return;
				}

				var json = JsonConvert.DeserializeObject<dynamic>(resp.Replace("[", "").Replace("]", ""));
				string tr = json.text;

				tr = FirstCharToUpper(tr);

				this.Invoke(new MethodInvoker(() => textBox2.Text = tr));

				this.Invoke(new MethodInvoker(() => runningTwo = false));

			}).Start();

		}

		public void ceviri_Focus(object o, EventArgs e)
		{

			if (waterMarkFour)
			{

				waterMarkFour = false;
				this.textBox1.Text = "";
				this.textBox1.ForeColor = Color.Black;

			}

		}

		public void ceviri_UnFocus(object o, EventArgs e)
		{

			if (!waterMarkFour && string.IsNullOrEmpty(this.textBox1.Text))
			{

				waterMarkFour = true;
				this.textBox1.Text = "Çevirilecek metin...";
				this.textBox1.ForeColor = Color.Gray;

			}

		}

		public void ceviri2_Focus(object o, EventArgs e)
		{

			if (waterMarkFive)
			{

				waterMarkFive = false;
				this.comboBox1.Text = "";
				this.comboBox1.ForeColor = Color.Black;

			}

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
				label1.Location = new Point(55, 29);
				label2.Location = new Point(34, 105);
				label3.Location = new Point(55, 189);

			} else {

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
				label1.Location = new Point(130, 29);
				label2.Location = new Point(104, 127);
				label3.Location = new Point(142, 210);

			}

		}

		public void bunifuImageButton2_Click_1(object sender, EventArgs e)
		{

			WindowState = FormWindowState.Minimized;

		}

		

		public void bunifuFlatButton1_Click(object sender, EventArgs e)
		{

			bunifuFlatButton2.BackColor = Color.Transparent;
			bunifuFlatButton1.BackColor = Color.Blue;

			bunifuCustomLabel1.Text = "Sonsuz Çeviri V2.0 | AnaSayfa";

			//Program Button the click of false parameter 
			bunifuCustomLabel3.Visible = false;
			bunifuCustomLabel4.Visible = false;
			label1.Visible = false;
			label2.Visible = false;
			label3.Visible = false;
			
			//Program button the click of true parameter
			textBox1.Visible = true;
			textBox2.Visible = true;
			bunifuImageButton3.Visible = true;
			comboBox1.Visible = true;
			comboBox2.Visible = true;
			bunifuImageButton5.Visible = true;

		}

		public void bunifuFlatButton2_Click(object sender, EventArgs e)
		{

			bunifuFlatButton1.BackColor = Color.Transparent;
			bunifuFlatButton2.BackColor = Color.Blue;

			bunifuCustomLabel1.Text = "Sonsuz Çeviri V2.0 | Yapımcılar";

			bunifuCustomLabel3.Visible = false;
			bunifuCustomLabel4.Visible = false;
			textBox1.Visible = false;
			textBox2.Visible = false;
			bunifuImageButton3.Visible = false;
			comboBox1.Visible = false;
			comboBox2.Visible = false;
			bunifuImageButton5.Visible = false;
			label1.Visible = true;
			label2.Visible = true;
			label3.Visible = true;

		}

		public void bunifuImageButton5_Click(object sender, EventArgs e)
		{

			String degis = null;

			degis = comboBox1.Text;
			comboBox1.Text = comboBox2.Text;
			comboBox2.Text = degis;

		}

		public void bunifuFlatButton3_Click(object sender, EventArgs e)
		{

			WindowState = FormWindowState.Maximized;

		}

		private void programıKapatToolStripMenuItem_Click(object sender, EventArgs e)
		{

			Application.Exit();

		}

		private void bunifuImageButton6_Click(object sender, EventArgs e)
		{

		}
	}
}
