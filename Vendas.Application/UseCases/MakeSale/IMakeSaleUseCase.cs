namespace Vendas.Application.UseCases.MakeSale;

public interface IMakeSaleUseCase
{
    Task<MakeSaleResponse> HandleAsync(MakeSaleRequest request);
}
