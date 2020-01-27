using Microsoft.Extensions.DependencyInjection;

namespace AdminLte.TagHelpers
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
