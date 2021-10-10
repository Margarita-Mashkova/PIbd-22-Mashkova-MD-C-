using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MashkovaCar
{
	interface ITransport
	{
		// Установка позиции
		void SetPosition(int x, int y, int width, int height);
		// Изменение направления пермещения
		void MoveTransport(Direction direction);
		// Отрисовка
		void DrawTransport(Graphics g);
	}
}
