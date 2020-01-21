using Microsoft.Extensions.DependencyInjection;

namespace AdminLte.Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAdminLte(this IServiceCollection services)
        {
            services.AddSingleton<LteLayoutOptions>();

            return services;
        }
    }
}
