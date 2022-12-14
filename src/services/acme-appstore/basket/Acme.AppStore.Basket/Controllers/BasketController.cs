using Microsoft.AspNetCore.Mvc;

namespace Acme.AppStore.Basket.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class BasketController : ControllerBase
    {
        [HttpGet(Name = "GetBasketByUserId")]
        public IActionResult Get(string userId)
        {
            return Ok();
        }
    }
}
