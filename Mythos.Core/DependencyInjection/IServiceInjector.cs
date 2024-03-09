using Microsoft.Extensions.DependencyInjection;

namespace Mythos.Core.DependencyInjection
{
	public interface IServiceInjector
	{
		void ConfigureServices(IServiceCollection services);
	}
}
