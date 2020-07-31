using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Neurotech.Services
{
    public static class Bootstrapper
    {
        public static IServiceCollection UsarServicesHandlers(this IServiceCollection services)
        {
            return services
                .AddMediatR(typeof(Bootstrapper).Assembly);
        }

        public static IServiceCollection UsarNeurotechApi(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient("neurotech", client => configuration.GetSection("Neurotech").Bind(client));

            return services;
        }

    }
}
