using Microsoft.Extensions.DependencyInjection;
using Mythos.Core.DependencyInjection;
using Mythos.Core.RequestMetadata;
using System.ComponentModel.Composition;

namespace Mythos.RequestMetadataManagement
{
	[Export(typeof(IServiceInjector))]
	internal class ServiceInjector : IServiceInjector
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddScoped<IManageRequestMetadata, RequestMetadataManager>();
		}
	}
}
