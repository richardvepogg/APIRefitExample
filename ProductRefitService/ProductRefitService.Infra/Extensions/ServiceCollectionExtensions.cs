using ProductRefitService.Infra.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace ProductRefitService.Infra.Extensions
{
    public static class ServiceCollectionExtensionss
    {
        private const string ConfigExternalProductServiceWebApi = "External:ProductService.WebApi";

        public static IServiceCollection AddExternalApiClients(this IServiceCollection services, IConfiguration configuration)
        {
            var baseUrlProductWebApi = configuration[ConfigExternalProductServiceWebApi];

            services.AddRefitClient<IProductRefit>()
                .ConfigureHttpClient(config => config.BaseAddress = new Uri(baseUrlProductWebApi!));

            return services;
        }
    }
}
