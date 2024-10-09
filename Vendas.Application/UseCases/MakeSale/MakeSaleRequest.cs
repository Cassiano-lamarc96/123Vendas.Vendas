namespace Vendas.Application.UseCases.MakeSale;

public record MakeSaleRequest(List<MakeSaleItemRequest> items, Guid customerGuid, Guid companyBranchGuid);

public record MakeSaleItemRequest(Guid productGuid, decimal price, decimal discount, int quantity);
