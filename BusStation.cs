using System.Collections.Generic;
using System.Collections;
using System.Drawing;

namespace MashkovaCar
{
	/// Параметризованный класс для хранения набора объектов от интерфейса ITransport
	public class BusStation<T> : IEnumerator<T>, IEnumerable<T> where T : class, ITransport
	{
		private readonly List<T> _places;/// Список объектов, которые храним
		private readonly int _maxCount; /// Максимальное количество мест на парковке автовокзала
		private readonly int pictureWidth;/// Ширина окна отрисовки
		private readonly int pictureHeight;/// Высота окна отрисовки
		private readonly int _placeSizeWidth = 210 + 230;/// Размер парковочного места (ширина)
		private readonly int _placeSizeHeight = 100;/// Размер парковочного места (высота)
		/// Текущий элемент для вывода через IEnumerator (будет обращаться по своему 
		/// индексу к ключу словаря, по которму будет возвращаться запись)
		private int _currentIndex;
		public T Current => _places[_currentIndex];
		object IEnumerator.Current => _places[_currentIndex];
		/// Конструктор
		public BusStation(int picWidth, int picHeight)
		{
			int width = picWidth / _placeSizeWidth;
			int height = picHeight / _placeSizeHeight;
			_maxCount = width * height;
			pictureWidth = picWidth;
			pictureHeight = picHeight;
			_places = new List<T>();
			_currentIndex = -1;
		}
		/// Перегрузка оператора сложения
		/// Логика действия: на парковку добавляется автобус
		public static int operator +(BusStation<T> p, T autobus)
		{
			if (p._places.Count >= p._maxCount)
			{
				throw new BusStationOverflowException();
			}
			if (p._places.Contains(autobus)) 
			{
				throw new BusStationAlreadyHaveException();
			}
			else
			{
				p._places.Add(autobus);
				return p._places.Count - 1;
			}
		}
		/// Перегрузка оператора вычитания
		/// Логика действия: с парковки забираем автобус
		public static T operator -(BusStation<T> p, int index)
		{
			if ((index < p._places.Count) && (index >= 0))
			{
				T temp = p._places[index];
				p._places.Remove(p._places[index]);
				return temp;
			}
			else
			{
				throw new BusStationNotFoundException(index);
			}
		}
		/// Метод отрисовки автобусов на парковке автовокзала
		public void Draw(Graphics g)
		{
			DrawMarking(g);
			for (int i = 0; i < _places.Count; i++)
			{
				_places[i].SetPosition(8 + i % 3 * _placeSizeWidth, i / 3 * _placeSizeHeight + 15, pictureWidth, pictureHeight);
				_places[i].DrawTransport(g);
			}
		}
		/// Метод отрисовки разметки парковочных мест
		private void DrawMarking(Graphics g)
		{
			Pen pen = new Pen(Color.Black, 3);
			for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
			{
				for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
				{//линия рамзетки места
					g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
				}
				g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
			}
		}
		/// Функция получения элемента из списка
		public T GetNext(int index)
		{
			if (index < 0 || index >= _places.Count)
			{
				return null;
			}
			return _places[index];
		}
		/// Сортировка автомобилей на парковке
		public void Sort() => _places.Sort((IComparer<T>)new AutobusComparer());
		/// Метод интерфейса IEnumerator, вызываемый при удалении объекта
		public void Dispose(){}
		/// Метод интерфейса IEnumerator для перехода к следующему элементу или началу коллекции
		public bool MoveNext()
		{
			if ((_currentIndex + 1) >= _places.Count)
			{
				Reset();
				return false;
			}
			_currentIndex++;
			return true;
		}
		/// Метод интерфейса IEnumerator для сброса и возврата к началу коллекции
		public void Reset()
		{
			_currentIndex = -1;
		}
		/// Метод интерфейса IEnumerable
		public IEnumerator<T> GetEnumerator()
		{
			return this;
		}
		/// Метод интерфейса IEnumerable
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this;
		}
	}
}


