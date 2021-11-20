using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MashkovaCar
{
	public class Autobus : Vehicle
	{
		private readonly int carWidth = 190;/// Ширина отрисовки автобуса
		private readonly int carHeight = 70;/// Высота отрисовки автобуса
		protected static readonly char separator = ';';/// Разделитель для записи информации по объекту в файл
		public Autobus(int maxSpeed, float weight, Color mainColor)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
		}
		/// Конструктор для загрузки с файла
		public Autobus(string info)
		{
			string[] strs = info.Split(separator);
			if (strs.Length == 3)
			{
				MaxSpeed = Convert.ToInt32(strs[0]);
				Weight = Convert.ToInt32(strs[1]);
				MainColor = Color.FromName(strs[2]);
			}
		}
		protected Autobus(int maxSpeed, float weight, Color mainColor, int carWidth, int carHeight)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			this.carWidth = carWidth;
			this.carHeight = carHeight;
		}
		public override void MoveTransport(Direction direction)
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
		public override void DrawTransport(Graphics g)
		{
			Pen pen = new Pen(MainColor);
			pen.Width = 2.0f;
			Brush fill = new SolidBrush(Color.FromArgb(240, 240, 240));
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
		public override string ToString()
		{
			return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
		}
	}
}
