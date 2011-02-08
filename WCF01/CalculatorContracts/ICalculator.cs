using System.ServiceModel;
namespace CalculatorContracts
{
	[ServiceContract]
	public interface ICalculator
	{
		[OperationContract]
		string Add(string arg1, string arg2);
		[OperationContract]
		string Subtract(string arg1, string arg2);
		[OperationContract]
		string Multiply(string arg1, string arg2);
		[OperationContract]
		string Divide(string arg1, string arg2);
	}
}