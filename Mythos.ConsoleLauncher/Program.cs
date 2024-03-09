using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Mythos.ConsoleLauncher.HostedService;

namespace Mythos.ConsoleLauncher
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Host.CreateDefaultBuilder(args)
				.ConfigureServices((hostContext, services) =>
				{
					services.AddHostedService<HostService>();
					services.AddPlugins();
				})
				.Build()
				.Run();
		}
	}
}