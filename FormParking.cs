using System;
using System.Drawing;
using System.Windows.Forms;

namespace MashkovaCar
{
	public partial class FormParking : Form
	{
		/// Объект от класса-парковки
		private readonly Parking<Autobus> parking;
		public FormParking()
		{
			InitializeComponent();
			parking = new Parking<Autobus>(pictureBoxParking.Width, pictureBoxParking.Height);
			Draw();
		}
		/// Метод отрисовки парковки
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
			Graphics gr = Graphics.FromImage(bmp);
			parking.Draw(gr);
			pictureBoxParking.Image = bmp;
		}
		/// Обработка нажатия кнопки "Припарковать автомобиль"
		private void buttonSetAutobus_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				var bus = new Autobus(100, 1000, dialog.Color);
				if (parking + bus >= 0)
				{
					Draw();
				}
				else
				{
					MessageBox.Show("Парковка переполнена");
				}
			}
		}
		/// Обработка нажатия кнопки "Припарковать автобус с гармошкой
		private void buttonSetAutobusModern_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				ColorDialog dialogDop = new ColorDialog();
				if (dialogDop.ShowDialog() == DialogResult.OK)
				{
					var bus = new AutobusModern(100, 1000, dialog.Color, dialogDop.Color, true, true, true);
					if (parking + bus >= 0)
					{
						Draw();
					}
					else
					{
						MessageBox.Show("Парковка переполнена");
					}
				}
			}
		}
		/// Обработка нажатия кнопки "Забрать"
		private void buttonTake_Click(object sender, EventArgs e)
		{
			if (maskedTextBox.Text != "")
			{
				var bus = parking - Convert.ToInt32(maskedTextBox.Text);
				if (bus != null)
				{
					FormAutobus form = new FormAutobus();
					form.SetBus(bus);
					form.ShowDialog();
				}
				Draw();
			}
		}
	}
}
