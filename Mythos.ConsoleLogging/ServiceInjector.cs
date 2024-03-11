using Microsoft.Extensions.DependencyInjection;
using Mythos.ConsoleLogging.Loggers;
using Mythos.Core.DependencyInjection;
using Mythos.Core.Logging;
using System.ComponentModel.Composition;

namespace Mythos.ConsoleLogging
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
