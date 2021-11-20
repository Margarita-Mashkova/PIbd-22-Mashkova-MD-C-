using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MashkovaCar
{
	/// Параметризованный класс для хранения набора объектов от интерфейса ITransport
	public class BusStation<T> where T : class, ITransport
	{
		private readonly List<T> _places;/// Список объектов, которые храним
		private readonly int _maxCount; /// Максимальное количество мест на парковке автовокзала
		private readonly int pictureWidth;/// Ширина окна отрисовки
		private readonly int pictureHeight;/// Высота окна отрисовки
		private readonly int _placeSizeWidth = 210 + 230;/// Размер парковочного места (ширина)
		private readonly int _placeSizeHeight = 100;/// Размер парковочного места (высота)
		/// Конструктор
		public BusStation(int picWidth, int picHeight)
		{
			int width = picWidth / _placeSizeWidth;
			int height = picHeight / _placeSizeHeight;
			_maxCount = width * height;
			pictureWidth = picWidth;
			pictureHeight = picHeight;
			_places = new List<T>();
		}
		/// Перегрузка оператора сложения
		/// Логика действия: на парковку добавляется автобус
		public static int operator +(BusStation<T> p, T autobus)
		{
			if (p._maxCount == p._places.Count)
			{
				return -1;
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
			if (index < p._places.Count || index > 0)
			{
				if (p._places[index] != null)
				{
					T temp = p._places[index];
					p._places.Remove(p._places[index]);
					return temp;
				}
				else
				{
					MessageBox.Show("Данное парковочное место пустое!");
					return null;
				}
			}
			else
			{
				MessageBox.Show("Такого места на парковке не существует!");
				return null;
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
	}
}


