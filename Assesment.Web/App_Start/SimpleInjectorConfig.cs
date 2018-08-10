using SimpleInjector;
using System.Web.Http;
using Data;
using SimpleInjector.Lifestyles;
using SimpleInjector.Integration.WebApi;
using Data.Repositories;
using Assesment.Web.Mapping;

namespace Assesment.Web.App_Start
{
	public static class SimpleInjectorConfig
	{
		public static Container UseContainer(HttpConfiguration configuration)
		{
			var container = new Container();

			container.Options.DefaultLifestyle = Lifestyle.Scoped;
			container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
			container.Options.AllowOverridingRegistrations = true;

			//context
			container.Register<IAssesmentDbContext, AssesmentDbContext>();

			//repository
			container.Register<IPersonRepository, PersonRepository>();

			//Mapping
			container.Register<IMappingPerson, MappingPerson>();

			container.Verify();

			configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
			return container;
		}
	}
}