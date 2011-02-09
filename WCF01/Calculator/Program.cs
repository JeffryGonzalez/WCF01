using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;
using CalculatorContracts;
using System.ServiceModel.Description;

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
			var host = new ServiceHost(typeof(SimpleCalculator));

			var mexBehavior = new ServiceMetadataBehavior();
			mexBehavior.HttpGetEnabled = true;
			mexBehavior.HttpGetUrl = new Uri("http://localhost:8080/Calculator/MEX");
			host.Description.Behaviors.Add(mexBehavior);

			host.Open();
			Application.ApplicationExit += (o, e) => host.Close();
			Application.Run(new Form1());

		}
	}
}
