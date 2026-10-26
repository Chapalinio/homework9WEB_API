using homework9WEB_API.Models;
using homework9WEB_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace homework9WEB_API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MovieController : ControllerBase
{
    private readonly MovieService _movieService;
    public MovieController(MovieService service)
    {
        _movieService = service;
    }

    [HttpGet]
    public ActionResult<List<Movie>> GetAllMovies()
    {
        return Ok(_movieService.GetAll());
    }

    [HttpGet("{id}")]
    public ActionResult<Movie> GetMovieById([FromRoute] int id)
    {
        return Ok(_movieService.GetById(id));
    }

    [HttpGet("by-title")]
    public ActionResult<Movie> GetMovieByTitle([FromQuery] string title)
    {
        return Ok(_movieService.GetByTitle(title));
    }

    [HttpPost]
    public ActionResult AddMovie([FromBody] Movie movie)
    {
        _movieService.Add(movie);
        return Ok();
    }

    [HttpDelete("remove/{id}")]
    public ActionResult RemoveMovie([FromRoute] int id)
    {
        _movieService.Remove(id);
        return NoContent();
    }

}
