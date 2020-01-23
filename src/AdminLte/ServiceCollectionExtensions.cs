using Microsoft.Extensions.DependencyInjection;

namespace AdminLte
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
