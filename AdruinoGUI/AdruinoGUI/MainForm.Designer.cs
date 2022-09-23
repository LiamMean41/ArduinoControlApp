/*
 * Created by SharpDevelop.
 * User: liamm
 * Date: 03/09/2022
 * Time: 09:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AdruinoGUI
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.TurnOn = new System.Windows.Forms.Button();
			this.TurnOff = new System.Windows.Forms.Button();
			this.redVal = new System.Windows.Forms.TrackBar();
			this.sendRedVal = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.buttonBuzer = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.redVal)).BeginInit();
			this.SuspendLayout();
			// 
			// serialPort1
			// 
			this.serialPort1.PortName = "COM5";
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1DataReceived);
			// 
			// TurnOn
			// 
			this.TurnOn.Location = new System.Drawing.Point(12, 25);
			this.TurnOn.Name = "TurnOn";
			this.TurnOn.Size = new System.Drawing.Size(104, 46);
			this.TurnOn.TabIndex = 0;
			this.TurnOn.Text = "Turn On";
			this.TurnOn.UseVisualStyleBackColor = true;
			this.TurnOn.Click += new System.EventHandler(this.TurnOnClick);
			// 
			// TurnOff
			// 
			this.TurnOff.Location = new System.Drawing.Point(12, 93);
			this.TurnOff.Name = "TurnOff";
			this.TurnOff.Size = new System.Drawing.Size(104, 58);
			this.TurnOff.TabIndex = 1;
			this.TurnOff.Text = "Turn Off";
			this.TurnOff.UseVisualStyleBackColor = true;
			this.TurnOff.Click += new System.EventHandler(this.TurnOffClick);
			// 
			// redVal
			// 
			this.redVal.Location = new System.Drawing.Point(2, 407);
			this.redVal.Maximum = 255;
			this.redVal.Name = "redVal";
			this.redVal.Size = new System.Drawing.Size(532, 45);
			this.redVal.TabIndex = 2;
			this.redVal.TickFrequency = 10;
			this.redVal.Scroll += new System.EventHandler(this.RedValScroll);
			// 
			// sendRedVal
			// 
			this.sendRedVal.Location = new System.Drawing.Point(12, 360);
			this.sendRedVal.Name = "sendRedVal";
			this.sendRedVal.Size = new System.Drawing.Size(130, 41);
			this.sendRedVal.TabIndex = 3;
			this.sendRedVal.Text = "Send Value for LED";
			this.sendRedVal.UseVisualStyleBackColor = true;
			this.sendRedVal.Click += new System.EventHandler(this.SendRedValClick);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(219, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(193, 20);
			this.textBox1.TabIndex = 4;
			// 
			// buttonBuzer
			// 
			this.buttonBuzer.Location = new System.Drawing.Point(12, 197);
			this.buttonBuzer.Name = "buttonBuzer";
			this.buttonBuzer.Size = new System.Drawing.Size(104, 53);
			this.buttonBuzer.TabIndex = 5;
			this.buttonBuzer.Text = "Buzz";
			this.buttonBuzer.UseVisualStyleBackColor = true;
			this.buttonBuzer.Click += new System.EventHandler(this.ButtonBuzerClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(42, 2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "relay";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 168);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Buzzer";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(618, 482);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonBuzer);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.sendRedVal);
			this.Controls.Add(this.redVal);
			this.Controls.Add(this.TurnOff);
			this.Controls.Add(this.TurnOn);
			this.Name = "MainForm";
			this.Text = "AdruinoGUI";
			((System.ComponentModel.ISupportInitialize)(this.redVal)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonBuzer;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button sendRedVal;
		private System.Windows.Forms.TrackBar redVal;
		private System.Windows.Forms.Button TurnOff;
		private System.Windows.Forms.Button TurnOn;
		private System.IO.Ports.SerialPort serialPort1;
	}
}
