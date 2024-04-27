using Microsoft.Extensions.DependencyInjection;
using WDC.Order.Infrastructure.Bases.RepositoryBase;

namespace WDC.Order.Infrastructure;

public static class ModuleInfrastructureDependencies
{
    public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
    {
        services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));

        return services;
    }
}

