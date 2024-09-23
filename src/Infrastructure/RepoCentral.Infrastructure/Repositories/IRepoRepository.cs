namespace RepoCentral.Infrastructure.Repositories;

public interface IRepoRepository
{
    Task<IEnumerable<Repo>> GetRepos();
    Task<Repo> GetRepo(int id);
    Task<Repo> AddRepo(Repo repo);
    Task<Repo> UpdateRepo(Repo repo);
    Task<Repo> DeleteRepo(int id);
}
