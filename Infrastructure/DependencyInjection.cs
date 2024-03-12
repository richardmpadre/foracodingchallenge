using Application.Common.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddDbContext<InMemoryAppDbContext>((sp, options) =>
        {
            options.UseInMemoryDatabase("ForaDb");
        });
        services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<InMemoryAppDbContext>());

        return services;
    }
}