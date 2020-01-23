using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AdminLte
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseAdminLte(this IApplicationBuilder app, Action<LteLayoutOptions> optionAction = null)
        {
            var options = app.ApplicationServices.GetRequiredService<LteLayoutOptions>();
            optionAction?.Invoke(options);

            return app;
        }
    }
}
