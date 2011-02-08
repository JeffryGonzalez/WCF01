using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;
using CalculatorContracts;

namespace Calculator
{
	static class Program
	{

	
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			const string address = "net.pipe://localhost/Calculator/CalculatorService";
			var host = new ServiceHost(typeof(SimpleCalculator));
			host.AddServiceEndpoint(typeof(ICalculator), new NetNamedPipeBinding(NetNamedPipeSecurityMode.None), address);
			
			host.Open();
			Application.ApplicationExit += (o, e) => host.Close();
			Application.Run(new Form1());

		}
	}
}
