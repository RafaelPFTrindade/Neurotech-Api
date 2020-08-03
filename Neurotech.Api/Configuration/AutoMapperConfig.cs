using Microsoft.Extensions.DependencyInjection;
using System;
using Neurotech.Api.AutoMapper;
using AutoMapper;

namespace Neurotech.Api.Configuration
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(ModelToValueObjectMappingProfile), typeof(ValueObjectToModelMappingProfile));
        }
    }
}
