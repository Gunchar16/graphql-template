using Application.DTOs.Response;
using Application.Repository.Interfaces;
using Application.Service.Interfaces;

namespace Application.Service.Implementation;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<IEnumerable<UserDto>> GetUsers(CancellationToken cancellationToken = default)
        => await _userRepository.GetAllUsersAsync(cancellationToken: cancellationToken);

    public async Task<UserDto> GetUser(int id, CancellationToken cancellationToken = default)
        => await _userRepository.GetUserByIdAsync(id, cancellationToken: cancellationToken);
}