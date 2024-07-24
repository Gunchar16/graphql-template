using Application.DTOs.Response;
using Application.Service.Interfaces;
using HotChocolate.Types;

namespace GraphQLApi.GraphTypes.UserGType.Query;

[ExtendObjectType("Query")]
public abstract class UserQuery
{
    private readonly IUserService _userService;

    protected UserQuery(IUserService userService)
    {
        _userService = userService;
    }
    
    [GraphQLName("user")]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public async Task<IEnumerable<UserDto>> GetUsers(CancellationToken cancellationToken)
    {
        return await _userService.GetUsers(cancellationToken);
    }

    [GraphQLName("userById")]
    public async Task<UserDto> GetUserById(int id, CancellationToken cancellationToken)
    {
        return await _userService.GetUser(id, cancellationToken);
    }
}