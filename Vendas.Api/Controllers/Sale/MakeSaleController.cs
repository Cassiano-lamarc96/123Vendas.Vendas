using Microsoft.AspNetCore.Mvc;
using Vendas.Application.UseCases.MakeSale;

namespace Vendas.Api.Controllers.Sale
{
    [ApiController]
    [Route("api/v1/sale")]
    public class MakeSaleController : BaseController
    {
        public MakeSaleController(IMakeSaleUseCase makeSaleUseCase, ILogger<MakeSaleController> logger) : base (logger)
        {
            _logger = logger;
            _makeSaleUseCase = makeSaleUseCase;
        }

        private readonly ILogger<BaseController> _logger;
        private readonly IMakeSaleUseCase _makeSaleUseCase;

        [HttpPost("")]
        public async Task<ActionResult> MakeSale([FromBody] MakeSaleRequest request)
            => await SafeExecutionCustomResponse(async () => { 
                _logger.LogInformation(System.Text.Json.JsonSerializer.Serialize(request));
                return await _makeSaleUseCase.HandleAsync(request); });
    }
}
