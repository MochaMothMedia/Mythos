using Mythos.Core.APIGateway;
using Mythos.Core.DependencyInjection;
using System.ComponentModel.Composition;

namespace Mythos.ASPWebAPI
{
	[Export(typeof(IServiceInjector))]
	public class ServiceInjector : IServiceInjector
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddSingleton<IAPIInitializer, APIInitializer>();
		}
	}
}
