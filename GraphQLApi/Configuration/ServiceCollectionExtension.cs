using Application.Repository.Interfaces;
using Application.Service.Implementation;
using Application.Service.Interfaces;
using Infrastructure.Repository.Implementation;

namespace GraphQLApi.Configuration;

internal static class ServiceCollectionExtension
{
    public static void AddServices(this IServiceCollection services)
    {
        //Services
        services.AddScoped<IUserService, UserService>();

        //Repositories
        services.AddScoped<IUserRepository, UserRepository>();
    }
}