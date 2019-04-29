using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using Treinamentos.Domain.Repositories;
using Treinamentos.Infra.Repositories;
using Treinamentos.Infra.Contexts;

namespace Treinamentos.Web
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<AppDataContext, AppDataContext>();
            container.RegisterType<ICustomerRepository, CustomerRepository>();            

            return container;
        }
    }
}