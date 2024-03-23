namespace Mythos.ASPWebAPI.HostedService
{
	internal class HostService : IHostedService
	{
		private readonly IHostApplicationLifetime _applicationLifetime;

		public HostService(IHostApplicationLifetime applicationLifetime)
		{
			_applicationLifetime = applicationLifetime;
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
			//
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
