using Application.Repository.Interfaces;
using Application.UnitOfWork;
using Infrastructure.Repository.Implementation;

namespace Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    //private readonly ExampleDataContext _context;
    private IUserRepository _userRepository;
    
    public IUserRepository UserRepository { get; }

    //public IUserRepository UserRepository
    //{
    //    get
    //    {
    //        if (_userRepository is null)
    //            _userRepository = new UserRepository(_context);
    //        return _userRepository;
    //    }
    //}
    //public async Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default) 
    //    => await _context.SaveChangesAsync(cancellationToken: cancellationToken) > 0;
}