
using Microsoft.AspNetCore.Builder;
using ProductRefitService.IoC.ModuleInitializers;

namespace ProductRefitService.IoC
{
    public static class DependencyResolver
    {
        public static void RegisterDependencies(this WebApplicationBuilder builder)
        {
            new InfrastructureModuleInitializer().Initialize(builder);
            new WebApiModuleInitializer().Initialize(builder);
        }
    }
}
