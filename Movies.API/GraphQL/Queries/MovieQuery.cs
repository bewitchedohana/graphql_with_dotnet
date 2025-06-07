using GraphQL;
using Microsoft.EntityFrameworkCore;
using Movies.API.Data;
using Movies.API.GraphQL.Types;

namespace Movies.API.GraphQL.Queries;

public sealed class MovieQuery : ObjectGraphType
{
    public MovieQuery(MoviesDbContext moviesContext)
    {
        Field<ListGraphType<MovieType>>("movies")
            .ResolveAsync(async _ => await moviesContext.Movies.ToListAsync());

        Field<MovieType>("movie")
            .Arguments(new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>>() { Name = "id" }))
            .ResolveAsync(async context =>
            {
                int id = context.GetArgument<int>("id");
                Movie? movie = await moviesContext.Movies.FirstOrDefaultAsync(_ => _.Id.Equals(id));
                return movie;
            });
    }
}
