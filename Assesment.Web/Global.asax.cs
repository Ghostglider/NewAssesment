using Assesment.Web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Assesment.Web
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
			//SimpleInjectorConfig.UseContainer(GlobalConfiguration.Configuration);
			SimpleInjectorMemoryConfig.UseContainer(GlobalConfiguration.Configuration);
		}
    }
}
