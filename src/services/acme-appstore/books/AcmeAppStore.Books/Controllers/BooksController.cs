using Acme.AppStore.Books.Models;
using Microsoft.AspNetCore.Mvc;

namespace Acme.AppStore.Books.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class BooksController : ControllerBase
{
    private static Book[] Books => new Book[] { new Book("WhatsApp", "Messaging"), new Book("TikTok", "Social Network"), new Book("Youtube", "Media"), new Book("Twitter", "Social Network"), new Book("Spotify", "Music") };

    [HttpGet(Name = "GetBooks")]
    public Book[] Get()
    {
        return Books;
    }
}
