namespace RepoCentral.Infrastructure.Repositories;

public class RepoRepository : IRepoRepository
{
    private readonly DatabaseContext _context;

    public Task<Repo> AddRepo(Repo repo)
    {
        throw new NotImplementedException();
    }

    public Task<Repo> DeleteRepo(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Repo> GetRepo(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Repo>> GetRepos()
    {
        throw new NotImplementedException();
    }

    public Task<Repo> UpdateRepo(Repo repo)
    {
        throw new NotImplementedException();
    }
}
