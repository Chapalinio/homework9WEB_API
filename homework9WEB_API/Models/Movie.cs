namespace homework9WEB_API.Models;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public string PosterUrl { get; set; } = string.Empty;
    public int FilmLengthInMinuts { get; set; }

    public int DirectorId { get; set; }
    public Director? Director { get; set; }

    public List<Review>? Reviews { get; set; }
}
