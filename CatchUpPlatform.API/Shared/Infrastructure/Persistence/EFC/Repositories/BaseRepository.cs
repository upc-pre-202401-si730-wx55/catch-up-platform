using CatchUpPlatform.API.Shared.Domain.Repositories;

namespace CatchUpPlatform.API.Shared.Infrastructure.Persistence.EFC.Repositories;

public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
{
    public Task AddAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> FindByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public void Remove(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TEntity>> ListAsync()
    {
        throw new NotImplementedException();
    }
}