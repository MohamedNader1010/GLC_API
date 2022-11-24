using AutoMapper;
using GLC.Core.IRepositories;
using GLC.Core.IUnitOfWork;
using GLC.Core.Resources;
using GLC.Cores.Models;
using GLC.EF.Repositories;

namespace GLC.EF.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GLCDbContext _context;
        private readonly IMapper _mapper;

        // add all your models here as the line below.
        public IGenericRepository<Student, StudentResource> Students { get; private set; }

        //public IGenericRepository<Test> Tests { get; private set; }
        public UnitOfWork(GLCDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            // initialize all the models as the line below.
            Students = new GenericRepository<Student, StudentResource>(_context, _mapper);
            //Tests = new GenericRepository<Test>(_context);
        }
        public async Task<int> CompleteAsync()
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
