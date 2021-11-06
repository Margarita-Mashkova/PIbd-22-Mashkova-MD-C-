using System;
using System.Collections.Generic;
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
			if(!busStationStages.ContainsKey(name))
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
	}
}
