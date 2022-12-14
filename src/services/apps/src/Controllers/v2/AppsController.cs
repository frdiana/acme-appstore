using Acme.AppStore.Apps.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Acme.AppStore.Apps.Controllers.v2
{
    [ApiController, ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class AppsController : AppsControllerBase
    {
        [HttpGet, MapToApiVersion("2.0")]
        public App[] Get()
        {
            return Apps;
        }
    }
}
