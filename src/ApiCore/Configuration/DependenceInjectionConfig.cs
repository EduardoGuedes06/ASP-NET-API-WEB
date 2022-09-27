using DevIO.Business.Intefaces;
using DevIO.Data.Context;
using DevIO.Data.Repository;
using FluentAssertions.Common;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace ApiCore.Configuration
{
    public static class DependenceInjectionConfig
    {
        public static IServiceCollection ResolveDependecies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            return services;
        }
    }
}
