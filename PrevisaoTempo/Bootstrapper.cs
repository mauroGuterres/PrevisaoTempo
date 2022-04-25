using System.Web.Mvc;
using Microsoft.Practices.Unity;
using PrevisaoTempo.Context;
using PrevisaoTempo.Contracts;
using PrevisaoTempo.Models;
using PrevisaoTempo.Repository;
using Unity.Mvc3;

namespace PrevisaoTempo
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
            container.RegisterType<PrevisaoTempoContext, PrevisaoTempoContext>();
            container.RegisterType<IPrevisaoClimaRepository, PrevisaoClimaRepository>();
            container.RegisterType<ICidadeRepository, CidadeRepository>();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();            

            return container;
        }
    }
}