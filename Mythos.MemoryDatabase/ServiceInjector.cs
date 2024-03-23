using Microsoft.Extensions.DependencyInjection;
using Mythos.Activities.Model;
using Mythos.Core.Database;
using Mythos.Core.DependencyInjection;
using Mythos.MemoryDatabase.Characters;
using System.ComponentModel.Composition;

namespace Mythos.MemoryDatabase
{
    [Export(typeof(IServiceInjector))]
	public class ServiceInjector : IServiceInjector
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddScoped<IGetADocument<Character>, CharacterDatabase>();
			services.AddScoped<IGetAllDocuments<Character>, CharacterDatabase>();
			services.AddScoped<ISaveADocument<Character>, CharacterDatabase>();
			services.AddScoped<IDeleteADocument<Character>, CharacterDatabase>();
		}
	}
}
