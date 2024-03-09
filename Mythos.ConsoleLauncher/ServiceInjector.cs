using Microsoft.Extensions.DependencyInjection;
using Mythos.ConsoleLauncher.Logging;
using Mythos.ConsoleLauncher.Logging.Loggers;
using Mythos.Core.DependencyInjection;
using Mythos.Core.Logging;
using System.ComponentModel.Composition;

namespace Mythos.ConsoleLauncher
{
    [Export(typeof(IServiceInjector))]
	public class ServiceInjector : IServiceInjector
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddScoped<ILogger, InfoLogger>();
			services.AddScoped<ILogger, WarningLogger>();
			services.AddScoped<ILogger, ErrorLogger>();
			services.AddScoped<ILogger, FatalLogger>();
			services.AddScoped<LoggerFactory>();
			services.AddScoped<ILog, ConsoleLogger>();
		}
	}
}
