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
    public partial class FormAutobusConfig : Form
    {
        Vehicle bus = null; // Переменная-выбранный автобус
        private Action<Vehicle> eventAddAutobus; //событие       
        public FormAutobusConfig()
        {
            InitializeComponent();
            panelRed.MouseDown += panelColor_MouseDown;
            panelBlack.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelPurple.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            panelCyan.MouseDown += panelColor_MouseDown;
            labelDopColor.DragEnter += labelColor_DragEnter;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        //Отрисовать автобус
        private void DrawAutobus() 
        {
            if (bus != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxAutobus.Width, pictureBoxAutobus.Height);
                Graphics gr = Graphics.FromImage(bmp);
                bus.SetPosition(5, 5, pictureBoxAutobus.Width, pictureBoxAutobus.Height);
                bus.DrawTransport(gr); 
                pictureBoxAutobus.Image = bmp;
            }
        }
        //Добавление события
        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddAutobus == null)
            {
                eventAddAutobus = new Action<Vehicle>(ev);
            }
            else
            {
                eventAddAutobus += ev;
            }
        }
        // Передаем информацию при нажатии на Label "Простой автобус"
        private void labelAutobus_MouseDown(object sender, MouseEventArgs e)
        {
            labelAutobus.DoDragDrop(labelAutobus.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        // Передаем информацию при нажатии на Label "Автобус с гармошкой"
        private void labelAutobusModern_MouseDown(object sender, MouseEventArgs e)
        {
            labelAutobusModern.DoDragDrop(labelAutobusModern.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        // Проверка получаемой информации (ее типа на соответствие требуемому)
        private void panelAutobus_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        // Действия при приеме перетаскиваемой информации
        private void panelAutobus_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Простой автобус":
                    bus = new Autobus((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.Black);
                    break;
                case "Автобус с гармошкой":
                    bus = new AutobusModern((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.Red, Color.Black, true, checkBoxSecondVagon.Checked, checkBoxGarmoshka.Checked);
                    break;
            }
            DrawAutobus();
        }
        // Отправляем цвет с панели
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }
        // Проверка получаемой информации (ее типа на соответствие требуемому)
        private void labelColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        // Принимаем основной цвет
        private void labelColor_DragDrop(object sender, DragEventArgs e)
        {
            if (bus != null) 
            {
                bus.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawAutobus();
            }
        }
        // Принимаем дополнительный цвет
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (bus != null)
            {
                if (bus is AutobusModern)
                {
                    (bus as AutobusModern).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawAutobus();
                }
            }
        }
        // Добавление автобуса
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddAutobus?.Invoke(bus);
            Close();
        }
    }
}
 