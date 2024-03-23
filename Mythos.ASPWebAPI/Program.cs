using Microsoft.OpenApi.Models;
using Mythos.ASPWebAPI.HostedService;
using System.Reflection;

namespace Mythos.ASPWebAPI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			WebApplicationBuilder builder = WebApplication.CreateBuilder();
			builder.Services.AddHostedService<HostService>();
			builder.Services.AddPlugins();
			builder.Services.AddAuthorization();

			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen(options =>
			{
				options.SwaggerDoc("v1", new OpenApiInfo
				{
					Title = "Mythos API",
					Version = "v1",
					Description = "An API used to modify character data in the Mythos system."
				});

				string xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
				string xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
				options.IncludeXmlComments(xmlPath);
			});

			builder.Services.AddHealthChecks();
			builder.Services.AddControllers().AddNewtonsoftJson();
			
			WebApplication app = builder.Build();

			app.MapHealthChecks("/health");

			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI(options =>
				{
					options.SwaggerEndpoint("/swagger/v1/swagger.json", "Mythos API V1");
				});
			}

			app.UseHttpsRedirection();
			app.UseAuthorization();
			app.MapControllers();
			app.Run();
		}
	}
}