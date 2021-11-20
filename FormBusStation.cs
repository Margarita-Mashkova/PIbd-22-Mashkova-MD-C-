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
		/// Обработка нажатия кнопки "Добавить автобус"
		private void buttonSetAutobus_Click(object sender, EventArgs e)
		{
			if (busStationCollection.Keys.Count > 0)
			{
				var formAutobusConfig = new FormAutobusConfig();
				formAutobusConfig.AddEvent(AddAutobus);
				formAutobusConfig.Show();
			}
			else 
			{
				MessageBox.Show("Сначала создайте вокзал!");
			}

		}
		private void AddAutobus(Vehicle bus) 
		{
			if (bus != null && listBoxBusStations.SelectedIndex > -1)
			{
				if ((busStationCollection[listBoxBusStations.SelectedItem.ToString()]) + bus >= 0)
				{
					Draw();
				}
				else
				{
					MessageBox.Show("Автобус не удалось поставить");
				}
			}
		}
		/// Обработка нажатия пункта меню "Сохранить"
		private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (busStationCollection.SaveData(saveFileDialog.FileName))
				{
					MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		/// Обработка нажатия пункта меню "Загрузить"
		private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (busStationCollection.LoadData(openFileDialog.FileName))
				{
					MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ReloadLevels();
					Draw();
				}
				else
				{
					MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
    }
}
