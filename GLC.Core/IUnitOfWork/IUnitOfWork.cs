using GLC.Core.IRepositories;
using GLC.Cores.Models;

namespace GLC.Core.IUnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        // Add your Models here with ONLY <get> property.
        // **** Assume that we have Students Model ****
        IGenericRepository<Student> Students { get; }

        //int Complete(); implement SaveChanges()
        //void Complete();
        Task<int> CompeteAsync(); // implement SaveChangesAsync()
        //Task ComleteAsync(); Or implement as void.
    }
}
