using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MashkovaCar
{
	public class BusStationCollection
	{
		readonly Dictionary<string, BusStation<Vehicle>> busStationStages; /// Словарь (хранилище) с автовокзалами
		public List<string> Keys => busStationStages.Keys.ToList(); /// Возвращение списка названий автовокзалов
		private readonly int pictureWidth;  /// Ширина окна отрисовки
		private readonly int pictureHeight; /// Высота окна отрисовки
		private readonly char separator = ':'; /// Разделитель для записи информации в файл
		/// Конструктор
		public BusStationCollection(int pictureWidth, int pictureHeight)
		{
			busStationStages = new Dictionary<string, BusStation<Vehicle>>();
			this.pictureWidth = pictureWidth;
			this.pictureHeight = pictureHeight;
		}
		/// Добавление автовокзала
		public void AddBusStation(string name)
		{
			if (!busStationStages.ContainsKey(name))
			{
				busStationStages.Add(name, new BusStation<Vehicle>(pictureWidth, pictureHeight));
			}
		}
		/// Удаление автовокзала
		public void DelBusStation(string name)
		{
			if (busStationStages.ContainsKey(name))
			{
				busStationStages.Remove(name);
			}
		}
		/// Доступ к автовокзалу
		public BusStation<Vehicle> this[string ind]
		{
			get
			{
				if (busStationStages.ContainsKey(ind))
				{
					return busStationStages[ind];
				}
				else
				{
					return null;
				}
			}
		}
		/// Сохранение информации по автомбусам на автовокзалах в файл
		/// <param name="filename">Путь и имя файла</param>
		public bool SaveData(string filename)
		{
			if(File.Exists(filename))
			{
				File.Delete(filename);
			}
			using (StreamWriter sw = new StreamWriter(filename, false, Encoding.UTF8))
			{
				sw.Write($"ParkingCollection{Environment.NewLine}");
				foreach (var level in busStationStages)
				{
					//Начинаем парковку
					sw.Write($"Parking{separator}{level.Key}{Environment.NewLine}");
					ITransport bus = null;
					for (int i = 0; (bus = level.Value.GetNext(i)) != null; i++)
					{
						if (bus != null)
						{
							//если место не пустое
							//Записываем тип машины
							if (bus.GetType().Name == "Autobus")
							{
								sw.Write($"Autobus{separator}");
							}
							if (bus.GetType().Name == "AutobusModern")
							{
								sw.Write($"AutobusModern{separator}");
							}
							//Записываемые параметры
							sw.Write(bus + Environment.NewLine);
						}
					}
				}
			}
			return true;
		}
		/// Загрузка нформации по автобусам на автовокзалах из файла
		public bool LoadData(string filename)
		{
			if (!File.Exists(filename))
			{
				return false;
			}
			using (StreamReader sr = new StreamReader(filename, Encoding.UTF8))
			{
				string strs = sr.ReadLine();
				if (strs.Contains("ParkingCollection"))
				{
					//очищаем записи
					busStationStages.Clear();
				}
				else
				{
					//если нет такой записи, то это не те данные
					return false;
				}
				Vehicle bus = null;
				string key = string.Empty;
				while ((strs = sr.ReadLine()) != null)
				{
					//идем по считанным записям
					if (strs.Contains("Parking"))
					{//начинаем новую парковку
						key = strs.Split(separator)[1];
						busStationStages.Add(key, new BusStation<Vehicle>(pictureWidth, pictureHeight));
						continue;
					}
					if (string.IsNullOrEmpty(strs))
					{
						continue;
					}
					if (strs.Split(separator)[0] == "Autobus")
					{
						bus = new Autobus(strs.Split(separator)[1]);
					}
					else if (strs.Split(separator)[0] == "AutobusModern")
					{
						bus = new AutobusModern(strs.Split(separator)[1]);
					}
					var result = busStationStages[key] + bus;
					if (result < 0)
					{
						return false;
					}
				}
				return true;
			}
		}
	}
}
