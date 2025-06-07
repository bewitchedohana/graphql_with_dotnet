using Movies.API.GraphQL.Queries;

namespace Movies.API.GraphQL.Schemas;

public class MovieSchema : Schema
{
    public MovieSchema(IServiceProvider serviceProvider) : base(serviceProvider)
    {
        Query = serviceProvider.GetRequiredService<MovieQuery>();
    }
}
