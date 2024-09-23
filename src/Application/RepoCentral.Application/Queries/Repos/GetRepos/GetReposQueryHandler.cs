namespace RepoCentral.Application.Queries.Repos;

public record GetReposQuery() : IQuery<GetRepoResult>;
public record GetRepoResult(IEnumerable<RepoDTO> Repos);

public class GetReposQueryHandler : IQueryHandler<GetReposQuery, GetRepoResult>
{
    public Task<GetRepoResult> Handle(GetReposQuery query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
