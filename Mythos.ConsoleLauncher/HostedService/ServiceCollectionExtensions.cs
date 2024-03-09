using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.Composition.Primitives;
using System.Reflection;
using ImportDefinition = System.ComponentModel.Composition.Primitives.ImportDefinition;
using Mythos.Core.DependencyInjection;
using System.ComponentModel.Composition.Hosting;
using System.Text;

namespace Mythos.ConsoleLauncher.HostedService
{
	public static class ServiceCollectionExtensions
	{
		public static ImportDefinition BuildImportDefinition()
		{
			return new ImportDefinition(x => true, typeof(IServiceInjector).FullName, ImportCardinality.ZeroOrMore, false, false);
		}

		public static void AddPlugins(this IServiceCollection services)
		{
			Assembly assembly = Assembly.GetExecutingAssembly();
			if (assembly == null)
			{
				return;
			}

			string? path = Path.GetDirectoryName(assembly.Location);

			if (path == null)
			{
				return;
			}

			DirectoryCatalog catalog = new DirectoryCatalog(path);
			ImportDefinition importDefinition = BuildImportDefinition();

			try
			{
				using AggregateCatalog aggregate = new AggregateCatalog();
				aggregate.Catalogs.Add(catalog);

				using CompositionContainer composition = new CompositionContainer(aggregate);
				IEnumerable<Export> exports = composition.GetExports(importDefinition);
				IEnumerable<IServiceInjector> injectors = exports
					.Select(export => export.Value as IServiceInjector)
					.Where(export => export != null)!;

				foreach (IServiceInjector injector in injectors)
				{
					injector.ConfigureServices(services);
				}
			} catch (ReflectionTypeLoadException typeLoadException)
			{
				StringBuilder messageBuilder = new StringBuilder();

				foreach (Exception? loaderException in typeLoadException.LoaderExceptions)
				{
					if (loaderException == null)
					{
						continue;
					}

					messageBuilder.AppendFormat("{0}\n", loaderException.Message);
				}

				throw new TypeLoadException(messageBuilder.ToString(), typeLoadException);
			}
		}
	}
}
