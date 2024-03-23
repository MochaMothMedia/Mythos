using Mythos.ASPWebAPI.Characters;
using Mythos.Core.DependencyInjection;
using System.ComponentModel.Composition;

namespace Mythos.ASPWebAPI
{
	[Export(typeof(IServiceInjector))]
	public class ServiceInjector : IServiceInjector
	{
		public void ConfigureServices(IServiceCollection services)
		{
			//
		}
	}
}
