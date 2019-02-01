using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceviri2
{
	class INIRead
	{
		public static INIFile ini = new INIFile(Environment.CurrentDirectory + "/background.ini");
		private static string buttonColor = ini.Read("APP","buttonColor");
		private static string buttonBackColor = ini.Read("APP", "buttonBackColor");
		private static string textColor = ini.Read("APP", "textColor");
		private static string textBackColor = ini.Read("APP", "textBackColor");
		private static string upMenu = ini.Read("APP", "upMenu");
		private static string sideMenu = ini.Read("APP", "sideMenu");
		private static string centerMenu = ini.Read("APP", "centerMenu");
		private static string homeButtonImage = ini.Read("APP", "homebuttonImage");
		private static string developerButtonImage = ini.Read("APP", "developerButtonImage");
		private static string settingsButtonImage = ini.Read("APP", "settingsButtonImage");
		private static string translateButtonImage = ini.Read("APP", "translateButtonImage");
		private static string comboboxBackColor = ini.Read("APP", "comboboxBackColor");
		private static string comboboxTextColor = ini.Read("APP", "comboboxTextColor");
		private static string sideButtonHoverColor = ini.Read("APP", "sideButtonHoverColor");
		private static string sideButtonActiveColor = ini.Read("APP", "sideButtonActiveColor");
		private static string Image = ini.Read("APP", "Image");

		public void setini(string arg, string value)
		{
			if (arg == "buttonColor")
			{

				buttonColor = value;

			}
			else if (arg == "buttonBackColor")
			{

				buttonBackColor = value;

			}
			else if (arg == "textColor")
			{

				textColor = value;

			}
			else if (arg == "textBackColor")
			{

				textBackColor = value;

			}
			else if (arg == "upMenu")
			{

				upMenu = value;

			}
			else if (arg == "sideMenu")
			{

				sideMenu = value;

			}
			else if (arg == "centerMenu")
			{

				centerMenu = value;

			}
			else if (arg == "sideButtonHoverColor")
			{

				sideButtonHoverColor = value;

			}
			else if (arg == "sideButtonActiveColor")
			{

				sideButtonActiveColor = value;

			}
			else if (arg == "homeButtonImage")
			{

				homeButtonImage = value;

			}
			else if (arg == "developerButtonImage")
			{

				developerButtonImage = value;

			}
			else if (arg == "settingsButtonImage")
			{

				settingsButtonImage = value;

			}
			else if (arg == "translateButtonImage")
			{

				translateButtonImage = value;

			}
			else if (arg == "comboboxBackColor")
			{

				comboboxBackColor = value;

			}
			else if (arg == "comboboxTextColor")
			{

				comboboxTextColor = value;

			}
			else if (arg == "Image") 
			{

				Image = value;

			}
		}
		public string getini(string arg)
		{

			string yazi;

			if (arg == "buttonColor")
			{

				yazi = buttonColor;

			}
			else if (arg == "buttonBackColor")
			{

				yazi = buttonBackColor;

			}
			else if (arg == "textColor")
			{

				yazi = textColor;

			}
			else if (arg == "textBackColor")
			{

				yazi = textBackColor;

			}
			else if (arg == "upMenu")
			{

				yazi = upMenu;

			}
			else if (arg == "sideMenu")
			{

				yazi = sideMenu;

			}
			else if (arg == "centerMenu")
			{

				yazi = centerMenu;

			}
			else if (arg == "sideButtonHoverColor")
			{

				yazi = sideButtonHoverColor;

			}
			else if (arg == "sideButtonActiveColor")
			{

				yazi = sideButtonActiveColor;

			}
			else if (arg == "homeButtonImage")
			{

				yazi = homeButtonImage;

			}
			else if (arg == "developerButtonImage")
			{

				yazi = developerButtonImage;

			}
			else if (arg == "settingsButtonImage")
			{

				yazi = settingsButtonImage;

			}
			else if (arg == "translateButtonImage")
			{

				yazi = translateButtonImage;

			}
			else if (arg == "comboboxBackColor")
			{

				yazi = comboboxBackColor;

			}
			else if (arg == "comboboxTextColor")
			{

				yazi = comboboxTextColor;

			}
			else if (arg == "Image")
			{

				yazi = Image;

			}
			else
			{

				return null;

			}
			return yazi;
		}
		public void iniWrite()
		{

			ini.Write("APP", "buttonColor", buttonColor);
			ini.Write("APP", "buttonBackColor", buttonBackColor);
			ini.Write("APP", "sideButtonHoverColor", sideButtonHoverColor);
			ini.Write("APP", "sideButtonActiveColor", sideButtonActiveColor);
			ini.Write("APP", "textColor", textColor);
			ini.Write("APP", "textBackColor", textBackColor);
			ini.Write("APP", "upMenu", upMenu);
			ini.Write("APP", "sideMenu", sideMenu);
			ini.Write("APP", "centerMenu", centerMenu);
			ini.Write("APP", "homebuttonImage", homeButtonImage);
			ini.Write("APP", "developerButtonImage", developerButtonImage);
			ini.Write("APP", "settingsButtonImage", settingsButtonImage);
			ini.Write("APP", "translateButtonImage", translateButtonImage);
			ini.Write("APP", "comboboxBackColor", comboboxBackColor);
			ini.Write("APP", "comboboxTextColor", comboboxTextColor);
			ini.Write("APP", "Image", Image);

		}

		public void allset()
		{

			ini.Write("APP", "buttonColor", "#1A2028");
			ini.Write("APP", "buttonBackColor", "#1A2028");
			ini.Write("APP", "sideButtonHoverColor", "#8B0000");
			ini.Write("APP", "sideButtonActiveColor", "#00008B");
			ini.Write("APP", "textColor", "#080000");
			ini.Write("APP", "upMenu", "#9E9E9E");
			ini.Write("APP", "sideMenu", "#1A2028");
			ini.Write("APP", "centerMenu", "#252E3B");
			ini.Write("APP", "homebuttonImage", "normal");
			ini.Write("APP", "developerButtonImage", "normal");
			ini.Write("APP", "settingsButtonImage", "normal");
			ini.Write("APP", "translateButtonImage", "normal");
			ini.Write("APP", "comboboxBackColor", "#1C1C1C");
			ini.Write("APP", "comboboxTextColor", "#0B6697");
			ini.Write("APP", "Image", "normalImage");
			ini.Write("APP", "check", "true");

		}
		public void saveChanges()
		{

			ini.Write("APP", "buttonColor", buttonColor);
			ini.Write("APP", "buttonBackColor", buttonBackColor);
			ini.Write("APP", "sideButtonHoverColor", sideButtonHoverColor);
			ini.Write("APP", "sideButtonActiveColor", sideButtonActiveColor);
			ini.Write("APP", "textColor", textColor);
			ini.Write("APP", "textBackColor", textBackColor);
			ini.Write("APP", "upMenu", upMenu);
			ini.Write("APP", "sideMenu", sideMenu);
			ini.Write("APP", "centerMenu", centerMenu);
			ini.Write("APP", "homebuttonImage", homeButtonImage);
			ini.Write("APP", "developerButtonImage", developerButtonImage);
			ini.Write("APP", "settingsButtonImage", settingsButtonImage);
			ini.Write("APP", "translateButtonImage", translateButtonImage);
			ini.Write("APP", "comboboxBackColor", comboboxBackColor);
			ini.Write("APP", "comboboxTextColor", comboboxTextColor);
			ini.Write("APP", "Image", Image);

		}

		public void refresh()
		{

			buttonColor = ini.Read("APP", "buttonColor");
			buttonBackColor = ini.Read("APP", "buttonBackColor");
			textColor = ini.Read("APP", "textColor");
			textBackColor = ini.Read("APP", "textBackColor");
			upMenu = ini.Read("APP", "upMenu");
			sideMenu = ini.Read("APP", "sideMenu");
			centerMenu = ini.Read("APP", "centerMenu");
			homeButtonImage = ini.Read("APP", "homebuttonImage");
			developerButtonImage = ini.Read("APP", "developerButtonImage");
			settingsButtonImage = ini.Read("APP", "settingsButtonImage");
			translateButtonImage = ini.Read("APP", "translateButtonImage");
			comboboxBackColor = ini.Read("APP", "comboboxBackColor");
			comboboxTextColor = ini.Read("APP", "comboboxTextColor");
			sideButtonHoverColor = ini.Read("APP", "sideButtonHoverColor");
			sideButtonActiveColor = ini.Read("APP", "sideButtonActiveColor");
			Image = ini.Read("APP", "Image");

		}

	}
}
