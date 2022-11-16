using System.Linq.Expressions;

namespace GLC.Core.IRepositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(int id);
        Task<TEntity> GetByEmailAsync(string email);

        Task<IAsyncEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> Find(Expression<Func<TEntity, bool>> predicate);


    }
}
