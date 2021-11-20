
namespace MashkovaCar
{
    partial class FormAutobusConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxBodyType = new System.Windows.Forms.GroupBox();
            this.labelAutobusModern = new System.Windows.Forms.Label();
            this.labelAutobus = new System.Windows.Forms.Label();
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.checkBoxSecondVagon = new System.Windows.Forms.CheckBox();
            this.checkBoxGarmoshka = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.pictureBoxAutobus = new System.Windows.Forms.PictureBox();
            this.panelAutobus = new System.Windows.Forms.Panel();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelCyan = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelPurple = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxBodyType.SuspendLayout();
            this.groupBoxParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAutobus)).BeginInit();
            this.panelAutobus.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBodyType
            // 
            this.groupBoxBodyType.Controls.Add(this.labelAutobusModern);
            this.groupBoxBodyType.Controls.Add(this.labelAutobus);
            this.groupBoxBodyType.Location = new System.Drawing.Point(307, 154);
            this.groupBoxBodyType.Name = "groupBoxBodyType";
            this.groupBoxBodyType.Size = new System.Drawing.Size(193, 138);
            this.groupBoxBodyType.TabIndex = 0;
            this.groupBoxBodyType.TabStop = false;
            this.groupBoxBodyType.Text = "Тип кузова";
            // 
            // labelAutobusModern
            // 
            this.labelAutobusModern.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAutobusModern.Location = new System.Drawing.Point(37, 80);
            this.labelAutobusModern.Name = "labelAutobusModern";
            this.labelAutobusModern.Size = new System.Drawing.Size(113, 37);
            this.labelAutobusModern.TabIndex = 1;
            this.labelAutobusModern.Text = "Автобус с гармошкой";
            this.labelAutobusModern.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAutobusModern.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAutobusModern_MouseDown);
            // 
            // labelAutobus
            // 
            this.labelAutobus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAutobus.Location = new System.Drawing.Point(37, 27);
            this.labelAutobus.Name = "labelAutobus";
            this.labelAutobus.Size = new System.Drawing.Size(113, 37);
            this.labelAutobus.TabIndex = 0;
            this.labelAutobus.Text = "Простой автобус";
            this.labelAutobus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAutobus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAutobus_MouseDown);
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.checkBoxSecondVagon);
            this.groupBoxParameters.Controls.Add(this.checkBoxGarmoshka);
            this.groupBoxParameters.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParameters.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParameters.Controls.Add(this.labelWeight);
            this.groupBoxParameters.Controls.Add(this.labelMaxSpeed);
            this.groupBoxParameters.Location = new System.Drawing.Point(12, 154);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(289, 138);
            this.groupBoxParameters.TabIndex = 1;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Параметры";
            // 
            // checkBoxSecondVagon
            // 
            this.checkBoxSecondVagon.AutoSize = true;
            this.checkBoxSecondVagon.Location = new System.Drawing.Point(173, 84);
            this.checkBoxSecondVagon.Name = "checkBoxSecondVagon";
            this.checkBoxSecondVagon.Size = new System.Drawing.Size(94, 17);
            this.checkBoxSecondVagon.TabIndex = 5;
            this.checkBoxSecondVagon.Text = "Второй вагон";
            this.checkBoxSecondVagon.UseVisualStyleBackColor = true;
            // 
            // checkBoxGarmoshka
            // 
            this.checkBoxGarmoshka.AutoSize = true;
            this.checkBoxGarmoshka.Location = new System.Drawing.Point(173, 51);
            this.checkBoxGarmoshka.Name = "checkBoxGarmoshka";
            this.checkBoxGarmoshka.Size = new System.Drawing.Size(78, 17);
            this.checkBoxGarmoshka.TabIndex = 4;
            this.checkBoxGarmoshka.Text = "Гармошка";
            this.checkBoxGarmoshka.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(61, 102);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(79, 20);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(61, 48);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownMaxSpeed.TabIndex = 2;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(17, 82);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(78, 13);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Вес автобуса:";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(17, 27);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(137, 13);
            this.labelMaxSpeed.TabIndex = 0;
            this.labelMaxSpeed.Text = "Максимальная скорость:";
            // 
            // pictureBoxAutobus
            // 
            this.pictureBoxAutobus.Location = new System.Drawing.Point(20, 3);
            this.pictureBoxAutobus.Name = "pictureBoxAutobus";
            this.pictureBoxAutobus.Size = new System.Drawing.Size(449, 128);
            this.pictureBoxAutobus.TabIndex = 2;
            this.pictureBoxAutobus.TabStop = false;
            // 
            // panelAutobus
            // 
            this.panelAutobus.AllowDrop = true;
            this.panelAutobus.Controls.Add(this.pictureBoxAutobus);
            this.panelAutobus.Location = new System.Drawing.Point(12, 12);
            this.panelAutobus.Name = "panelAutobus";
            this.panelAutobus.Size = new System.Drawing.Size(488, 136);
            this.panelAutobus.TabIndex = 3;
            this.panelAutobus.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelAutobus_DragDrop);
            this.panelAutobus.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelAutobus_DragEnter);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelCyan);
            this.groupBoxColors.Controls.Add(this.panelBlack);
            this.groupBoxColors.Controls.Add(this.panelOrange);
            this.groupBoxColors.Controls.Add(this.panelPurple);
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Controls.Add(this.labelDopColor);
            this.groupBoxColors.Controls.Add(this.labelColor);
            this.groupBoxColors.Location = new System.Drawing.Point(12, 298);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(289, 152);
            this.groupBoxColors.TabIndex = 4;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // panelCyan
            // 
            this.panelCyan.BackColor = System.Drawing.Color.Cyan;
            this.panelCyan.Location = new System.Drawing.Point(234, 100);
            this.panelCyan.Name = "panelCyan";
            this.panelCyan.Size = new System.Drawing.Size(33, 32);
            this.panelCyan.TabIndex = 9;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(95, 62);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(33, 32);
            this.panelBlack.TabIndex = 8;
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelOrange.Location = new System.Drawing.Point(234, 62);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(33, 32);
            this.panelOrange.TabIndex = 7;
            // 
            // panelPurple
            // 
            this.panelPurple.BackColor = System.Drawing.Color.Purple;
            this.panelPurple.Location = new System.Drawing.Point(173, 62);
            this.panelPurple.Name = "panelPurple";
            this.panelPurple.Size = new System.Drawing.Size(33, 32);
            this.panelPurple.TabIndex = 6;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(173, 100);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(33, 32);
            this.panelBlue.TabIndex = 3;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(95, 100);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(33, 32);
            this.panelGreen.TabIndex = 5;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(34, 100);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(33, 32);
            this.panelYellow.TabIndex = 4;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(34, 62);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(33, 32);
            this.panelRed.TabIndex = 2;
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(157, 20);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(116, 30);
            this.labelDopColor.TabIndex = 1;
            this.labelDopColor.Text = "Дополнительный цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            // 
            // labelColor
            // 
            this.labelColor.AllowDrop = true;
            this.labelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColor.Location = new System.Drawing.Point(23, 20);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(116, 30);
            this.labelColor.TabIndex = 0;
            this.labelColor.Text = "Основной цвет";
            this.labelColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelColor_DragDrop);
            this.labelColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(335, 337);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(137, 33);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(335, 387);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(137, 33);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormAutobusConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 465);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelAutobus);
            this.Controls.Add(this.groupBoxParameters);
            this.Controls.Add(this.groupBoxBodyType);
            this.Name = "FormAutobusConfig";
            this.Text = "FormAutobusConfig";
            this.groupBoxBodyType.ResumeLayout(false);
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAutobus)).EndInit();
            this.panelAutobus.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBodyType;
        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.CheckBox checkBoxGarmoshka;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.CheckBox checkBoxSecondVagon;
        private System.Windows.Forms.Label labelAutobusModern;
        private System.Windows.Forms.Label labelAutobus;
        private System.Windows.Forms.PictureBox pictureBoxAutobus;
        private System.Windows.Forms.Panel panelAutobus;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Panel panelCyan;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelPurple;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}