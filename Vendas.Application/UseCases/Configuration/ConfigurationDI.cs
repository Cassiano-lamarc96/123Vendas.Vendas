using Microsoft.Extensions.DependencyInjection;
using Vendas.Application.UseCases.CancelSale;
using Vendas.Application.UseCases.CancelSaleItem;
using Vendas.Application.UseCases.EditSale;
using Vendas.Application.UseCases.GetSale;
using Vendas.Application.UseCases.GetSales;
using Vendas.Application.UseCases.MakeSale;

namespace Vendas.Application.UseCases.Configuration;

public static class ConfigurationDI
{
    public static void AddApplicationLayer(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<ICancelSaleUseCase, CancelSaleUseCase>();
        serviceCollection.AddScoped<ICancelSaleItemUseCase, CancelSaleItemUseCase>();
        serviceCollection.AddScoped<IEditSaleUseCase, EditSaleUseCase>();
        serviceCollection.AddScoped<IGetSaleUseCase, GetSaleUseCase>();
        serviceCollection.AddScoped<IGetSalesUseCase, GetSalesUseCase>();
        serviceCollection.AddScoped<IMakeSaleUseCase, MakeSaleUseCase>();
    }
}
