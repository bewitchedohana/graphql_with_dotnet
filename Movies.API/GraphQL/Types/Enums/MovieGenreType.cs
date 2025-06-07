using Movies.API.Models.Enums;

namespace Movies.API.GraphQL.Types.Enums;

public class MovieGenreType : EnumerationGraphType<MovieGenre>
{
    public MovieGenreType()
    {
        Name = "Genre";
        Description = "The movie's genre.";
    }
}
