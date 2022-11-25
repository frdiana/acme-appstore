using Acme.AppStore.Apps.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace Acme.AppStore.Apps.Controllers.v1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class AppsController : AppsControllerBase
{
    [HttpGet]
    [MapToApiVersion("1.0")]
    public App[] Get()
    {
        return Apps;
    }
}
