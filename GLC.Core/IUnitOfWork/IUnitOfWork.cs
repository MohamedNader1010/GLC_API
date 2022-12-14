using GLC.Core.IRepositories;
using GLC.Core.Resources;
using GLC.Cores.Models;

namespace GLC.Core.IUnitOfWork
{
  public interface IUnitOfWork : IDisposable
  {
    // Add your Models here with ONLY <get> property.
    // **** Assume that we have Students Model ****
    IGenericRepository<Student, StudentResource> Students { get; }
    IGenericRepository<GroupChat, GroupChatResource> GroupChats { get; }
    IChatRepository Chats { get; }
    IGenericRepository<ChatingDetails, ChattingDetailsResource> ChattingDetails { get; }
    //int Complete(); implement SaveChanges()
    //void Complete();
    Task<int> CompleteAsync(); // implement SaveChangesAsync()
                               //Task ComleteAsync(); Or implement as void.
  }
    public interface IUnitOfWork : IDisposable
    {
        // Add your Models here with ONLY <get> property.
        // **** Assume that we have Students Model ****
     
        IGenericRepository<Student,StudentResource> Students { get; }
        IChatinggDetales chatingDetails { get; }
        ITeacher teachers { get; }
        IVideo videos { get; }
        ISubject subject { get; }
        //int Complete(); implement SaveChanges()
        //void Complete();
        Task<int> CompleteAsync(); // implement SaveChangesAsync()
        //Task ComleteAsync(); Or implement as void.
    }
}
