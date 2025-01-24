using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ProductRefitService.Infra.Extensions;


namespace ProductRefitService.IoC.ModuleInitializers
{
    internal class InfrastructureModuleInitializer : IModuleInitializer
    {
        public void Initialize(WebApplicationBuilder builder)
        {
            builder.Services.AddExternalApiClients(builder.Configuration);
        }
    }
}
