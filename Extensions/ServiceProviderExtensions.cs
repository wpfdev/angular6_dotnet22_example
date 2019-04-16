using Microsoft.Extensions.DependencyInjection;
using Test2.Services;

namespace Test2.DIExtensions
{
    public static class ServiceProviderExtensions
    {
         public static void AddDataService(this IServiceCollection services)
         {
            services.AddTransient<IDataService, DataService>();
         }
    }
}