using Microsoft.Extensions.DependencyInjection;
using Mythos.Activities.Characters;
using Mythos.Activities.Model;
using Mythos.Core.Activities;
using Mythos.Core.DependencyInjection;
using System.ComponentModel.Composition;

namespace Mythos.Activities
{
    [Export(typeof(IServiceInjector))]
	public class ServiceInjector : IServiceInjector
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddScoped<IFetchAllDocuments<Character>, CharacterAllGetter>();
			services.AddScoped<IFetchADocument<Character>, CharacterSingleGetter>();
			services.AddScoped<ICreateADocument<Character>, CharacterCreator>();
			services.AddScoped<IUpdateADocument<Character>, CharacterUpdater>();
			services.AddScoped<IDeleteADocument<Character>, CharacterDeleter>();
			services.AddScoped<ICRUDActivity<Character>, GenericCRUDActivity<Character>>();
		}
	}
}
