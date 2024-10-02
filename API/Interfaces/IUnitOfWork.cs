using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IUnitOfWork
    {
        public IUserRepository UserRepository { get; }
        public ILikesRepository LikesRepository { get; }
        public IMessageRepository MessageRepository { get; }
        public Task<bool> Completed();
        public bool HasChanges();
    }
}