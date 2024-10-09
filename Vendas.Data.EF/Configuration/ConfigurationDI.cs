using Microsoft.Extensions.DependencyInjection;
using Vendas.Data.EF.Repository;
using Vendas.Domain.RepositoryInterfaces;

namespace Vendas.Data.EF.Configuration;

public static class ConfigurationDI
{
    public static void AddEntityFramework(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<ISaleRepository, SaleRepository>();
    }
}
