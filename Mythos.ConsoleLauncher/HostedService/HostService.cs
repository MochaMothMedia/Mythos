using Microsoft.Extensions.Hosting;
using Mythos.Core.APIGateway;

namespace Mythos.ConsoleLauncher.HostedService
{
	internal class HostService : IHostedService
	{
		private readonly IHostApplicationLifetime _applicationLifetime;
		private readonly IAPIInitializer _apiInitializer;

		public HostService(IHostApplicationLifetime applicationLifetime, IAPIInitializer apiInitializer)
		{
			_applicationLifetime = applicationLifetime;
			_apiInitializer = apiInitializer;
		}

		public Task StartAsync(CancellationToken cancellationToken)
		{
			_applicationLifetime.ApplicationStarted.Register(OnStarted);
			_applicationLifetime.ApplicationStopping.Register(OnStopping);
			_applicationLifetime.ApplicationStopped.Register(OnStopped);

			return Task.CompletedTask;
		}

		public Task StopAsync(CancellationToken cancellationToken)
		{
			_applicationLifetime.StopApplication();

			return Task.CompletedTask;
		}

		private void OnStarted()
		{
			_apiInitializer.Initialize();
		}

		private void OnStopping()
		{
			//
		}

		private void OnStopped()
		{
			//
		}
	}
}
