using Microsoft.Extensions.DependencyInjection;
using SonarQube.Poc.Application.Services;
using SonarQube.Poc.Domain.Interfaces;
using SonarQube.Poc.Repository.Repositorios;

namespace SonarQube.Poc.IoC
{
    public static class BootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Repository
            Repository(services);

            // Application
            Application(services);
        }

        public static T GetService<T>()
        {
            var serviceCollection = new ServiceCollection();
            RegisterServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();
            return serviceProvider.GetService<T>();
        }

        public static T Resolve<T>()
        {
            return GetService<T>();
        }

        private static void Repository(IServiceCollection services)
        {
            services.AddTransient<MembroRepository>();
        }

        private static void Application(IServiceCollection services)
        {
            services.AddTransient<IMembroService, MembroService>();
        }
    }
}