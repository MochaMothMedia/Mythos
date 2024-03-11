using Mythos.ASPWebAPI.HostedService;

namespace Mythos.ASPWebAPI
{
	public class Program
	{
		public static void Main(string[] args)
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