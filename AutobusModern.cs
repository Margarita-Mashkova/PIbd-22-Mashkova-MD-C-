using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MashkovaCar
{
	public class AutobusModern : Autobus, IEquatable<AutobusModern>
	{
		public Color DopColor { private set; get; } /// Дополнительный цвет
		public bool FirstVagon { private set; get; }/// Признак наличия первого вагона
		public bool SecondVagon { private set; get; }  /// Признак наличия второго вагона
		public bool Garmoshka { private set; get; }/// Признак наличия гармошки
		public AutobusModern(int maxSpeed, float weight, Color mainColor, Color dopColor, bool firstVagon, bool secondVagon, bool garmoshka) : base(maxSpeed, weight, mainColor, 410, 70)
		{
			DopColor = dopColor;
			FirstVagon = firstVagon;
			SecondVagon = secondVagon;
			Garmoshka = garmoshka;
		}
		/// Конструктор для загрузки с файла
		public AutobusModern(string info) : base(info)
		{
			string[] strs = info.Split(separator);
			if (strs.Length == 7)
			{
				MaxSpeed = Convert.ToInt32(strs[0]);
				Weight = Convert.ToInt32(strs[1]);
				MainColor = Color.FromName(strs[2]);
				DopColor = Color.FromName(strs[3]);
				FirstVagon = Convert.ToBoolean(strs[4]);
				SecondVagon = Convert.ToBoolean(strs[5]);
				Garmoshka = Convert.ToBoolean(strs[6]);
			}
		}

		/// Отрисовка автомобиля
		public override void DrawTransport(Graphics g)
		{
			Pen pen = new Pen(MainColor);
			pen.Width = 2.0f;
			Pen pen2 = new Pen(DopColor);
			pen2.Width = 2.0f;
			Brush br2 = new SolidBrush(DopColor);
			Brush fill = new SolidBrush(Color.FromArgb(240, 240, 240));
			base.DrawTransport(g);
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
				//Корпус2  //Смещаем первый вагон со всеми его элментами по Х lengthG
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
		//Смена дополнительного цвета
		public void SetDopColor(Color color)
		{
			DopColor = color;
		}
		public override string ToString()
		{
			return $"{base.ToString()}{separator}{DopColor.Name}{separator}{FirstVagon}{separator}{SecondVagon}{separator}{Garmoshka}";
		}
		/// Метод интерфейса IEquatable для класса AutobusModern
		public bool Equals(AutobusModern other)
		{
			if (!Equals((Autobus)other))
            {
				return false;
            }
			if (DopColor != other.DopColor)
			{
				return false;
			}
			if (SecondVagon != other.SecondVagon)
			{
				return false;
			}
			if (Garmoshka != other.Garmoshka)
			{
				return false;
			}
			return true;
		}
		/// Перегрузка метода от object
		public override bool Equals(Object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (!(obj is AutobusModern autobusObj))
			{
				return false;
			}
			else
			{
				return Equals(autobusObj);
			}
		}
	}
}
