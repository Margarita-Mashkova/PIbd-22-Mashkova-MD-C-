using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MashkovaCar
{
	public class AutobusModern : Autobus
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
	}
}
