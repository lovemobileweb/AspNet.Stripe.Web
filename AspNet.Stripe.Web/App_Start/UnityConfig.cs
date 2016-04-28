using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using AspNet.Stripe.Web.Services.Contracts;
using AspNet.Stripe.Web.Services;
using AspNet.Stripe.Web.Config.Contracts;
using AspNet.Stripe.Web.Config;

namespace AspNet.Stripe.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<IConfigProvider, ConfigProvider>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}