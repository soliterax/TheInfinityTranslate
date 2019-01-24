using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace Ceviri2
{
	public partial class homepage : UserControl
	{
		public homepage()
		{
			InitializeComponent();
		}
		INIFile ini = new INIFile(Environment.CurrentDirectory + "/settings.ini");
		INIFile tema = new INIFile(Environment.CurrentDirectory + "/background.ini");
		private const string finalURL =
		"https://translate.yandex.net/api/v1.5/tr.json/translate?lang=COUNTRYKEY&key=" +
		"trnsl.1.1.20180403T234128Z.5790699ba62f5d0f.ba2a4bb3f66abe408a4b0d973f443a7a649054ff";

		private static bool runningTwo = false;
		private static System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Çeviri));

		private void homepage_Load(object sender, EventArgs e)
		{
			yazi();
			string background = tema.Read("APP", "Background");
			textBox1.BackColor = ColorTranslator.FromHtml(background);
			textBox2.BackColor = ColorTranslator.FromHtml(background);
			comboBox1.BackColor = ColorTranslator.FromHtml(background);
			comboBox2.BackColor = ColorTranslator.FromHtml(background);
			
		}

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
					return "Hata Oluştu: #" + response.StatusCode.ToString();
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

		private void cevirme()
		{

			String countryKey = "";

			String countryKey1 = "";
			String countryKey2 = "";

			if (comboBox1.Text == "Türkçe" || comboBox1.Text == "Turkish" || comboBox1.Text == "التركية")
			{

				countryKey1 = "tr";

			}
			
			else if (comboBox1.Text == "İngilizce" || comboBox1.Text == "English" || comboBox1.Text == "اللغة الإنجليزية")
			{

				countryKey1 = "en";

			}

			else if (comboBox1.Text == "Almanca" || comboBox1.Text == "German" || comboBox1.Text == "الألمانية")
			{

				countryKey1 = "de";

			}

			else if (comboBox1.Text == "Rusça" || comboBox1.Text == "Russian" || comboBox1.Text == "الروسية")
			{

				countryKey1 = "ru";

			}

			else if (comboBox1.Text == "Fransızca" || comboBox1.Text == "French" || comboBox1.Text == "الفرنسية")
			{

				countryKey1 = "fr";

			}

			else if (comboBox1.Text == "Arapça" || comboBox1.Text == "Arabic" || comboBox1.Text == "العربية")
			{

				countryKey1 = "ar";

			}

			else if (comboBox1.Text == "Korece" || comboBox1.Text == "Korean" || comboBox1.Text == "الكورية")
			{

				countryKey1 = "ko";

			}

			else if (comboBox1.Text == "İspanyolca" || comboBox1.Text == "Spanish" || comboBox1.Text == "الإسبانية")
			{

				countryKey1 = "es";
				
			}

			/*-------------------------------------------------------------------------------------------------------------------*/

			if (comboBox2.Text == "Türkçe" || comboBox2.Text == "Turkish" || comboBox2.Text == "التركية")
			{

				countryKey2 = "tr";

			}

			else if (comboBox2.Text == "İngilizce" || comboBox2.Text == "English" || comboBox2.Text == "اللغة الإنجليزية")
			{

				countryKey2 = "en";

			}

			else if (comboBox2.Text == "Almanca" || comboBox2.Text == "German" || comboBox2.Text == "الألمانية")
			{

				countryKey2 = "de";

			}

			else if (comboBox2.Text == "Rusça" || comboBox2.Text == "Russian" || comboBox2.Text == "الروسية")
			{

				countryKey2 = "ru";

			}

			else if (comboBox2.Text == "Fransızca" || comboBox2.Text == "French" || comboBox2.Text == "الفرنسية")
			{

				countryKey2 = "fr";

			}

			else if (comboBox2.Text == "Arapça" || comboBox2.Text == "Arabic" || comboBox2.Text == "العربية")
			{

				countryKey2 = "ar";

			}

			else if (comboBox2.Text == "Korece" || comboBox2.Text == "Korean" || comboBox2.Text == "الكورية")
			{

				countryKey2 = "ko";

			}

			else if (comboBox2.Text == "İspanyolca" || comboBox2.Text == "Spanish" || comboBox2.Text == "الإسبانية")
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

			textBox2.Text = "Lütfen Bekleyin...";



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

		

		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{

			if (e.KeyCode == Keys.Enter)
			{

				cevirme();

			}

		}

		

		
		public void yazi()
		{
			
			string dil = ini.Read("APP", "Language");
			if (dil.Contains("turkish"))
			{

				textBox1.Text = "Çevrilecek Metin";
				textBox2.Text = "Çevrilen Metin";
				comboBox1.Text = "Türkçe";
				comboBox2.Text = "İngilizce";
				comboBox1.Items.Add("Arapça");
				comboBox1.Items.Add("Almanca");
				comboBox1.Items.Add("Fransızca");
				comboBox1.Items.Add("İngilizce");
				comboBox1.Items.Add("İspanyolca");
				comboBox1.Items.Add("Korece");
				comboBox1.Items.Add("Rusça");
				comboBox1.Items.Add("Türkçe");
				comboBox2.Items.Add("Arapça");
				comboBox2.Items.Add("Almanca");
				comboBox2.Items.Add("Fransızca");
				comboBox2.Items.Add("İngilizce");
				comboBox2.Items.Add("İspanyolca");
				comboBox2.Items.Add("Korece");
				comboBox2.Items.Add("Rusça");
				comboBox2.Items.Add("Türkçe");


			} else if (dil.Contains("english"))
			{

				textBox1.Text = "The Text To Be Translated";
				textBox2.Text = "Translated Text";
				comboBox1.Text = "English";
				comboBox2.Text = "Turkish";
				comboBox1.Items.Add("Arabic");
				comboBox1.Items.Add("German");
				comboBox1.Items.Add("French");
				comboBox1.Items.Add("English");
				comboBox1.Items.Add("Spanish");
				comboBox1.Items.Add("Korean");
				comboBox1.Items.Add("Russian");
				comboBox1.Items.Add("Turkish");
				comboBox2.Items.Add("Arabic");
				comboBox2.Items.Add("German");
				comboBox2.Items.Add("French");
				comboBox2.Items.Add("English");
				comboBox2.Items.Add("Spanish");
				comboBox2.Items.Add("Korean");
				comboBox2.Items.Add("Russian");
				comboBox2.Items.Add("Turkish");

			} else if (dil.Contains("arapca"))
			{

				textBox1.Text = "النص المراد ترجمته";
				textBox2.Text = "ترجمة النص";
				comboBox1.Text = "العربية";
				comboBox2.Text = "التركية";
				comboBox1.Items.Add("العربية");
				comboBox1.Items.Add("الألمانية");
				comboBox1.Items.Add("الفرنسية");
				comboBox1.Items.Add("اللغة الإنجليزية");
				comboBox1.Items.Add("الإسبانية");
				comboBox1.Items.Add("الكورية");
				comboBox1.Items.Add("الروسية");
				comboBox1.Items.Add("التركية");
				comboBox2.Items.Add("العربية");
				comboBox2.Items.Add("الألمانية");
				comboBox2.Items.Add("الفرنسية");
				comboBox2.Items.Add("اللغة الإنجليزية");
				comboBox2.Items.Add("الإسبانية");
				comboBox2.Items.Add("الكورية");
				comboBox2.Items.Add("الروسية");
				comboBox2.Items.Add("التركية");

			} else
			{

				textBox1.Text = "Çevrilecek Metin";
				textBox2.Text = "Çevrilen Metin";
				comboBox1.Text = "Türkçe";
				comboBox2.Text = "İngilizce";
				comboBox1.Items.Add("Arapça");
				comboBox1.Items.Add("Almanca");
				comboBox1.Items.Add("Fransızca");
				comboBox1.Items.Add("İngilizce");
				comboBox1.Items.Add("İspanyolca");
				comboBox1.Items.Add("Korece");
				comboBox1.Items.Add("Rusça");
				comboBox1.Items.Add("Türkçe");
				comboBox2.Items.Add("Arapça");
				comboBox2.Items.Add("Almanca");
				comboBox2.Items.Add("Fransızca");
				comboBox2.Items.Add("İngilizce");
				comboBox2.Items.Add("İspanyolca");
				comboBox2.Items.Add("Korece");
				comboBox2.Items.Add("Rusça");
				comboBox2.Items.Add("Türkçe");

			}


		}

		private void textBox1_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
		}

		private void bunifuImageButton3_Click_1(object sender, EventArgs e)
		{
			string paste = Clipboard.GetText();

			textBox1.Text = paste;
		}

		private void bunifuImageButton2_Click_1(object sender, EventArgs e)
		{
			string copy = textBox2.Text;
			Clipboard.SetText(copy);
		}

		private void bunifuImageButton4_Click(object sender, EventArgs e)
		{

			string degis = comboBox2.Text;
			comboBox2.Text = comboBox1.Text;
			comboBox1.Text = degis;

		}

		private void textBox1_DoubleClick(object sender, EventArgs e)
		{

			textBox1.Clear();

		}

		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{

			cevirme();

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
