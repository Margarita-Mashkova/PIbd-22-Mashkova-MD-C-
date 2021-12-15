using NLog;
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace MashkovaCar
{
	public partial class FormBusStation : Form
	{
		private readonly BusStationCollection busStationCollection; /// Объект от класса-коллекции парковок
		private readonly Logger logger; //Логгер
		public FormBusStation()
		{
			InitializeComponent();
			busStationCollection = new BusStationCollection(pictureBoxParking.Width, pictureBoxParking.Height);
			logger = LogManager.GetCurrentClassLogger();
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
			logger.Info($"Добавили автовокзал {textBoxBusStationName.Text}");
			busStationCollection.AddBusStation(textBoxBusStationName.Text);
			ReloadLevels();
		}
		/// Обработка нажатия кнопки "Удалить автовокзал"
		private void buttonDelBusStation_Click(object sender, EventArgs e)
		{
			if (listBoxBusStations.SelectedIndex > -1)
			{
				if (MessageBox.Show($"Удалить автовокзал {listBoxBusStations.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					logger.Info($"Удалили автовокзал {listBoxBusStations.SelectedItem.ToString()}");
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
				try
				{
					var bus = busStationCollection[listBoxBusStations.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
					if (bus != null)
					{
						FormAutobus form = new FormAutobus();
						form.SetBus(bus);
						form.ShowDialog();
						logger.Info($"Изъят автобус {bus} с места {maskedTextBox.Text}");
					}
					Draw();
				}
				catch (BusStationNotFoundException ex)
				{
					logger.Warn($"Попытались взять автобус с несуществующего места на автовокзале {listBoxBusStations.SelectedItem.ToString()}");
					MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		/// Метод обработки выбора элемента на listBoxLevels
		private void listBoxBusStation_SelectedIndexChanged(object sender, EventArgs e)
		{
			logger.Info($"Перешли на автовокзал {listBoxBusStations.SelectedItem.ToString()}");
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
		/// Метод добавления автобуса
		private void AddAutobus(Vehicle bus)
		{
			if (bus != null && listBoxBusStations.SelectedIndex > -1)
			{
				try
				{
					if ((busStationCollection[listBoxBusStations.SelectedItem.ToString()]) + bus >= 0)
					{
						Draw();
						logger.Info($"Добавлен автобус {bus}");
					}
					else
					{
						MessageBox.Show("Автобус не удалось поставить");
					}
					Draw();
				}
				catch (BusStationOverflowException ex)
				{
					logger.Warn($"Попытались поставить автобус в заполненный автовокзал");
					MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (BusStationAlreadyHaveException ex)
				{
					MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		/// Обработка нажатия пункта меню "Сохранить"
		private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					busStationCollection.SaveData(saveFileDialog.FileName);
					MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
					logger.Info("Сохранено в файл " + saveFileDialog.FileName);
				}
				catch (Exception ex)
				{
					logger.Warn("Неудалось сохранить файл по неизвестным причинам");
					MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		/// Обработка нажатия пункта меню "Загрузить"
		private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					busStationCollection.LoadData(openFileDialog.FileName);
					MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
					logger.Info("Загружено из файла " + openFileDialog.FileName);
					ReloadLevels();
					Draw();
				}
				catch (FileNotFoundException ex)
				{
					logger.Warn($"Попытались загрузить несуществующий файл");
					MessageBox.Show(ex.Message, "Файл не существует", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				}
				catch (FormatException ex)
				{
					logger.Warn($"Попытались загрузить файл неверного формата");
					MessageBox.Show(ex.Message, "Файл не соответствует требуемому формату", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				}
				catch (TypeLoadException ex)
				{
					logger.Warn($"Попытка загрузки неизвестного типа объекта");
					MessageBox.Show(ex.Message, "Неверный тип загружаемого объекта", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					logger.Warn("Не удалось загрузить файл по неизвестным причинам");
					MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

        private void buttonSort_Click(object sender, EventArgs e)
        {
			if (listBoxBusStations.SelectedIndex > -1)
			{
				busStationCollection[listBoxBusStations.SelectedItem.ToString()].Sort();
				Draw();
				logger.Info("Сортировка уровней");
			}

		}
	}
}
