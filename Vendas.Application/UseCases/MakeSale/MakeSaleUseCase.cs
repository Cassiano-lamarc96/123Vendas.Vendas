using Vendas.Domain.Entity;

namespace Vendas.Application.UseCases.MakeSale;

public class MakeSaleUseCase : IMakeSaleUseCase
{
    public async Task<MakeSaleResponse> HandleAsync(MakeSaleRequest request)
    {
        var sale = new Sale().CreateSale(request.customerGuid, request.companyBranchGuid);
        List<SaleItem> items = new List<SaleItem>();
        request.items.ForEach(x =>
        {
            items.Add(new SaleItem().CreateSaleItem(sale.Guid, x.productGuid, x.price, x.discount, x.quantity));
        });
        sale.AddItemToSale(items);

        return new MakeSaleResponse
        {
            NewSaleGuid = sale.Guid,
        };
    }
}
