namespace CalculatorContracts
{
	public interface ICalculator
	{
		string Add(string arg1, string arg2);
		string Subtract(string arg1, string arg2);
		string Multiply(string arg1, string arg2);
		string Divide(string arg1, string arg2);
	}
}