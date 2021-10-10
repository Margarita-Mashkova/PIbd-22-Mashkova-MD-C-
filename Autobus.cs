using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MashkovaCar
{
	class Autobus
	{
		private float _startPosX; /// Левая координата отрисовки автобуса
		private float _startPosY;/// Правая кооридната отрисовки автобуса
		private int _pictureWidth;/// Ширина окна отрисовки
		private int _pictureHeight;/// Высота окна отрисовки
		private readonly int carWidth = 410;/// Ширина отрисовки автобуса
		private readonly int carHeight = 65;/// Высота отрисовки автобуса
		public int MaxSpeed { private set; get; }/// Максимальная скорость
		public float Weight { private set; get; }/// Вес автобуса
		public Color MainColor { private set; get; } /// Основной цвет кузова
		public Color DopColor { private set; get; } /// Дополнительный цвет
		public bool FirstVagon { private set; get; }/// Признак наличия первого вагона
		public bool SecondVagon { private set; get; }  /// Признак наличия второго вагона
		public bool Garmoshka { private set; get; }/// Признак наличия гармошки
		public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor, bool firstVagon, bool secondVagon, bool garmoshka)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			DopColor = dopColor;
			FirstVagon = firstVagon;
			SecondVagon = secondVagon;
			Garmoshka = garmoshka;
		}
		//Установка позиции автомобиля
		public void SetPosition(int x, int y, int width, int height)
		{
			_startPosX = x;
			_startPosY = y;
			_pictureWidth = width;
			_pictureHeight = height;
		}
		//Изменение направления пермещения
		public void MoveTransport(Direction direction)
		{
			float step = MaxSpeed * 100 / Weight;
			switch (direction)
			{
				// вправо
				case Direction.Right:
					if (_startPosX + step < _pictureWidth - carWidth)
					{
						_startPosX += step;
					}
					break;
				//влево
				case Direction.Left:
					if (_startPosX - step > 0)
					{
						_startPosX -= step;
					}
					break;
				//вверх
				case Direction.Up:
					if (_startPosY - step > 0)
					{
						_startPosY -= step;
					}
					break;
				//вниз
				case Direction.Down:
					if (_startPosY + step < _pictureHeight - carHeight)
					{
						_startPosY += step;
					}
					break;
			}
		}
		//Отрисовка автомобиля
		public void DrawTransport(Graphics g)
		{
			Pen pen = new Pen(MainColor);
			pen.Width = 2.0f;
			Pen pen2 = new Pen(DopColor);
			pen2.Width = 2.0f;
			Brush br2 = new SolidBrush(DopColor);
			Brush fill = new SolidBrush(Color.FromArgb(240, 240, 240));
			if (FirstVagon)
			{
				//Корпус1
				g.DrawRectangle(pen, _startPosX, _startPosY, 190, 60);
				//Дверь
				g.DrawRectangle(pen, _startPosX + 70, _startPosY + 25, 20, 35);
				//Окна
				g.DrawEllipse(pen, _startPosX + 5, _startPosY + 10, 18, 28); //первое
				g.DrawEllipse(pen, _startPosX + 5 + 18 + 17, _startPosY + 10, 18, 28); //второе
				for (int n = 5; n < (5 + 18) * 4; n += 5 + 18)
				{
					g.DrawEllipse(pen, _startPosX + 5 + 18 + 17 + 50 + n, _startPosY + 10, 18, 28);
				}
				//Колёса
				g.FillEllipse(fill, _startPosX + 20, _startPosY + 50, 25, 25); //заливка
				g.DrawEllipse(pen, _startPosX + 20, _startPosY + 50, 25, 25); //заднее
				g.FillEllipse(fill, _startPosX + 190 - 20 - 25, _startPosY + 50, 25, 25);//заливка
				g.DrawEllipse(pen, _startPosX + 190 - 20 - 25, _startPosY + 50, 25, 25);//переднее
			}
			int lengthG = 30; //длина гармошки
			if (Garmoshka)
			{
				//Гармошка
				g.DrawRectangle(pen2, _startPosX + 190, _startPosY + 3, lengthG, 60 - 6);
				for (int n = 5; n < lengthG; n += 5)
				{
					g.DrawLine(pen2, _startPosX + 190 + n, _startPosY + 3, _startPosX + 190 + n, _startPosY + 3 + 60 - 6);
				}
			}
			if (SecondVagon)
			{
				//Корпус2  //Смещаем первый вагон со всеми его элментами по Х на carWidth + lengthG
				g.DrawRectangle(pen2, _startPosX + 190 + lengthG, _startPosY, 190, 60);
				//Дверь
				g.DrawRectangle(pen2, _startPosX + 190 + lengthG + 70, _startPosY + 25, 20, 35);
				//Окна
				g.DrawEllipse(pen2, _startPosX + 5 + 190 + lengthG, _startPosY + 10, 18, 28); //первое
				g.DrawEllipse(pen2, _startPosX + 5 + 18 + 17 + 190 + lengthG, _startPosY + 10, 18, 28); //второе
				for (int n = 5; n < (5 + 18) * 4; n += 5 + 18)
				{
					g.DrawEllipse(pen2, _startPosX + 5 + 18 + 17 + 50 + n + 190 + lengthG, _startPosY + 10, 18, 28);
				}
				//Колёса
				g.FillEllipse(fill, _startPosX + 20 + 190 + lengthG, _startPosY + 60 - 10, 25, 25); //заливка
				g.DrawEllipse(pen2, _startPosX + 20 + 190 + lengthG, _startPosY + 60 - 10, 25, 25); //заднее
				g.FillEllipse(fill, _startPosX + 190 - 20 - 25 + 190 + lengthG, _startPosY + 60 - 10, 25, 25);//заливка
				g.DrawEllipse(pen2, _startPosX + 190 - 20 - 25 + 190 + lengthG, _startPosY + 60 - 10, 25, 25);//переднее
			}
		}
	}
}
