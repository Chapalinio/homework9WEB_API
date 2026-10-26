namespace homework9WEB_API.Models;

public class Director
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public string PortraitUrl { get; set; } = string.Empty;

    public List<Movie>? Movies { get; set; }
}
