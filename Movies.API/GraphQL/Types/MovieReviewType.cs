namespace Movies.API.GraphQL.Types;

public class MovieReviewType : ObjectGraphType<MovieReview>
{
    public MovieReviewType()
    {
        Field(review => review.Id).Description("The review's ID");
        Field(review => review.Movie).Description("The review's movie");
        Field(review => review.Rate).Description("The review's rate");
        Field(review => review.Comment).Description("The review's comment");
        Field(review => review.CreatedAt).Description("The review's date");
        Field(review => review.MovieId).Description("The review's movie's ID");
    }
}
