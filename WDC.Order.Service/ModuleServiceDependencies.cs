using Microsoft.Extensions.DependencyInjection;

namespace WDC.Order.Service;

public static class ModuleServiceDependencies
{
    public static IServiceCollection AddServiceDependencies(this IServiceCollection service)
    {
        return service;
    }
}