using Microsoft.Extensions.DependencyInjection;
using System;
using Neurotech.Api.AutoMapper;
using AutoMapper;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.IO;

namespace Neurotech.Api.Configuration
{
    public static class SwaggerConfig
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Neurotech API",
                    Description = "API para integração com o motor de análise da Neurotech"
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
        }
    }
}
