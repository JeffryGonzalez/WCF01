using System.ServiceModel;
namespace VideoStore.Contracts
{
	[ServiceContract]
	public interface IVideoLookup
	{
		[OperationContract]
		string GetTitleOfTopSellingVideo();
	}
}