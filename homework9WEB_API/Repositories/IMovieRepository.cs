using homework9WEB_API.Models;

namespace homework9WEB_API.Repositories;

public interface IMovieRepository : IRepository<Movie>
{
    Movie GetByTitle(string title);
}
