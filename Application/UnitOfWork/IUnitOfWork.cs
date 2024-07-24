using Application.Repository.Interfaces;

namespace Application.UnitOfWork;

public interface IUnitOfWork
{
    IUserRepository UserRepository { get; }
    //Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default);
}