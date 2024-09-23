namespace RepoCentral.API.Endpoints.Repos;

public record GetReposResponse(IEnumerable<RepoDTO> Repos);

public class RepoEndpoints : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/repos",
            async (ISender sender) =>
            {

            })
            .Produces<GetReposResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithName("GetRepos")
            .WithSummary("Get all repos");
    }
}
