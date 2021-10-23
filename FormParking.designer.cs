
namespace MashkovaCar
{
	partial class FormParking
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
            this.buttonSetAutobusModern = new System.Windows.Forms.Button();
            this.groupBoxTakeAutobus = new System.Windows.Forms.GroupBox();
            this.buttonTake = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
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
            this.buttonSetAutobus.Location = new System.Drawing.Point(1397, 22);
            this.buttonSetAutobus.Name = "buttonSetAutobus";
            this.buttonSetAutobus.Size = new System.Drawing.Size(143, 23);
            this.buttonSetAutobus.TabIndex = 1;
            this.buttonSetAutobus.Text = "Припарковать автобус";
            this.buttonSetAutobus.UseVisualStyleBackColor = true;
            this.buttonSetAutobus.Click += new System.EventHandler(this.buttonSetAutobus_Click);
            // 
            // buttonSetAutobusModern
            // 
            this.buttonSetAutobusModern.Location = new System.Drawing.Point(1397, 51);
            this.buttonSetAutobusModern.Name = "buttonSetAutobusModern";
            this.buttonSetAutobusModern.Size = new System.Drawing.Size(143, 37);
            this.buttonSetAutobusModern.TabIndex = 2;
            this.buttonSetAutobusModern.Text = "Припарковать автобус с гармошкой";
            this.buttonSetAutobusModern.UseVisualStyleBackColor = true;
            this.buttonSetAutobusModern.Click += new System.EventHandler(this.buttonSetAutobusModern_Click);
            // 
            // groupBoxTakeAutobus
            // 
            this.groupBoxTakeAutobus.Controls.Add(this.buttonTake);
            this.groupBoxTakeAutobus.Controls.Add(this.maskedTextBox);
            this.groupBoxTakeAutobus.Controls.Add(this.labelPlace);
            this.groupBoxTakeAutobus.Location = new System.Drawing.Point(1397, 96);
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
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 692);
            this.Controls.Add(this.groupBoxTakeAutobus);
            this.Controls.Add(this.buttonSetAutobusModern);
            this.Controls.Add(this.buttonSetAutobus);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxTakeAutobus.ResumeLayout(false);
            this.groupBoxTakeAutobus.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxParking;
		private System.Windows.Forms.Button buttonSetAutobus;
		private System.Windows.Forms.Button buttonSetAutobusModern;
		private System.Windows.Forms.GroupBox groupBoxTakeAutobus;
		private System.Windows.Forms.Label labelPlace;
		private System.Windows.Forms.Button buttonTake;
		private System.Windows.Forms.MaskedTextBox maskedTextBox;
	}
}