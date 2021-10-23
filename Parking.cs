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
	public class Parking<T> where T : class, ITransport
	{
		private readonly T[] _places; /// Массив объектов, которые храним
		private readonly int pictureWidth;/// Ширина окна отрисовки
		private readonly int pictureHeight;/// Высота окна отрисовки
		private readonly int _placeSizeWidth = 210+230;/// Размер парковочного места (ширина)
		private readonly int _placeSizeHeight = 100;/// Размер парковочного места (высота)
		/// Конструктор
		public Parking(int picWidth, int picHeight)
		{
			int width = picWidth / _placeSizeWidth;
			int height = picHeight / _placeSizeHeight;
			_places = new T[width * height];
			pictureWidth = picWidth;
			pictureHeight = picHeight;
		}
		/// Перегрузка оператора сложения
		/// Логика действия: на парковку добавляется автобус
		public static int operator +(Parking<T> p, T autobus)
		{
			for (int i = 0; i < p._places.Length; i++) {
				if (p._places[i] == null) {
					p._places[i] = autobus;
					p._places[i].SetPosition(8 + i % 3 * p._placeSizeWidth, i / 3 * p._placeSizeHeight + 15, p.pictureWidth, p.pictureHeight);
					return i;
				}
			}
			return -1;
		}
		/// Перегрузка оператора вычитания
		/// Логика действия: с парковки забираем автобус
		public static T operator -(Parking<T> p, int index)
		{
			if (index < p._places.Length && index >= 0)
			{
				if (p._places[index] != null)
				{
					T temp = p._places[index];
					p._places[index] = null;
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
		/// Метод отрисовки автобусов на парковке
		public void Draw(Graphics g)
		{
			DrawMarking(g);
			for (int i = 0; i < _places.Length; i++)
			{
				_places[i]?.DrawTransport(g);
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
					g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth /2, j * _placeSizeHeight);
				}
				g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
			}
		}
	}
}


