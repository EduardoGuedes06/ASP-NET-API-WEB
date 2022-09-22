using DevIO.Business.Intefaces;
using DevIO.Data.Context;
using DevIO.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace MinhaApiCompleta.Configuration
{
    public static class DependencyInjectionConfig 
    {
        public static IServiceCollection ResolveDependences(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IFornecedorRepository,FornecedorRepository>();

            return services;
        }
    }
}
