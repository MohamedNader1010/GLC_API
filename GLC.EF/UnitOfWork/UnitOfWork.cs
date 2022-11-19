using GLC.Core.IRepositories;
using GLC.Core.IUnitOfWork;
using GLC.Cores.Models;
using GLC.EF.Repositories;

namespace GLC.EF.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GLCDbContext _context;

        // add all your models here as the line below.
        public IGenericRepository<Student> Students { get; private set; }
        public UnitOfWork(GLCDbContext context)
        {
            this._context = context;
            // initialize all the models as the line below.
            Students = new GenericRepository<Student>(_context);
        }
        public async Task<int> CompeteAsync()
        {
            // return the (n) affected rows.
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
