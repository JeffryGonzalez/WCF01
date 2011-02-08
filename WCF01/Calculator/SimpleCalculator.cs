using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorContracts;

namespace Calculator
{
	public class SimpleCalculator : ICalculator
	{
		public string Add(string arg1, string arg2)
		{
			return GetResult(arg1, arg2, (x, y) => (x + y).ToString());
		}

		public virtual string GetResult(string arg1, string arg2, Func<int, int, string> op)
		{
			int left;
			int right;
			return int.TryParse(arg1, out left) && int.TryParse(arg2, out right)
			       	? "Answer is " + op(left,right)
			       	: "Enter Numbers";
		}

		public string Subtract(string arg1, string arg2)
		{
			return GetResult(arg1, arg2, (x, y) => (x - y).ToString());
		}

		public string Multiply(string arg1, string arg2)
		{
			return GetResult(arg1, arg2, (x, y) => (x*y).ToString());
		}
		public string Divide(string arg1, string arg2)
		{
			return GetResult(arg1, arg2, (x, y) => (x/y).ToString());
		}
	}
}
