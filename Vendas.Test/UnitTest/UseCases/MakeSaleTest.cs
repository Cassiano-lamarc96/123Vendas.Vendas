using Vendas.Application.UseCases.MakeSale;
using Xunit;

namespace Vendas.Test.UnitTest.UseCases;

public class MakeSaleTest
{
    public MakeSaleTest(IMakeSaleUseCase makeSaleUseCase)
    {
        _makeSaleUseCase = makeSaleUseCase;
    }

    private readonly IMakeSaleUseCase _makeSaleUseCase;

    [Fact(DisplayName = "Make a sale")]
    [Trait("UseCase", "Make a Sale")]
    public async Task MakeSale()
    {
        //Arrange
        var requestItem = new List<MakeSaleItemRequest>() { new MakeSaleItemRequest(new Guid(), 10.20M, 10, 1), new MakeSaleItemRequest(new Guid(), 25.13M, 20, 15) };
        var request = new MakeSaleRequest(requestItem, new Guid(), new Guid());

        //Act
        var response = await _makeSaleUseCase.HandleAsync(request);

        //Assert
        Assert.NotNull(response?.NewSaleGuid);
    }
}
