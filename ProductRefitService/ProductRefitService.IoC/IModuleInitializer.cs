using Microsoft.AspNetCore.Builder;


namespace ProductRefitService.IoC
{
    public interface IModuleInitializer
    {
        void Initialize(WebApplicationBuilder builder);
    }
}
