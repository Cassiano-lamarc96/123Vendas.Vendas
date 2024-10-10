using Microsoft.AspNetCore.Mvc;
using Vendas.Application.UseCases.MakeSale;

namespace Vendas.Api.Controllers.Sale
{
    [ApiController]
    [Route("api/v1/sale")]
    public class MakeSaleController : BaseController
    {
        public MakeSaleController(IMakeSaleUseCase makeSaleUseCase)
        {
            _makeSaleUseCase = makeSaleUseCase;
        }

        private readonly IMakeSaleUseCase _makeSaleUseCase;

        [HttpPost("")]
        public async Task<ActionResult> MakeSale([FromBody] MakeSaleRequest request)
            => await SafeExecutionCustomResponse(async () => { return await _makeSaleUseCase.HandleAsync(request); });
    }
}
