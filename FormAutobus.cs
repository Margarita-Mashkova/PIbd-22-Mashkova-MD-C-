using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MashkovaCar
{
	public partial class FormAutobus : Form
	{
		private ITransport bus;
		public FormAutobus()
		{
			InitializeComponent();
		}
		/// Передача автобуса на форму
		public void SetBus(ITransport bus)
		{
			this.bus = bus;
			Draw();
		}
		/// Метод отрисовки автобуса
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxAutobus.Width, pictureBoxAutobus.Height);
			Graphics gr = Graphics.FromImage(bmp);
			bus?.DrawTransport(gr);
			pictureBoxAutobus.Image = bmp;
		}
		/// Обработка нажатия кнопки "Создать автобус"
		private void buttonCreate_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			bus = new Autobus(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue);
			bus.SetPosition(rnd.Next(10, 400), rnd.Next(10, 100), pictureBoxAutobus.Width, pictureBoxAutobus.Height);
			Draw();
		}
		///Обработка нажатия кнопки "Создать автобус с гармошкой"
		private void buttonCreateModern_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			bus = new AutobusModern(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.Red, true, true, true);
			bus.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxAutobus.Width, pictureBoxAutobus.Height);
			Draw();
		}
		/// Обработка нажатия кнопок управления
		private void buttonMove_Click(object sender, EventArgs e)
		{
			//получаем имя кнопки
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					bus?.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					bus?.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					bus?.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					bus?.MoveTransport(Direction.Right);
					break;
			}
			Draw();
		}
    }
}
