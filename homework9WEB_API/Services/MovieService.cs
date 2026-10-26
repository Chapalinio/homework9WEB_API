using homework9WEB_API.Models;
using homework9WEB_API.Repositories;

namespace homework9WEB_API.Services;

public class MovieService
{
    private readonly IMovieRepository _movieRepository;
    public MovieService(IMovieRepository repository)
    {
        _movieRepository = repository;
    }

    public void Add(Movie movie)
    {
        var tempMovie = _movieRepository.GetById(movie.Id);
        
        if (tempMovie == null)
        {
            _movieRepository.Add(movie);
        }
    }

    public void Remove(int id)
    {
        var movieToDelete = _movieRepository.GetById(id);

        if (movieToDelete != null)
        {
            _movieRepository.Remove(id);
        }
    }

    public List<Movie> GetAll()
    {
        return _movieRepository.GetAll();
    }
    
    public Movie GetById(int id)
    {
        var tempMovie = _movieRepository.GetById(id);
        
        if(tempMovie != null)
        {
            return tempMovie;
        }

        return new Movie();
    }

    public Movie GetByTitle(string title)
    {
        var tempMovie = _movieRepository.GetByTitle(title);

        if(tempMovie != null)
        {
            return tempMovie;
        }

        return new Movie();
    }
}
