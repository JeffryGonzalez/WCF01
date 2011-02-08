using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		private readonly Dictionary<Button, Func<string, string, string>> buttons;
		public Form1()
		{
			InitializeComponent();

			var simpleCalculator = new SimpleCalculator();
			buttons = new Dictionary<Button, Func<string, string, string>>
			          	{
			          		{btnAdd, simpleCalculator.Add},
			          		{btnSubtract, simpleCalculator.Subtract},
			          		{btnMultiply, simpleCalculator.Multiply},
			          		{btnDivide, simpleCalculator.Divide}
			          	};
			foreach (var button in buttons.Keys)
				button.Click += (b, e) => MessageBox.Show(buttons[(Button) b](txtNum1.Text, txtNum2.Text));
			
		}


	}
}
