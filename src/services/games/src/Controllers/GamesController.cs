using Acme.AppStore.Games;
using Acme.AppStore.Games.Models;
using Microsoft.AspNetCore.Mvc;

namespace Acme.AppStore.Games.Controllers;
[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class GamesController : ControllerBase
{
    private static Game[] Games => new Game[] { new Game("Fifa 2022", "Soccer simulation"), new Game("GTA", "Game"), new Game("Formula One", "Car simulation"), new Game("PES", "Soccer simulation"), new Game("Forza Motorsport", "Car simulation") };

    [HttpGet(Name = "GetGames")]
    public Game[] Get()
    {
        return Games;
    }
}