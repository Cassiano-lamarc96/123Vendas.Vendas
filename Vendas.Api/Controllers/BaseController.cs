using Microsoft.AspNetCore.Mvc;

namespace Vendas.Api.Controllers
{
    public class BaseController : Controller
    {
        public BaseController(ILogger<BaseController> logger)
        {
            _logger = logger;
        }

        private readonly ILogger<BaseController> _logger;

        protected async Task<ActionResult> SafeExecutionCustomResponse(Func<Task<object>> action)
        {
            try
            {
                var actionResult = await action();
                return Ok(new
                {
                    success = true,
                    data = actionResult
                });
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"Error: {ex.Message}");
                return BadRequest(new
                {
                    mensagemErro = ex.Message,
                });
            }
        }
    }
}
