using Acme.AppStore.Movies;
using Acme.AppStore.Movies.Models;
using Microsoft.AspNetCore.Mvc;

namespace Acme.AppStore.Movies.Controllers;
[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class MoviesController : ControllerBase
{
    private static Movie[] Movies => new Movie[] { new Movie("The Godfather", "Movie"), new Movie("Forrest Gump", "Movie"), new Movie("Avatar", "Movie"), new Movie("Titanic", "Movie"), new Movie("Heat", "Music") };

    [HttpGet(Name = "GetMovies")]
    public Movie[] Get()
    {
        return Movies;
    }
}