using System;
using System.Threading;
using System.Windows.Forms;

namespace Ceviri2
{
	public partial class yukleniyor : Form
	{
		public yukleniyor()
		{
			InitializeComponent();
		}
		private void yukleniyor_Load(object sender, EventArgs e)
		{

			new Thread(() =>
			{

				while (true)
				{

					for (int i = 30; i<100; i++)
					{

						bunifuCircleProgressbar1.Value = i;

					}
					for (int i = 100; i>30; i--)
					{

						bunifuCircleProgressbar1.Value = i;

					}

				}

			}).Start();

		}
	}
}
