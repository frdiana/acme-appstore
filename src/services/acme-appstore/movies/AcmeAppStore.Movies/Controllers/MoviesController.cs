using Acme.AppStore.Movies;
using Acme.AppStore.Movies.Models;
using Microsoft.AspNetCore.Mvc;

namespace Acme.AppStore.Movies.Controllers;
[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class MoviesController : ControllerBase
{
    private static Movie[] Movies => new Movie[] { new Movie("WhatsApp", "Messaging"), new Movie("TikTok", "Social Network"), new Movie("Youtube", "Media"), new Movie("Twitter", "Social Network"), new Movie("Spotify", "Music") };

    [HttpGet(Name = "GetMovies")]
    public Movie[] Get()
    {
        return Movies;
    }
}