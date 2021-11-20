
namespace MashkovaCar
{
	partial class FormBusStation
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonSetAutobus = new System.Windows.Forms.Button();
            this.groupBoxTakeAutobus = new System.Windows.Forms.GroupBox();
            this.buttonTake = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.listBoxBusStations = new System.Windows.Forms.ListBox();
            this.labelBusStation = new System.Windows.Forms.Label();
            this.textBoxBusStationName = new System.Windows.Forms.TextBox();
            this.buttonAddBusStation = new System.Windows.Forms.Button();
            this.buttonDelBusStation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxTakeAutobus.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(5, 10);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1349, 678);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonSetAutobus
            // 
            this.buttonSetAutobus.Location = new System.Drawing.Point(1392, 300);
            this.buttonSetAutobus.Name = "buttonSetAutobus";
            this.buttonSetAutobus.Size = new System.Drawing.Size(143, 48);
            this.buttonSetAutobus.TabIndex = 1;
            this.buttonSetAutobus.Text = "Добавить автобус";
            this.buttonSetAutobus.UseVisualStyleBackColor = true;
            this.buttonSetAutobus.Click += new System.EventHandler(this.buttonSetAutobus_Click);
            // 
            // groupBoxTakeAutobus
            // 
            this.groupBoxTakeAutobus.Controls.Add(this.buttonTake);
            this.groupBoxTakeAutobus.Controls.Add(this.maskedTextBox);
            this.groupBoxTakeAutobus.Controls.Add(this.labelPlace);
            this.groupBoxTakeAutobus.Location = new System.Drawing.Point(1392, 379);
            this.groupBoxTakeAutobus.Name = "groupBoxTakeAutobus";
            this.groupBoxTakeAutobus.Size = new System.Drawing.Size(142, 95);
            this.groupBoxTakeAutobus.TabIndex = 3;
            this.groupBoxTakeAutobus.TabStop = false;
            this.groupBoxTakeAutobus.Text = "Забрать автобус";
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(54, 56);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(82, 29);
            this.buttonTake.TabIndex = 6;
            this.buttonTake.Text = "Забрать";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(54, 30);
            this.maskedTextBox.Mask = "00";
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox.Size = new System.Drawing.Size(82, 20);
            this.maskedTextBox.TabIndex = 5;
            this.maskedTextBox.ValidatingType = typeof(int);
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(6, 33);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 4;
            this.labelPlace.Text = "Место:";
            // 
            // listBoxBusStations
            // 
            this.listBoxBusStations.FormattingEnabled = true;
            this.listBoxBusStations.Location = new System.Drawing.Point(1392, 81);
            this.listBoxBusStations.Name = "listBoxBusStations";
            this.listBoxBusStations.Size = new System.Drawing.Size(143, 160);
            this.listBoxBusStations.TabIndex = 4;
            this.listBoxBusStations.SelectedIndexChanged += new System.EventHandler(this.listBoxBusStation_SelectedIndexChanged);
            // 
            // labelBusStation
            // 
            this.labelBusStation.AutoSize = true;
            this.labelBusStation.Location = new System.Drawing.Point(1426, 9);
            this.labelBusStation.Name = "labelBusStation";
            this.labelBusStation.Size = new System.Drawing.Size(78, 13);
            this.labelBusStation.TabIndex = 5;
            this.labelBusStation.Text = "Автовокзалы:";
            // 
            // textBoxBusStationName
            // 
            this.textBoxBusStationName.Location = new System.Drawing.Point(1392, 26);
            this.textBoxBusStationName.Name = "textBoxBusStationName";
            this.textBoxBusStationName.Size = new System.Drawing.Size(143, 20);
            this.textBoxBusStationName.TabIndex = 6;
            // 
            // buttonAddBusStation
            // 
            this.buttonAddBusStation.Location = new System.Drawing.Point(1392, 52);
            this.buttonAddBusStation.Name = "buttonAddBusStation";
            this.buttonAddBusStation.Size = new System.Drawing.Size(143, 23);
            this.buttonAddBusStation.TabIndex = 7;
            this.buttonAddBusStation.Text = "Добавить автовокзал";
            this.buttonAddBusStation.UseVisualStyleBackColor = true;
            this.buttonAddBusStation.Click += new System.EventHandler(this.buttonAddBusStation_Click);
            // 
            // buttonDelBusStation
            // 
            this.buttonDelBusStation.Location = new System.Drawing.Point(1392, 246);
            this.buttonDelBusStation.Name = "buttonDelBusStation";
            this.buttonDelBusStation.Size = new System.Drawing.Size(143, 23);
            this.buttonDelBusStation.TabIndex = 8;
            this.buttonDelBusStation.Text = "Удалить автовокзал";
            this.buttonDelBusStation.UseVisualStyleBackColor = true;
            this.buttonDelBusStation.Click += new System.EventHandler(this.buttonDelBusStation_Click);
            // 
            // FormBusStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 692);
            this.Controls.Add(this.buttonDelBusStation);
            this.Controls.Add(this.buttonAddBusStation);
            this.Controls.Add(this.textBoxBusStationName);
            this.Controls.Add(this.labelBusStation);
            this.Controls.Add(this.listBoxBusStations);
            this.Controls.Add(this.groupBoxTakeAutobus);
            this.Controls.Add(this.buttonSetAutobus);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormBusStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxTakeAutobus.ResumeLayout(false);
            this.groupBoxTakeAutobus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxParking;
		private System.Windows.Forms.Button buttonSetAutobus;
		private System.Windows.Forms.GroupBox groupBoxTakeAutobus;
		private System.Windows.Forms.Label labelPlace;
		private System.Windows.Forms.Button buttonTake;
		private System.Windows.Forms.MaskedTextBox maskedTextBox;
		private System.Windows.Forms.ListBox listBoxBusStations;
		private System.Windows.Forms.Label labelBusStation;
		private System.Windows.Forms.TextBox textBoxBusStationName;
		private System.Windows.Forms.Button buttonAddBusStation;
		private System.Windows.Forms.Button buttonDelBusStation;
	}
}