using System;
using System.Windows.Forms;
using System.ServiceModel;
using CalculatorContracts;

namespace Client
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var channel = new ChannelFactory<ICalculator>("myClient");

			var client = channel.CreateChannel();
			MessageBox.Show(client.Add("10", "20"));

		}
	}
}
