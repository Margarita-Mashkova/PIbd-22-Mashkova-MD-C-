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
		private Autobus bus;

		public FormAutobus()
		{
			InitializeComponent();
		}
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxAutobus.Width, pictureBoxAutobus.Height);
			Graphics gr = Graphics.FromImage(bmp);
			bus.DrawTransport(gr);
			pictureBoxAutobus.Image = bmp;
		}
		private void buttonCreate_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			bus = new Autobus();
			bus.Init(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Red, Color.Gray, true, true, true); 
			bus.SetPosition(rnd.Next(10, 400), rnd.Next(10, 100), pictureBoxAutobus.Width, pictureBoxAutobus.Height);
			Draw();
		}
		private void buttonMove_Click(object sender, EventArgs e)
		{
			//получаем имя кнопки
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					if (bus != null)
					{
						bus.MoveTransport(Direction.Up);
					}
					else
					{
						MessageBox.Show("Сначала создайте объект!");
						return;
					}
					break;
				case "buttonDown":
					if (bus != null)
					{
						bus.MoveTransport(Direction.Down);
					}
					else
					{
						MessageBox.Show("Сначала создайте объект!");
						return;
					}
					break;
				case "buttonLeft":
					if (bus != null)
					{
						bus.MoveTransport(Direction.Left);
					}
					else
					{
						MessageBox.Show("Сначала создайте объект!");
						return;
					}
					break;
				case "buttonRight":
					if (bus != null)
					{
						bus.MoveTransport(Direction.Right);
					}
					else
					{
						MessageBox.Show("Сначала создайте объект!");
						return;
					}
					break;
			}
			Draw();
		}

        private void pictureBoxAutobus_Click(object sender, EventArgs e)
        {

        }
    }
}
