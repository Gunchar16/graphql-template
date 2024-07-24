using Application.DTOs.Response;
using Application.Repository.Interfaces;

namespace Infrastructure.Repository.Implementation;

public class UserRepository : IUserRepository
{
    private readonly IEnumerable<UserDto> _users;
    public UserRepository()
    {
        _users = new List<UserDto>
        {
            new UserDto
            {
                Id = 1,
                UserName = "Kukoldlal",
                FirstName = "Jalal",
                LastName = "Mammadov",
                Email = "calalmammadov2022@mail.ru",
                Status = true
            },
            new UserDto
            {
                Id = 2,
                UserName = "Farideh87",
                FirstName = "Farideh",
                LastName = "Hosseini",
                Email = "farideh.hosseini@example.com",
                Status = true
            },
            new UserDto
            {
                Id = 3,
                UserName = "goodguyjohn",
                FirstName = "Beqa",
                LastName = "Abulashvili",
                Email = "beqaniga@example.com",
                Status = true
            },
            new UserDto
            {
                Id = 4,
                UserName = "Armine55",
                FirstName = "Armine",
                LastName = "Sargsyan",
                Email = "armine.sargsyan@example.com",
                Status = true
            },
            new UserDto
            {
                Id = 5,
                UserName = "Batbayar99",
                FirstName = "Batbayar",
                LastName = "Ganbold",
                Email = "batbayar.ganbold@example.com",
                Status = true
            }
        };
    }
    
    public Task<IEnumerable<UserDto>> GetAllUsersAsync(CancellationToken cancellationToken = default)
        => Task.FromResult(_users);

    public Task<UserDto> GetUserByIdAsync(int id, CancellationToken cancellationToken = default)
        => Task.FromResult(_users.FirstOrDefault(u => u.Id == id));
}