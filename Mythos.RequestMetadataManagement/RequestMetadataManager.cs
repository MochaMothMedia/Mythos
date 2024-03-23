using Mythos.Core.RequestMetadata;

namespace Mythos.RequestMetadataManagement
{
	internal class RequestMetadataManager : IManageRequestMetadata
	{
		public string RequestId { get; private set; }

		public RequestMetadataManager()
		{
			RequestId = Guid.NewGuid().ToString();
		}
	}
}
