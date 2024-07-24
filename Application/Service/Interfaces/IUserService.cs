using Application.DTOs.Response;

namespace Application.Service.Interfaces;

public interface IUserService
{
    Task<IEnumerable<UserDto>> GetUsers(CancellationToken cancellationToken = default);
    Task<UserDto> GetUser(int id, CancellationToken cancellationToken = default);
}