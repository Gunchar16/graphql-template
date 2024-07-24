using Application.DTOs.Response;

namespace Application.Repository.Interfaces;

public interface IUserRepository
{
    Task<IEnumerable<UserDto>> GetAllUsersAsync(CancellationToken cancellationToken = default);
    Task<UserDto> GetUserByIdAsync(int id, CancellationToken cancellationToken = default);
}