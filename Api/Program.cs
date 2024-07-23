using Api.GraphQL;
using GraphQL;
using GraphQL.Types;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpContextAccessor();

builder.Services.AddSingleton<TemplateQuery>();
builder.Services.AddSingleton<TemplateMutation>();
builder.Services.AddSingleton<TemplateSchema>();

builder.Services.AddGraphQL(b => b
    .AddAutoSchema<TemplateSchema>()
    .AddSystemTextJson());



var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.UseGraphQL<TemplateSchema>();



if (app.Environment.IsDevelopment())
{
    app.UseGraphQLPlayground();
}

app.Run();