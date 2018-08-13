using SimpleInjector;
using System.Web.Http;
using Data;
using SimpleInjector.Lifestyles;
using SimpleInjector.Integration.WebApi;
using Data.Repositories;
using Assesment.Web.Mapping;
using Data.Models;

namespace Assesment.Web.App_Start
{
	public static class SimpleInjectorMemoryConfig
	{
		public static Container UseContainer(HttpConfiguration configuration)
		{
			var container = new Container();

			container.Options.DefaultLifestyle = Lifestyle.Scoped;
			container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
			container.Options.AllowOverridingRegistrations = true;

			//context
			container.Register<IMemoryContext, MemoryContext>();

			//repository
			container.Register<IPersonRepository, PersonMemoryRepository>();

			//Mapping
			container.Register<IMappingPerson, MappingPerson>();

			container.Verify();

			configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
			return container;
		}
	}
}