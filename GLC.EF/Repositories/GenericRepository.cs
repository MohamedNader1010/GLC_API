using GLC.Core.IRepositories;
using System.Linq.Expressions;
using GLC.Cores.Models;

namespace GLC.EF.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly GLCDbContext _context;

        public GenericRepository(GLCDbContext context)
        {
            this._context = context;
        }

        public async Task<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            //return await _context.Set<TEntity>().SingleOrDefaultAsync(predicate);
            throw new NotImplementedException();
        }



        public async Task<IAsyncEnumerable<TEntity>> GetAllAsync()
        {
            //return await _context.Set<TEntity>().ToListAsync();
            throw new NotImplementedException();
        }

        public async Task<TEntity> GetByEmailAsync(string email)
        {
            //use your context here 
            // eg: return await _context.set<TEntity>().SingleOrDefaultAsync(e => e.Email == email);
            throw new NotImplementedException();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
