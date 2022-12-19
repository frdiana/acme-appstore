using Acme.AppStore.Books.Models;
using Microsoft.AspNetCore.Mvc;

namespace Acme.AppStore.Books.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class BooksController : ControllerBase
{
    private static Book[] Books => new Book[] { new Book("Anna Karenina", "Novel"), new Book("Madame Bovary", "Novel"), new Book("War and Peace", "Novel"), new Book("The Adventures of Huckleberry Finn", "Novel"), new Book("Hamlet ", "Novel") };

    [HttpGet]
    public Book[] Get()
    {
        return Books;
    }
}
