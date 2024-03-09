using Mythos.Core.APIGateway;
using Mythos.Core.Logging;

namespace Mythos.ASPWebAPI
{
	public class APIInitializer : IAPIInitializer
	{
		private readonly ILog _log;

		public APIInitializer(ILog log)
		{
			_log = log;
		}

		public void Initialize()
		{
			_log.LogInfo("Initializing API");
			WebApplicationBuilder builder = WebApplication.CreateBuilder();

			// Add services to the container.
			builder.Services.AddAuthorization();

			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			WebApplication app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();

			string[] summaries = new[]
			{
				"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
			};

			app.MapGet("/weatherforecast", (HttpContext httpContext) =>
			{
				WeatherForecast[] forecast = Enumerable.Range(1, 5).Select(index =>
					new WeatherForecast
					{
						Date = DateTime.Now.AddDays(index),
						TemperatureC = Random.Shared.Next(-20, 55),
						Summary = summaries[Random.Shared.Next(summaries.Length)]
					})
					.ToArray();
				return forecast;
			})
			.WithName("GetWeatherForecast");

			app.Run();
		}
	}
}
