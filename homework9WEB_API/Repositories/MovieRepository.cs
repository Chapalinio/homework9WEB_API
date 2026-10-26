using homework9WEB_API.Models;
using lesson9WEB_API.Context;

namespace homework9WEB_API.Repositories;

public class MovieRepository : IMovieRepository
{
    private readonly AppDBContext _appContext;
    public MovieRepository(AppDBContext context)
    {
        _appContext = context;
    }

    public void Add(Movie movie)
    {
        _appContext.Add(movie);
        _appContext.SaveChanges();
    }

    public void Remove(int id)
    {
        var movieToDelete = _appContext.Movies.FirstOrDefault(m => m.Id == id);
        _appContext.Remove(movieToDelete);
        _appContext.SaveChanges();
    }

    public List<Movie> GetAll()
    {
        return _appContext.Movies.ToList();
    }

    public Movie GetById(int id)
    {
        return _appContext.Movies.FirstOrDefault(m => m.Id == id);
    }

    public Movie GetByTitle(string title)
    {
        return _appContext.Movies.FirstOrDefault(m => m.Title == title);
    }
}
