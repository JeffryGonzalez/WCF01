using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
			var channel = new ChannelFactory<ICalculator>(
				new NetNamedPipeBinding(NetNamedPipeSecurityMode.None),
				new EndpointAddress("net.pipe://localhost/Calculator/CalculatorService"));

			var client = channel.CreateChannel();
			MessageBox.Show(client.Add("10", "20"));

		}
	}
}
