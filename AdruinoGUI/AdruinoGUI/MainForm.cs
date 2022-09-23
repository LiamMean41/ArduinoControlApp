/*
 * Created by SharpDevelop.
 * User: liamm
 * Date: 03/09/2022
 * Time: 09:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AdruinoGUI
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private string red; // string for the leds value
		private delegate void r1(string indata);
		private static int counter; // the amount of times the button is pressed
		
		
		public MainForm()
		{
			InitializeComponent();
			//Open the serial port
			serialPort1.Open();
		}
		
		
		void TurnOnClick(object sender, EventArgs e)
		{
			// Button controls Relay function to turn it on
			serialPort1.Write("R");
		}
		
		
		
		void TurnOffClick(object sender, EventArgs e)
		{
			// Button controls Relay function to turn it off
			serialPort1.Write("r");
		}
		
		void RedValScroll(object sender, EventArgs e)
		{
			//adjust the value of the LED
			red = "L" + redVal.Value;
			
			
		}
		
		void SendRedValClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(red))
			{
				red = "L0";
			}
			serialPort1.Write(red);
		}
		
		void SerialPort1DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			string indata = serialPort1.ReadLine();
			r1 writeit = new r1(Write2Form);
			Invoke(writeit, indata);
		}
		
		public void Write2Form(string indata)
		{
			//used to manage the input from the Arduino
			char firstchar;
			Single numdata;
			firstchar = indata[0];
			switch(firstchar)
			{
				case 'p':
					counter++;
					textBox1.Text = Convert.ToString(counter);
					break;
				
			}
		}		
		
		void ButtonBuzerClick(object sender, EventArgs e)
		{
			serialPort1.Write("b");
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			return;
		}
	}
}
