using Movies.API.GraphQL.Types.Enums;

namespace Movies.API.GraphQL.Types;

public class MovieType : ObjectGraphType<Movie>
{
    public MovieType()
    {   
        Field(movie => movie.Id).Description("The movie's ID.");
        Field(movie => movie.Name).Description("The movie's name.");
        Field(movie => movie.Description).Description("The movie's description");
        Field(movie => movie.LaunchDate).Description("The movie's launch date");
        Field<MovieGenreType>("Genre").Description("The movie's genre");
        Field(movie => movie.Reviews).Description("The movie's reviews");
    }
}
