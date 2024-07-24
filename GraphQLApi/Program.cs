using GraphQLApi.Configuration;
using GraphQLApi.GraphQL;
using GraphQLApi.GraphTypes.UserGType.Query;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddServices();

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddTypeExtension<UserQuery>()
    .AddProjections()
    .AddFiltering()
    .AddSorting();


var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL();

app.Run();