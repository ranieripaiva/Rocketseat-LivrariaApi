using Microsoft.AspNetCore.Mvc;

using LivrariaApi.Communication.Requests;
using LivrariaApi.Communication.Responses;
           
namespace LivrariaApi.Controllers;

public class BookController : BookApiBaseController
{
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetById([FromRoute] int id)
    {
        var response = new Book
        {
            Id = 1,
            Title = "Titanic",
            Author = "welisson",
            Genre = "Drama",
            Price = 100,
            StockQuantity = 20
        };       

        return Ok(response);
    }


    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredBookJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterBookJson request)
    {
        var response = new ResponseRegisteredBookJson
        {   
            Id = 1,
            Title = request.Title,
            Author = request.Author,
            Genre = request.Genre,
            Price = request.Price,
            StockQuantity = request.StockQuantity
        };

        return Created(string.Empty, response);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestUpdateBookJson request)
    {
        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete()
    {
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<Book>()
        {
            new Book {Id = 1, Title = "Title One", Author = "Tomaz", Genre = "Ficção", Price = 100, StockQuantity = 5},
            new Book {Id = 1, Title = "Title Two", Author = "Aquino", Genre = "Ficção", Price = 100, StockQuantity = 10},
            new Book {Id = 1, Title = "Title Three", Author = "Julio", Genre = "Ficção", Price = 100, StockQuantity = 15},
            new Book {Id = 1, Title = "Title Four", Author = "Vargas", Genre = "Ficção", Price = 100, StockQuantity = 25}
        };

        var key = GetCustomKey();

        return Ok(key);
    }
   
}
