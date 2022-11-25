using Acme.AppStore.Games;
using Acme.AppStore.Games.Models;
using Microsoft.AspNetCore.Mvc;

namespace Acme.AppStore.Games.Controllers;
[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class GamesController : ControllerBase
{
    private static Game[] Games => new Game[] { new Game("WhatsApp", "Messaging"), new Game("TikTok", "Social Network"), new Game("Youtube", "Media"), new Game("Twitter", "Social Network"), new Game("Spotify", "Music") };

    [HttpGet(Name = "GetGames")]
    public Game[] Get()
    {
        return Games;
    }
}