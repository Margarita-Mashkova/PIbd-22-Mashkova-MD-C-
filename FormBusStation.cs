using System;
using System.Drawing;
using System.Windows.Forms;

namespace MashkovaCar
{
	public partial class FormBusStation : Form
	{
		private readonly BusStationCollection busStationCollection; /// Объект от класса-коллекции парковок
		public FormBusStation()
		{
			InitializeComponent();
			busStationCollection = new BusStationCollection(pictureBoxParking.Width, pictureBoxParking.Height);
		}
		/// Заполнение listBoxLevels
		private void ReloadLevels()
		{
			int index = listBoxBusStations.SelectedIndex;
			listBoxBusStations.Items.Clear();
			for (int i = 0; i < busStationCollection.Keys.Count; i++)
			{
				listBoxBusStations.Items.Add(busStationCollection.Keys[i]);
			}
			if (listBoxBusStations.Items.Count > 0 && (index == -1 || index >= listBoxBusStations.Items.Count))
			{
				listBoxBusStations.SelectedIndex = 0;
			}
			else if (listBoxBusStations.Items.Count > 0 && index > -1 && index < listBoxBusStations.Items.Count)
			{
				listBoxBusStations.SelectedIndex = index;
			}
		}
		/// Метод отрисовки автовокзала
		private void Draw()
		{
			if (listBoxBusStations.SelectedIndex > -1)
			//если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран 
			//и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
			{
				Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
				Graphics gr = Graphics.FromImage(bmp);
				busStationCollection[listBoxBusStations.SelectedItem.ToString()].Draw(gr);
				pictureBoxParking.Image = bmp;
			}
		}
		/// Обработка нажатия кнопки "Добавить автовокзал"
		private void buttonAddBusStation_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxBusStationName.Text))
			{
				MessageBox.Show("Введите название автовокзала", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			busStationCollection.AddBusStation(textBoxBusStationName.Text);
			ReloadLevels();
		}
		/// Обработка нажатия кнопки "Удалить автовокзал"
		private void buttonDelBusStation_Click(object sender, EventArgs e)
		{
			if (listBoxBusStations.SelectedIndex > -1)
			{
				if (MessageBox.Show($"Удалить автовокзал {textBoxBusStationName.Text}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					busStationCollection.DelBusStation(textBoxBusStationName.Text);
					ReloadLevels();
				}
			}
		}
		/// Обработка нажатия кнопки "Припарковать автобус"
		private void buttonSetAutobus_Click(object sender, EventArgs e)
		{
			if (listBoxBusStations.SelectedIndex > -1)
			{
				ColorDialog dialog = new ColorDialog();
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					var bus = new Autobus(100, 1000, dialog.Color);
					if (busStationCollection[listBoxBusStations.SelectedItem.ToString()] + bus >= 0)
					{
						Draw();
					}
					else
					{
						MessageBox.Show("Автовокзал переполнен");
					}
				}
			}
        }
		/// Обработка нажатия кнопки "Припарковать автобус с гармошкой"
		private void buttonSetAutobusModern_Click(object sender, EventArgs e)
		{
			if (listBoxBusStations.SelectedIndex > -1)
			{
				ColorDialog dialog = new ColorDialog();
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					ColorDialog dialogDop = new ColorDialog();
					if (dialogDop.ShowDialog() == DialogResult.OK)
					{
						var bus = new AutobusModern(100, 1000, dialog.Color, dialogDop.Color, true, true, true);
						if (busStationCollection[listBoxBusStations.SelectedItem.ToString()] + bus >= 0)
						{
							Draw();
						}
						else
						{
							MessageBox.Show("Автовокзал переполнен");
						}
					}
				}
			}
		}
		/// Обработка нажатия кнопки "Забрать"
		private void buttonTake_Click(object sender, EventArgs e)
		{
			if (listBoxBusStations.SelectedIndex > -1 && maskedTextBox.Text != "")
			{
				var bus = busStationCollection[listBoxBusStations.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
				if (bus != null)
				{
					FormAutobus form = new FormAutobus();
					form.SetBus(bus);
					form.ShowDialog();
				}
				Draw();
			}
		}
		/// Метод обработки выбора элемента на listBoxLevels
		private void listBoxBusStation_SelectedIndexChanged(object sender, EventArgs e)
		{
			Draw();
		}
    }
}
