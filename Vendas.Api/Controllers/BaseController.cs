using Microsoft.AspNetCore.Mvc;

namespace Vendas.Api.Controllers
{
    public class BaseController : Controller
    {
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
                return BadRequest(new
                {
                    mensagemErro = ex.Message,
                });
            }
        }
    }
}
